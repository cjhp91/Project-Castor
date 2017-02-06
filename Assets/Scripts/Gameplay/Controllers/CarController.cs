using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

namespace Castor
{
	public class CarController : MonoBehaviour
	{
		#region PUBLIC MEMBERS
		public int CarID;
		public float Acceleration = 2.0f;
		public float MaxSpeed = 4.0f;
		public float SpeedDecay = 0.1f;

		public bool Accelerating = false;
		public bool Braking = false;
		#endregion

		#region PRIVATE MEMBERS
		private float _speed;
		private float _steering;
		private float _throttle;
		private Vector3 _movementVector;
		#endregion

		#region PUBLIC METHODS
		public void Init(int playerID)
		{
			CarID = playerID;
		}
		public void Clean()
		{

		}
		#endregion

		#region UPDATE
		private void Update()
		{
			this.transform.eulerAngles -= new Vector3(0,0,_steering);
		}
		#endregion

		#region INPUT
		public void ReceiveDevice(InputDevice device)
		{
			if (device.RightTrigger.WasPressed) {
			}
			if (device.RightTrigger) {
			}
			if (device.RightTrigger.WasReleased) {
			}

			if (device.LeftTrigger.WasPressed) {
			}
			if (device.LeftTrigger) {
			}
			if (device.LeftTrigger.WasReleased) {
			}

			if (device.Action1.WasPressed) {
			}
			if (device.Action1.WasReleased) {
			}
			if (device.Action2.WasPressed) {
			}
			if (device.Action2.WasReleased) {
			}
			if (device.Action3.WasPressed) {
			}
			if (device.Action3.WasReleased) {
			}
			if (device.Action4.WasPressed) {
			}
			if (device.Action4.WasReleased) {
			}
//			_movementVector = new Vector3 (device.LeftStickX.RawValue, device.LeftStickY.RawValue, 0);
			_steering = device.LeftStickX;
		}
		#endregion

		#region PRIVATE METHODS
		#endregion
	}
}
	