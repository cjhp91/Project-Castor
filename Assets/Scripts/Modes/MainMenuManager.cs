using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Castor
{
	public class MainMenuManager : MonoBehaviour, IGameMode
	{
		#region PUBLIC MEMBERS
		#endregion

		#region PRIVATE MEMBERS
		#endregion

		#region INTERFACE
		public void Init(GameModeData modeData)
		{
			if (modeData != null && modeData.GetType () == typeof(MainMenuModeData)) {
				MainMenuModeData mainMenuData = (MainMenuModeData)modeData;
			} else {
				Logger.Error ("Invalid Main Menu Mode Data", "MODE");
			}
		}
		public void Ready()
		{
		}
		public void Clean()
		{
			Destroy (this.gameObject);
		}
		#endregion

		#region PUBLIC METHODS
		#endregion

		#region PRIVATE METHODS
		#endregion
	}
}
	