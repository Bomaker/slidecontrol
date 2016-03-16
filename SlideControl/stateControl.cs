/*
 * Created by SharpDevelop.
 * User: Sysop
 * Date: 14.03.2016
 * Time: 19:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Slidecontrol
{
	enum states {reset, unconnected, menu, idle, single_action, cont_action};
	
	/// <summary>
	/// Description of state.
	/// </summary>
	class stateControl
	{
		private states thisState;
		private states lastState;
		private states nextState;

		// constructor
		public stateControl()
		{
			private thisState = states.unconnected;
			private lastState = states.reset;
		}
		
		private void nextState() {
			
			// statemashine must be run 2 times in order to execute also input
			// conditions of states
			for (int i = 1; i <= 2; i++)
        	{
				switch (thisState){
						
					case unconnected:
						// try to connect
						// attempt should be done every second (triggered by ext timer)
						
						if (this.connectSerial == true) {
							lastState = states.thisState;
							thisState = states.idle;
						}
					
					case idle:
						
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
						
					case single_action:
						
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
							
						
					case cont_action:
					
						/*
						 * stop or error ->	throw message
						 * lastState = thisState;
						 * thisState = states.idle;
						 */
					
					case menu:
						
						/*
						 * open config menu
						 * lastState = thisState;
						 * thisState = states.menu;
						 */
						
				}
						
			}

		}
		
		private bool connectSerial() {
			// try to connect to serial using parameters from settin
			// do this by sending reset command
			// if answer is status 0 then there is a connection
			return true;
		}
	}
}
