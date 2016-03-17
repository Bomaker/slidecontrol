using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SlideControl
{
	/// <summary>
	/// State machine, handling events and maintaining the current state 
	/// </summary>
	public class StateControl
	{
		// publicly accessible current state and last event
		public State CurrentState { get; private set; }
		
		// event triggered on event changes
		public event EventHandler<StateLogEventArgs> StateChanged;

		// all past transitions for logging and debugging purposes
		public ReadOnlyCollection<StateLogEventArgs> Log { get { return _log.AsReadOnly(); } }

		// internal r/w collection for the history		
		private List<StateLogEventArgs> _log;
		
		// constructor
		public StateControl()
		{
			_log = new List<StateLogEventArgs>();
			
			CurrentState = State.reset;
		}
		
		public void Initialize()
		{
			GoToState(Event.init, State.unconnected);
		}

		private void GoToState(Event trigger, State newState)
		{
			State fromState = CurrentState;
			State toState = newState;
			var log = new StateLogEventArgs(DateTime.Now, trigger, fromState, toState);

			// always log out the trial event if there was no effective change in state (debug purpose)
			_log.Add(log);
			
			// if we want the same state, then do nothing
			if (fromState != toState)
			{
				CurrentState = toState;
				var handler = StateChanged;
				if (handler != null)
					handler(this, log);
			}
		}
		
		// Handle the event and return the current state
		public State HandleEvent(Event trigger)
		{
			//HACK: this shall not be needed, only react on events and set state + trigger event accordingly

			// statemashine must be run 2 times in order to execute also input
			// conditions of states
			for (int i = 1; i <= 2; i++)
        	{
				switch (CurrentState)
				{
					case State.unconnected:
						// try to connect
						// attempt should be done every second (triggered by ext timer)
						
						if (ConnectSerial())
						{
							GoToState(Event.serial_connected, State.idle);
						}
						break;
					
					case State.idle:
						
						/* in case last state was unconnected
						 * throw message
						 * lastState = thisState;
						 */
						
						/* 	in case there was one of these do:
						 * usr_play
						 * usr_rec
						 * usr_ff
						 * usr_rewind
						 * lastState = thisState;
						 * thisState = states.cont_action;
						 */ 
						
						/*
						  * in case there was one of these:usr_eject
						  * usr_next
						  * usr_prev
						  * usr_cam
						  * lastState = thisState;
						  * thisState = states.cont_single
						  */
						
						/*
 						 * if there was a usr_menu
 						 * open settings menu
 						 * lastState = thisState;
 						 * thisState = states.cont_single;
 						 */
	
						/*
						  * if there was an error or timeout
						  * through error meesage and/or go to
						  * lastState = thisState;
						  * thisState = states.unconnected;
						  */
						break;
						
					case State.single_action:
						
						/*
						 * if lastState was idle
						 * check for events
						 * usr_eject -> 	reset 0 	
						 *
						 * usr_next -> 		set_dir configDirection
						 * 					switch 1
						 * 					
						 * usr_prev ->		set_dir not(configDirection)
						 * 					switch 1
						 * 
						 * usr_cam -> 		trigger_cam
						 * 
						 * stop or error ->	throw message
						 * 
						 * afterwards:
						 * lastState = thisState;
						 * thisState = states.idle;
						 */
						break;
							
						
					case State.cont_action:
					
						/*
						 * stop or error ->	throw message
						 * lastState = thisState;
						 * thisState = states.idle;
						 */
						break;
					
					case State.menu:
						
						/*
						 * open config menu
						 * lastState = thisState;
						 * thisState = states.menu;
						 */
						break;

					default:
						throw new NotImplementedException(String.Format("State '{0}' is not handled", CurrentState));
						
				}
			}
			return CurrentState;
		}
		
		// TODO: this shall not be part of the StateMachine
		private bool ConnectSerial()
		{
			// try to connect to serial using parameters from settings
			// do this by sending reset command
			// if answer is status 0 then there is a connection
			return true;
		}
	}
}
