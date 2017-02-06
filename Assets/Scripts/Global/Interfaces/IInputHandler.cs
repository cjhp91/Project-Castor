using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CastorObsolete
{
	public interface IInputHandler
	{
		void ReceiveButtonDownInput (int player, int button);
		void ReceiveButtonHoldInput (int player, int button);
		void ReceiveButtonUpInput (int player, int button);
		void ReceiveAxisInput (int player, int axis, float amount);
	}
}