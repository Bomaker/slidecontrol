using System;

namespace SlideControl
{
	public enum Event
	{
		// dummy event for initialization
		init,
		
		// events from serial interface
		serial_connected,
		
		usr_eject,
		usr_rewind,
		usr_ff,
		usr_prev,
		usr_next,
		usr_play,
		usr_rec,
		usr_cam,
		usr_menu,
		timeout,
		stop,
		error,
	}
}


