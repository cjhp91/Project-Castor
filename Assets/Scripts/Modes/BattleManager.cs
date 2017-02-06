using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

namespace Castor
{
	public class BattleManager : MonoBehaviour, IGameMode
	{
		#region MEMBERS
		public static BattleManager Instance;
		private Dictionary<int,CarController> _carList = new Dictionary<int, CarController>();
		private Dictionary<InputDevice,int> _deviceBinding = new Dictionary<InputDevice,int> ();


		private GameObject _stageObject;
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

//			if (InputManager.Instance != null) {
//				InputManager.Instance.AssignInputHandler (this);
//			}
//
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

		#region UPDATE
		private void Update()
		{
			for (int i = 0; i < InputManager.Devices.Count; i++) {
				InputDevice device = InputManager.Devices [i];
				if (_deviceBinding.ContainsKey (device)) {
					int playerId = _deviceBinding [device];
					if (_carList.ContainsKey (playerId)) {
						_carList [playerId].ReceiveDevice (device);
					} else {
						Logger.Error ("Binding Lost: " + device.Name);
					}
				} else {
					if (device.Action1) {
						CreateCar (device);
					}
				}
			}
		}
		#endregion

		#region CAR MANAGEMENT
		private void CreateCar(InputDevice device)
		{
			int playerID = _deviceBinding.Count + 1;


			_deviceBinding.Add (device, playerID);

			string prefab = Constants.Prefabs.PREFAB_CAR_BLUE;
			if (playerID % 2 == 0)
				prefab = Constants.Prefabs.PREFAB_CAR_ORANGE;
			
			GameObject newCarGo = Instantiate(Resources.Load (prefab)) as GameObject;
			newCarGo.transform.parent = this.transform;
			CarController newCar = newCarGo.AddComponent<CarController> ();
			newCar.Init (playerID);
			_carList.Add (playerID,newCar);
			Logger.Highlight ("Player " + playerID + " Created; Bound to " + device.Name, "CAR MANAGER");
		}
		#endregion
	}
}
