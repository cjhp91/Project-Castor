using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Castor
{
	public class BattleManager : MonoBehaviour, IGameMode, IInputHandler
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

			if (InputManager.Instance != null) {
				InputManager.Instance.AssignInputHandler (this);
			}

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
		public void ReceiveButtonDownInput(int player, int button)
		{
			Logger.Highlight (player + ": " + button, "BUTTON DOWN");

			if (_carsList.ContainsKey (player))
				_carsList [player].ReceiveButtonDownInput (button);
			else if (button == 7) // start
				CreateCar(player);
		}
		public void ReceiveButtonHoldInput(int player, int button)
		{
			Logger.Highlight (player + ": " + button, "BUTTON HOLD");

			if (_carsList.ContainsKey (player))
				_carsList [player].ReceiveButtonHoldInput (button);
		}

		public void ReceiveButtonUpInput(int player, int button)
		{
			Logger.Highlight (player + ": " + button, "BUTTON UP");

			if (_carsList.ContainsKey (player))
				_carsList [player].ReceiveButtonUpInput (button);
		}

		public void ReceiveAxisInput(int player, int axis, int amount)
		{
			if (System.Math.Abs(amount) < AXIS_DEAD_ZONE)
				return;
			Logger.Highlight (player + ": " + axis + " - " + amount, "AXIS");

			if (_carsList.ContainsKey (player))
				_carsList [player].ReceiveAxisInput (axis,amount);
		}
		#endregion
	}
}
