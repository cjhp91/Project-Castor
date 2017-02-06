using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Castor;

namespace CastorObsolete
{
	public class CastorInputManager : MonoBehaviour
	{
		public static CastorInputManager Instance;
		public InputLayout CurrentLayout = new XBox360Layout();
		public IInputHandler InputHandler;

		private int _gamepadCount = 0;
		private Dictionary<int,string> _buttonDatabase = new Dictionary<int, string>();
		private Dictionary<int,string> _axisDatabase = new Dictionary<int, string>();
		private const int MAX_PLAYER_COUNT = 4;

		private void Start()
		{
			Instance = this;
			
			#if UNITY_STANDALONE_OSX || UNITY_EDITOR_OSX
			CurrentLayout = new OSXLayout();
			#else
			CurrentLayout = new XBox360Layout();
			#endif

			_gamepadCount = Input.GetJoystickNames ().Length;
			BuildInputDatabase ();
		}
		private void BuildInputDatabase()
		{
			if (_buttonDatabase.Count < 1) {
				for (int i = 0; i < MAX_PLAYER_COUNT; i++) {
					for (int j = 0; j < Constants.Input.COUNT_BUTTON; j++) {
						_buttonDatabase.Add (i * Constants.Input.COUNT_BUTTON + j, "joystick " + (i+1) + " button " + j);
					}
				}
			}
			if (_axisDatabase.Count < 1) {
				for (int i = 0; i < MAX_PLAYER_COUNT; i++) {
					for (int j = 1; j <= Constants.Input.COUNT_AXIS; j++) {
						_axisDatabase.Add (i * Constants.Input.COUNT_AXIS + j, "joystick " + (i+1) + " axis " + j);
					}
				}
			}
		}

		public void AssignInputHandler(IInputHandler handler) {
			InputHandler = handler;
		}

		private void Update()
		{
			if (InputHandler != null) {
				int playerCount = Input.GetJoystickNames ().Length;
				if (playerCount != _gamepadCount) {
					_gamepadCount = playerCount;
				}
				for (int i = 1; i <= _gamepadCount; i++) {
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonA)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_A);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonB)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_B);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonX)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_X);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonY)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_Y);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonL)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_L);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonR)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_R);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonBack)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_BACK);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonStart)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_START);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonUp)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_UP);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonDown)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_DOWN);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonLeft)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_LEFT);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonRight)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_RIGHT);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonStickL)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_STICK_L);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonStickR)))
						InputHandler.ReceiveButtonDownInput (i,Constants.Input.BUTTON_STICK_R);

					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonA)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_A);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonB)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_B);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonX)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_X);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonY)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_Y);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonL)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_L);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonR)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_R);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonBack)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_BACK);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonStart)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_START);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonUp)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_UP);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonDown)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_DOWN);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonLeft)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_LEFT);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonRight)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_RIGHT);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonStickL)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_STICK_L);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonStickR)))
						InputHandler.ReceiveButtonUpInput (i,Constants.Input.BUTTON_STICK_R);

					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonA)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_A);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonB)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_B);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonX)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_X);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonY)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_Y);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonL)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_L);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonR)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_R);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonBack)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_BACK);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonStart)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_START);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonUp)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_UP);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonDown)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_DOWN);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonLeft)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_LEFT);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonRight)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_RIGHT);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonStickL)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_STICK_L);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonStickR)))
						InputHandler.ReceiveButtonHoldInput (i,Constants.Input.BUTTON_STICK_R);

					float axis = 0.0f;
					//1
					if (CurrentLayout.AxisLeftX != -1) {
						axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisLeftX));
						InputHandler.ReceiveAxisInput (i,Constants.Input.AXIS_LEFT_X,axis);
					}
					//2
					if (CurrentLayout.AxisLeftY != -1) {
						axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisLeftY));
						InputHandler.ReceiveAxisInput (i, Constants.Input.AXIS_LEFT_Y, axis);
					}
					//3
					if (CurrentLayout.AxisTriggers != -1) {
						axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisTriggers));
						InputHandler.ReceiveAxisInput (i, Constants.Input.AXIS_TRIGGER, axis);
					}
					//4
					if (CurrentLayout.AxisRightX != -1) {
						axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisRightX));
						InputHandler.ReceiveAxisInput (i, Constants.Input.AXIS_RIGHT_X, axis);
					}
					//5
					if (CurrentLayout.AxisRightY != -1) {
						axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisRightY));
						InputHandler.ReceiveAxisInput (i, Constants.Input.AXIS_RIGHT_Y, axis);
					}
					//6
					if (CurrentLayout.AxisTriggerLeft != -1) {
						axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisTriggerLeft));
						InputHandler.ReceiveAxisInput (i, Constants.Input.AXIS_TRIGGER_LEFT, axis);
					}
					//7
					if (CurrentLayout.AxisTriggerRight != -1) {
						axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisTriggerRight));
						InputHandler.ReceiveAxisInput (i, Constants.Input.AXIS_TRIGGER_RIGHT, axis);
					}
					//8
					if (CurrentLayout.PadX != -1) {
						axis = Input.GetAxis (InputAxis (i, CurrentLayout.PadX));
						InputHandler.ReceiveAxisInput (i, Constants.Input.PAD_X, axis);
					}
					//9
					if (CurrentLayout.PadY != -1) {
						axis = Input.GetAxis (InputAxis (i, CurrentLayout.PadY));
						InputHandler.ReceiveAxisInput (i, Constants.Input.PAD_Y, axis);
					}
				}
			}
				
		}

		private string InputButton(int player, int button)
		{
			int index = (player - 1) * Constants.Input.COUNT_BUTTON + button;
			if (_buttonDatabase.ContainsKey (index)) {
				return _buttonDatabase[index];
			}
			return "joystick " + player + " button " + button;
		}

		private string InputAxis(int player, int axis)
		{
			int index = (player - 1) * Constants.Input.COUNT_BUTTON + axis;
			if (_axisDatabase.ContainsKey (index)) {
				return _axisDatabase[index];
			}
			return "joystick " + player + " axis " + axis;
		}
	}
}
	