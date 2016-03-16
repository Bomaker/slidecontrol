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
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
	
		}
		void Button_ejectMouseClick(object sender, MouseEventArgs e)
		{
			//
			//Bodack
			//
			
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
