using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SlideControl
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private StateControl _stateMachine;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			/*
			 * Setup statemachine
			 */
			// TODO: Add constructor code after the InitializeComponent() call.
			
			_stateMachine = new StateControl();

		


            
            // this will trigger one event
			_stateMachine.Initialize(this);

			_stateMachine.StateChanged += StateMachine_StateChanged;

		}

		void StateMachine_StateChanged(object sender, StateLogEventArgs e)
		{
			//TODO: reflect the current state in the GUI in a nicer way
			this.Text = String.Format("SlideControl Panel - State = {0}", e.State);
			
			// if e.state= idle: Alle buttons auf default (aktivierbar)
			// 
			
			switch (e.State)
				{
					case State.unconnected:
						// Only nenue is enabled
						//SetButtonsAllDisabled();
						break;
					
					case State.idle:
						
						/* 
						 * All buttons enabled
						 */
						SetButtonsDefault();
						
						break;
						
					case State.single_action:
						
						
						break;
							
						
					case State.cont_action:
					
						/*
						 * 
						 * only stop is enabled
						 */
						SetButtonsAllDisabled();
						button_stop.Enabled = true;						
						
						
						break;
					
					case State.menu:
						
						/*
						 * Hm, nothing special, because menu should be modal
						 */
						break;

					default:
						throw new NotImplementedException(String.Format("State '{0}' is not handled", e.State));
						
				}
			
			
			
			
		}
		
		void SerialPortDataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			// ex: if some error is detected notify the state machine
			//_stateMachine.HandleEvent(Event.error);
		}
		
		void Button_ejectMouseClick(object sender, MouseEventArgs e)
		{
			_stateMachine.HandleEvent(Event.usr_eject);
			
		}
		void Button_menuClick(object sender, EventArgs e)
		{
			// example for (re-)activating a button (should be done depending on state)
			//button_eject.Enabled = true;
			//button_eject.BackColor = SystemColors.Control;
			//button_eject.UseVisualStyleBackColor = true;
			
			// Create settings menu and hand over control
			this.Enabled = false;
			Settings SettingsMenu = new Settings();
			SettingsMenu.FormClosed += new FormClosedEventHandler(SettingsMenuClosed);
            SettingsMenu.Show();     
            
			
			_stateMachine.HandleEvent(Event.usr_menu);
		}
		void Button_rewindMouseClick(object sender, MouseEventArgs e)
		{
			button_rewind.BackColor = System.Drawing.Color.YellowGreen;
			_stateMachine.HandleEvent(Event.usr_rewind);
		}
		void Button_ffClick(object sender, EventArgs e)
		{
			button_ff.BackColor = System.Drawing.Color.YellowGreen;
			_stateMachine.HandleEvent(Event.usr_ff);
	
		}
		void Button_prevClick(object sender, EventArgs e)
		{
			_stateMachine.HandleEvent(Event.usr_prev);	
	
		}
		void Button_nextClick(object sender, EventArgs e)
		{
			_stateMachine.HandleEvent(Event.usr_next);	
	
		}
		void Button_playClick(object sender, EventArgs e)
		{
			button_play.BackColor = System.Drawing.Color.YellowGreen;
			_stateMachine.HandleEvent(Event.usr_play);
	
		}
		void Button_recClick(object sender, EventArgs e)
		{
			button_rec.BackColor = System.Drawing.Color.YellowGreen;
			_stateMachine.HandleEvent(Event.usr_rec);
	
		}
		void Button_camClick(object sender, EventArgs e)
		{
			_stateMachine.HandleEvent(Event.usr_cam);	
	
		}
		void Button_stopClick(object sender, EventArgs e)
		{
			_stateMachine.HandleEvent(Event.usr_stop);	
	
		}
		
		void SetButtonsDefault() {
			button_stop.Enabled = true;
			button_stop.UseVisualStyleBackColor = true;
			button_rewind.Enabled = true;
			button_rewind.UseVisualStyleBackColor = true;
			button_eject.Enabled = true;
			button_eject.UseVisualStyleBackColor = true;
			button_prev.Enabled = true;
			button_prev.UseVisualStyleBackColor = true;
			button_play.Enabled = true;
			button_play.UseVisualStyleBackColor = true;
			button_ff.Enabled = true;
			button_ff.UseVisualStyleBackColor = true;
			button_rec.Enabled = true;
			button_rec.UseVisualStyleBackColor = true;
			button_cam.Enabled = true;
			button_cam.UseVisualStyleBackColor = true;
			button_menu.Enabled = true;
			button_menu.UseVisualStyleBackColor = true;
			button_next.Enabled = true;
			button_next.UseVisualStyleBackColor = true;
			button_eject.Enabled = true;
			button_eject.UseVisualStyleBackColor = true;
			
			
		}

		void SetButtonsAllDisabled() {
			button_stop.Enabled = false;
			button_rewind.Enabled = false;
			button_eject.Enabled = false;
			button_prev.Enabled = false;
			button_play.Enabled = false;
			button_ff.Enabled = false;
			button_rec.Enabled = false;
			button_cam.Enabled = false;
			button_menu.Enabled = false;
			button_next.Enabled = false;
			button_eject.Enabled = false;
			
		}

		void SettingsMenuClosed(object sender, FormClosedEventArgs e)
		{
				this.Enabled = true;
				_stateMachine.HandleEvent(Event.usr_menu_exit);
		}


	}
}
