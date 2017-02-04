using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Castor
{
	public class CarController : MonoBehaviour
	{
		#region PUBLIC MEMBERS
		public int CarID;
		#endregion

		#region PRIVATE MEMBERS
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
		#endregion

		#region INPUT
		public void ReceiveButtonDownInput(int button)
		{
		}
		public void ReceiveButtonHoldInput(int button)
		{
		}
		public void ReceiveButtonUpInput(int button)
		{
		}
		public void ReceiveAxisInput(int axis, int amount)
		{
		}
		#endregion

		#region PRIVATE METHODS
		#endregion
	}
}
	