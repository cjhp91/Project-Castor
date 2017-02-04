public class InputLayout
{
	public readonly int AxisLeftX = 1;
	public readonly int AxisLeftY = 2;

	public readonly int ButtonA = 0;
	public readonly int ButtonB = 1;
	public readonly int ButtonX = 2;
	public readonly int ButtonY = 3;

	public readonly int ButtonShoulderL = 4;
	public readonly int ButtonShoulderR = 5;

	public readonly int ButtonBack = 6;
	public readonly int ButtonStart = 7;

	public readonly int ButtonJoystickL = 8;
	public readonly int ButtonJoystickR = 9;

	public readonly int AxisRightX = 4;
	public readonly int AxisRightY = 5;

	public readonly int PadX = 6;
	public readonly int PadY = 7;

	public readonly int AxisTriggerLeft = 9;
	public readonly int AxisTriggerRight = 10;

	public readonly int ButtonPadUp = 11;
	public readonly int ButtonPadDown = 12;
	public readonly int ButtonPadLeft = 13;
	public readonly int ButtonPadRight = 14;
}

public class WindowsLayout : InputLayout
{
	public readonly new int ButtonA = 0;
	public readonly new int ButtonB = 1;
	public readonly new int ButtonX = 2;
	public readonly new int ButtonY = 3;

	public readonly new int ButtonShoulderL = 4;
	public readonly new int ButtonShoulderR = 5;

	public readonly new int ButtonBack = 6;
	public readonly new int ButtonStart = 7;

	public readonly new int ButtonJoystickL = 8;
	public readonly new int ButtonJoystickR = 9;

	public readonly new int AxisRightX = 4;
	public readonly new int AxisRightY = 5;

	public readonly new int PadX = 6;
	public readonly new int PadY = 7;

	public readonly new int AxisTriggerLeft = 9;
	public readonly new int AxisTriggerRight = 10;
}

public class OSXLayout : InputLayout
{
	public readonly new int ButtonA = 16;
	public readonly new int ButtonB = 17;
	public readonly new int ButtonX = 18;
	public readonly new int ButtonY = 19;

	public readonly new int ButtonShoulderL = 13;
	public readonly new int ButtonShoulderR = 14;

	public readonly new int ButtonBack = 10;
	public readonly new int ButtonStart = 9;
	public readonly new int ButtonJoystickL = 11;
	public readonly new int ButtonJoystickR = 12;

	public readonly new int ButtonPadUp = 5;
	public readonly new int ButtonPadDown = 6;
	public readonly new int ButtonPadLeft = 7;
	public readonly new int ButtonPadRight = 8;

	public readonly new int AxisRightX = 3;
	public readonly new int AxisRightY = 4;

	public readonly new int AxisTriggerLeft = 5;
	public readonly new int PadYTriggerRight = 6;
}