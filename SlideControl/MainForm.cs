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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			_stateMachine = new StateControl();
			_stateMachine.StateChanged += StateMachine_StateChanged;
			
			// this will trigger one event
			_stateMachine.Initialize();
		}

		void StateMachine_StateChanged(object sender, StateLogEventArgs e)
		{
			//TODO: reflect the current state in the GUI in a nicer way
			this.Text = String.Format("SlideControl Panel - State = {0}", e.State);
		}
		
		void SerialPortDataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			// ex: if some error is detected notify the state machine
			//_stateMachine.HandleEvent(Event.error);
		}
		
		void Button_ejectMouseClick(object sender, MouseEventArgs e)
		{
			_stateMachine.HandleEvent(Event.usr_eject);
			
			// example for deactivating a button (should be done depending on state)
			button_eject.Enabled = false;
		}
		void Button_menuClick(object sender, EventArgs e)
		{
			// example for (re-)activating a button (should be done depending on state)
			button_eject.Enabled = true;
		}
	}
}
