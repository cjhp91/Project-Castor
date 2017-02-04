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

		#region INPUT
		public void ReceiveButtonDownInput(int button)
		{
//			Logger.Highlight (CarID + ": " + button, "INPUT");
		}
		public void ReceiveButtonHoldInput(int button)
		{
//			Logger.Error (CarID + ": " + button, "INPUT");
		}
		public void ReceiveButtonUpInput(int button)
		{
//			Logger.Warning (CarID + ": " + button, "INPUT");
		}
		public void ReceiveAxisInput(int axis, int amount)
		{
//			Logger.Caution (CarID + ": " + axis + " - " + amount, "INPUT");
		}
		#endregion

		#region PRIVATE METHODS
		#endregion
	}
}
	