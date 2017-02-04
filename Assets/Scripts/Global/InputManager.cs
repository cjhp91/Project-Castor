using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Castor
{
	public class InputManager : MonoBehaviour
	{
		public static InputManager Instance;
		private IInputHandler InputHandler;
		private InputLayout CurrentLayout = new WindowsLayout();

		private int _gamepadCount = 0;

		private void Start()
		{
			Instance = this;
			
			#if UNITY_STANDALONE_OSX || UNITY_EDITOR_OSX
			CurrentLayout = new OSXLayout();
			#else
			CurrentLayout = new WindowsLayout();
			#endif

			_gamepadCount = Input.GetJoystickNames ().Length;
		}
		private void BuildInputDatabase()
		{
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
						InputHandler.ReceiveButtonDownInput (i,0);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonB)))
						InputHandler.ReceiveButtonDownInput (i,1);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonX)))
						InputHandler.ReceiveButtonDownInput (i,2);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonY)))
						InputHandler.ReceiveButtonDownInput (i,3);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonShoulderL)))
						InputHandler.ReceiveButtonDownInput (i,4);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonShoulderR)))
						InputHandler.ReceiveButtonDownInput (i,5);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonBack)))
						InputHandler.ReceiveButtonDownInput (i,6);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonStart)))
						InputHandler.ReceiveButtonDownInput (i,7);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonPadUp)))
						InputHandler.ReceiveButtonDownInput (i,8);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonPadDown)))
						InputHandler.ReceiveButtonDownInput (i,9);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonPadLeft)))
						InputHandler.ReceiveButtonDownInput (i,10);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonPadRight)))
						InputHandler.ReceiveButtonDownInput (i,11);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonJoystickL)))
						InputHandler.ReceiveButtonDownInput (i,12);
					if (Input.GetKeyDown (InputButton(i,CurrentLayout.ButtonJoystickR)))
						InputHandler.ReceiveButtonDownInput (i,13);

					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonA)))
						InputHandler.ReceiveButtonUpInput (i,0);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonB)))
						InputHandler.ReceiveButtonUpInput (i,1);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonX)))
						InputHandler.ReceiveButtonUpInput (i,2);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonY)))
						InputHandler.ReceiveButtonUpInput (i,3);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonShoulderL)))
						InputHandler.ReceiveButtonUpInput (i,4);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonShoulderR)))
						InputHandler.ReceiveButtonUpInput (i,5);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonBack)))
						InputHandler.ReceiveButtonUpInput (i,6);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonStart)))
						InputHandler.ReceiveButtonUpInput (i,7);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonPadUp)))
						InputHandler.ReceiveButtonUpInput (i,8);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonPadDown)))
						InputHandler.ReceiveButtonUpInput (i,9);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonPadLeft)))
						InputHandler.ReceiveButtonUpInput (i,10);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonPadRight)))
						InputHandler.ReceiveButtonUpInput (i,11);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonJoystickL)))
						InputHandler.ReceiveButtonUpInput (i,12);
					if (Input.GetKeyUp (InputButton(i,CurrentLayout.ButtonJoystickR)))
						InputHandler.ReceiveButtonUpInput (i,13);

					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonA)))
						InputHandler.ReceiveButtonHoldInput (i,0);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonB)))
						InputHandler.ReceiveButtonHoldInput (i,1);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonX)))
						InputHandler.ReceiveButtonHoldInput (i,2);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonY)))
						InputHandler.ReceiveButtonHoldInput (i,3);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonShoulderL)))
						InputHandler.ReceiveButtonHoldInput (i,4);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonShoulderR)))
						InputHandler.ReceiveButtonHoldInput (i,5);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonBack)))
						InputHandler.ReceiveButtonHoldInput (i,6);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonStart)))
						InputHandler.ReceiveButtonHoldInput (i,7);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonPadUp)))
						InputHandler.ReceiveButtonHoldInput (i,8);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonPadDown)))
						InputHandler.ReceiveButtonHoldInput (i,9);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonPadLeft)))
						InputHandler.ReceiveButtonHoldInput (i,10);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonPadRight)))
						InputHandler.ReceiveButtonHoldInput (i,11);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonJoystickL)))
						InputHandler.ReceiveButtonHoldInput (i,12);
					if (Input.GetKey (InputButton(i,CurrentLayout.ButtonJoystickR)))
						InputHandler.ReceiveButtonHoldInput (i,13);

					float axis = 0.0f;
					axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisLeftX));
					InputHandler.ReceiveAxisInput (i,0,(int)axis * 10000);
					axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisLeftY));
					InputHandler.ReceiveAxisInput (i,1,(int)axis * 10000);
					axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisRightX));
					InputHandler.ReceiveAxisInput (i,2,(int)axis * 10000);
					axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisRightY));
					InputHandler.ReceiveAxisInput (i,3,(int)axis * 10000);
					axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisTriggerLeft));
					InputHandler.ReceiveAxisInput (i,4,(int)axis * 10000);
					axis = Input.GetAxis (InputAxis (i, CurrentLayout.AxisTriggerRight));
					InputHandler.ReceiveAxisInput (i,5,(int)axis * 10000);
					axis = Input.GetAxis (InputAxis (i, CurrentLayout.PadX));
					InputHandler.ReceiveAxisInput (i,6,(int)axis * 10000);
					axis = Input.GetAxis (InputAxis (i, CurrentLayout.PadY));
					InputHandler.ReceiveAxisInput (i,7,(int)axis * 10000);
				}
			}
				
		}

		private static string InputButton(int player, int button)
		{
			return "joystick " + player + " button " + button;
		}

		private static string InputAxis(int player, int axis)
		{
			return "joystick " + player + " axis " + axis;
		}
	}
}
	