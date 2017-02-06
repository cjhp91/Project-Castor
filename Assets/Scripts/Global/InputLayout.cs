namespace CastorObsolete
{
	public interface InputLayout
	{
		int ButtonA { get; }
		int ButtonB { get; }
		int ButtonX { get; }
		int ButtonY { get; }

		int ButtonL { get; }
		int ButtonR { get; }

		int ButtonBack { get; }
		int ButtonStart { get; }

		int ButtonStickL { get; }
		int ButtonStickR { get; }

		int AxisLeftX { get; }
		int AxisLeftY { get; }

		int AxisTriggers { get; }

		int AxisRightX { get; }
		int AxisRightY { get; }

		int PadX { get; }
		int PadY { get; }

		int AxisTriggerLeft { get; }
		int AxisTriggerRight { get; }

		int ButtonUp { get; }
		int ButtonDown { get; }
		int ButtonLeft { get; }
		int ButtonRight { get; }
	}

	public class XBox360Layout : InputLayout
	{
		public int ButtonA { get{ return 0; } }
		public int ButtonB { get{ return 1; } }
		public int ButtonX { get{ return 2; } }
		public int ButtonY { get{ return 3; } }

		public int ButtonL { get{ return 4; } }
		public int ButtonR { get{ return 5; } }

		public int ButtonBack { get{ return 6; } }
		public int ButtonStart { get{ return 7; } }

		public int ButtonStickL { get{ return 8; } }
		public int ButtonStickR { get{ return 9; } }

		public int AxisLeftX { get{ return 1; } }
		public int AxisLeftY { get{ return 2; } }

		public int AxisTriggers { get{ return 3; } }

		public int AxisRightX { get{ return 4; } }
		public int AxisRightY { get{ return 5; } }

		public int PadX { get{ return 6; } }
		public int PadY { get{ return 7; } }

		public int AxisTriggerLeft { get{ return 9; } }
		public int AxisTriggerRight { get{ return 10; } }

		public int ButtonUp { get{ return 0; } }
		public int ButtonDown { get{ return 0; } }
		public int ButtonLeft { get{ return 0; } }
		public int ButtonRight { get{ return 0; } }
	}

	public class OSXLayout : InputLayout
	{
		public int ButtonA { get{ return 16; } }
		public int ButtonB { get{ return 17; } }
		public int ButtonX { get{ return 18; } }
		public int ButtonY { get{ return 19; } }

		public int ButtonL { get{ return 13; } }
		public int ButtonR { get{ return 14; } }

		public int ButtonBack { get{ return 10; } }
		public int ButtonStart { get{ return 9; } }

		public int ButtonStickL { get{ return 11; } }
		public int ButtonStickR { get{ return 12; } }

		public int AxisLeftX { get{ return 0; } }
		public int AxisLeftY { get{ return 1; } }

		public int AxisTriggers { get{ return -1; } }

		public int AxisRightX { get{ return 3; } }
		public int AxisRightY { get{ return 4; } }

		public int PadX { get{ return -1; } }
		public int PadY { get{ return -1; } }

		public int AxisTriggerLeft { get{ return 5; } }
		public int AxisTriggerRight { get{ return 6; } }

		public int ButtonUp { get{ return 5; } }
		public int ButtonDown { get{ return 6; } }
		public int ButtonLeft { get{ return 7; } }
		public int ButtonRight { get{ return 8; } }

	}
}