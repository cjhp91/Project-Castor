using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Castor
{
	public class BattleManager : MonoBehaviour, IGameMode
	{
		#region MEMBERS
		public static BattleManager Instance;
		private Dictionary<int,CarController> _carsList = new Dictionary<int, CarController>();


		private GameObject _stageObject;
		private const int AXIS_DEAD_ZONE = 100;
		#endregion

		#region INITIALIZATION
		private void Start()
		{
			Instance = this;
		}
		public void Init(GameModeData modeData)
		{
			if (modeData != null && modeData.GetType () == typeof(BattleModeData)) {
				BattleModeData mainMenuData = (BattleModeData)modeData;
			} else {
				Logger.Error ("Invalid Battle Mode Data", "MODE");
			}

			_stageObject = Instantiate (Resources.Load (Constants.Prefabs.PREFAB_STAGE_TEST)) as GameObject;
			_stageObject.transform.parent = this.transform;
			_stageObject.transform.localPosition = Vector3.zero;
			_stageObject.SetActive(false);

			CameraController.Instance.ShowFader ();
		}
		public void Ready()
		{
			CameraController.Instance.FadeIn (2.0f);
			_stageObject.SetActive(true);
		}
		public void Clean()
		{
			Destroy (this.gameObject);
		}
		#endregion

		#region CAR MANAGEMENT
		private void CreateCar(int player)
		{
			CarController newCar = new CarController ();
			newCar.Init (player);
			_carsList.Add (player,newCar);
			Logger.Highlight ("Player " + player + " Created", "CAR MANAGER");
		}
		#endregion

		#region INPUT
		private void ReceiveButtonDownInput(int player, int button)
		{
			if (_carsList.ContainsKey (player))
				_carsList [player].ReceiveButtonDownInput (button);
			else if (button == 7) // start
				CreateCar(player);
		}
		private void ReceiveButtonHoldInput(int player, int button)
		{
			if (_carsList.ContainsKey (player))
				_carsList [player].ReceiveButtonHoldInput (button);
		}

		private void ReceiveButtonUpInput(int player, int button)
		{
			if (_carsList.ContainsKey (player))
				_carsList [player].ReceiveButtonUpInput (button);
		}

		private void ReceiveAxisInput(int player, int axis, int amount)
		{
			if (_carsList.ContainsKey (player))
				_carsList [player].ReceiveAxisInput (axis,amount);
		}
		#endregion
	}
}
