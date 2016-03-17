using System;

namespace SlideControl
{
	public class StateLogEventArgs : EventArgs
	{
		public StateLogEventArgs(DateTime ts, Event e, State from, State to)
		{
			Timestamp = ts;
			Event = Event;
			PreviousState = from;
			State = to;
		}

		public DateTime Timestamp {
			get;
			private set;
		}

		public Event Event {
			get;
			private set;
		}

		public State PreviousState {
			get;
			private set;
		}

		public State State {
			get;
			private set;
		}
	}
}


