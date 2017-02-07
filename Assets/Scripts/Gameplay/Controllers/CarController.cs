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
		public float Acceleration = 7.0f;
		public float MaxSpeed = 3.0f;
		public float SpeedDecay = 0.1f;
		public float Handling = 5.0f;

		#endregion

		#region PRIVATE MEMBERS
		private float _speed;
		private float _steering;
		private float _throttle;
		private float _brake;
		private Vector3 _movementVector;

		private const int _turnFactor = 30;
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
			if (_throttle > 0) {
				if (_speed < MaxSpeed) {
					_speed += Acceleration * Time.deltaTime * _throttle;
				} else {
					_speed = MaxSpeed;
				}
			} else {
				if(_speed > 0)
					_speed -= SpeedDecay * (1 + _brake);
			}
			if (_speed > 0) {
				this.transform.eulerAngles -= new Vector3 (0, 0, _turnFactor * _steering * Handling * _speed * Time.deltaTime);
				float theta = this.transform.eulerAngles.z * Mathf.Deg2Rad;
				Vector3 dir = new Vector3 (-Mathf.Sin (theta), Mathf.Cos (theta), 0);
				this.transform.position += dir * _speed * Time.deltaTime;
			}

		}
		#endregion

		#region INPUT
		public void ReceiveDevice(InputDevice device)
		{
			_throttle = device.Action1 ? 1 : 0;
			_brake = device.Action2 ? 1 : 0;

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
				this.transform.position = Vector3.zero;
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
	