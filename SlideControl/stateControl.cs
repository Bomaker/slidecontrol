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

		private ArduinoController _arduinoController;
		
		
		// constructor
		public StateControl()
		{
			_log = new List<StateLogEventArgs>();
			
			CurrentState = State.reset;
			
		}
		
		public void Initialize(MainForm mainform)
		{
						/*
			 * setup Arduino controller
			 */
			
			_arduinoController = new ArduinoController();
            _arduinoController.Setup(mainform);

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
				
				/* Tricky: One event might cause more than one state change (e.g. single_mode and
				 * back to idle right away. Also needed from unconnected state
				 * Therefore events are handeled until the state is stable
				*/
				HandleEvent(trigger);
			}
		}
		
		// Handle the event and return the current state
		public State HandleEvent(Event trigger)
		{
			//HACK: this shall not be needed, only react on events and set state + trigger event accordingly

			// statemashine must be run 2 times in order to execute also input
			// conditions of states
			
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
					
					_arduinoController.SetLedState(true);
					
					/* in case last state was unconnected
					 * throw message
					 * lastState = thisState;
					 */

					if (trigger ==  Event.exit)
					{
					 	// do nothing
					}
					
					/* 	in case there was one of these do:
					 * usr_play
					 * usr_rec
					 * usr_ff
					 * usr_rewind
					 */ 
					if (trigger ==  Event.usr_play || 
					   trigger ==  Event.usr_rec || 
					   trigger ==  Event.usr_ff || 
					   trigger ==  Event.usr_rewind)
					{
					 	GoToState(trigger, State.cont_action);
					}
					
					/*
					  * in case there was one of these:
					  * usr_eject
					  * usr_next
					  * usr_prev
					  * usr_cam
					  */
					if (trigger ==  Event.usr_eject || 
					   trigger ==  Event.usr_next || 
					   trigger ==  Event.usr_prev || 
					   trigger ==  Event.usr_cam)
					{
					 	GoToState(trigger, State.single_action);
					}
					
					/*
						 * if there was a usr_menu
						 * open settings menu
						 * lastState = thisState;
						 * thisState = states.cont_single;
						 */
					if (trigger ==  Event.usr_menu)
					{
					 	GoToState(trigger, State.menu);
					}

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
					 * stop or error ->	throw message
					 */
					
					
					/* reset counter and return to idle
					 * usr_eject -> 	reset 0 
					 */
					if (trigger ==  Event.usr_eject)
					{
					 	GoToState(Event.exit, State.idle);
					} else
					
											 
					/* usr_next -> 		set_dir configDirection
					 * 					switch 1
					 */
					if (trigger ==  Event.usr_next)
					{
					 	GoToState(Event.exit, State.idle);
					} else
					
					/* usr_prev ->		set_dir not(configDirection)
					 * 					switch 1
					 */
					if (trigger ==  Event.usr_prev)
					{
					 	GoToState(Event.exit, State.idle);
					} else
					
					/* 
					 * usr_cam -> 		trigger_cam
					 */
					if (trigger ==  Event.usr_cam)
					{
					 	GoToState(Event.exit, State.idle);
					} else 
					
					
					/* return to idle (this should never occur, because one of the above must
					 * have been done alredy
					 */
					if (trigger ==  Event.usr_stop)
					{
					 	GoToState(Event.exit, State.idle);
					} else
						
					{
						GoToState(Event.exit, State.idle);
					}
					
					break;
						
					
				case State.cont_action:
				
					/*
					 * stop or error ->	throw message
					 * lastState = thisState;
					 * thisState = states.idle;
					 */
					if (trigger ==  Event.usr_stop)
					{
					 	GoToState(trigger, State.idle);
					}
					
					if (trigger ==  Event.usr_play)
					{
					 	_arduinoController.SetLedState(false);
					}
					
				
					
					break;
				
				case State.menu:
					
					/*
					 * open config menu
					 * lastState = thisState;
					 * thisState = states.menu;
					 */
					if (trigger ==  Event.usr_menu_exit)
					{
					 	GoToState(trigger, State.idle);
					}
					
					break;

				default:
					throw new NotImplementedException(String.Format("State '{0}' is not handled", CurrentState));
					
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
