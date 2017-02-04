using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Castor
{
	public class GameModeManager : MonoBehaviour
	{
		#region MEMBERS
		public static GameModeManager Instance;

		public bool Debug = false;

		public GameModeTypes GameMode = GameModeTypes.MAIN_MENU;
		private IGameMode _mode;
		private GameModeData _modeData;

		private GameObject _uiContainer;
		private UIManager _uiManager;
		private CameraController _camera;
		#endregion

		#region ENUM
		public enum GameModeTypes
		{
			MAIN_MENU,
			BATTLE
		}
		#endregion

		#region MONO
		private void Start()
		{
			if (Instance != null) {
				Destroy (Instance.gameObject);
			}
			Instance = this;
			DontDestroyOnLoad (this.gameObject);

			_uiContainer = transform.FindChild ("canvas").gameObject;
			_uiManager = _uiContainer.GetComponent<UIManager> ();
			_uiManager.Init ();

			_camera = this.gameObject.GetComponentInChildren<CameraController> ();
			_camera.Init ();

			SwitchModes (GameMode,new GameModeData());
		}
		#endregion

		#region PUBLIC METHODS
		public void SwitchModes(GameModeTypes gameMode, GameModeData data)
		{
			GameMode = gameMode;
			_modeData = data;
			StartCoroutine (SwitchModeRoutine ());
		}
		#endregion

		#region PUBLIC METHODS
		#endregion


		#region PRIVATE METHODS
		private IEnumerator SwitchModeRoutine()
		{
			while (_mode != null) {
				_mode.Clean ();
				_mode = null;
				yield return null;
			}

			switch (GameMode) {
			case GameModeTypes.MAIN_MENU:
				GameObject mmgo = new GameObject ("main_menu_manager");
				_mode = mmgo.AddComponent<MainMenuManager> ();
				break;
			case GameModeTypes.BATTLE:
				GameObject bgo = new GameObject ("battle_manager");
				_mode = bgo.AddComponent<BattleManager> ();
				break;
			}

			_uiManager.LoadMode (GameMode, 
				delegate() { // faded out
					_mode.Init (_modeData);
					_uiManager.SendLoadComplete();
				},
				delegate() { // complete
					_mode.Ready();
				}
			);

			yield break;
		}

		#endregion
	}
}
	