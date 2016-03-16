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
		}
	}
}
