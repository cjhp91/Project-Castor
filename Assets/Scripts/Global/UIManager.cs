using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Castor
{
	public class UIManager : MonoBehaviour
	{
		#region PUBLIC MEMBERS
		#endregion

		#region PRIVATE MEMBERS
		private bool _loading = false;

		private GameObject _current;

		private GameObject _loadingContainer;
		private GameObject _faderContainer;

		private CanvasGroup _faderGroup;

		private const float FADER_SPEED = 0.025f;
		#endregion

		#region PUBLIC METHODS
		public void Init()
		{
			_faderContainer = transform.FindChild ("fader").gameObject;
			_faderContainer.SetActive (false);
			_faderGroup = _faderContainer.GetComponent<CanvasGroup> ();
			_faderGroup.alpha = 0.0f;

			_loadingContainer = transform.FindChild ("loading_text").gameObject;
			_loadingContainer.SetActive (false);
		}
		public void Clean()
		{
			Destroy (_current);
		}
		public void LoadMode(GameModeManager.GameModeTypes modeType, System.Action onFadeOut, System.Action onComplete, bool fade = true)
		{
			Clean ();
			_loading = true;
			StartCoroutine (LoadRoutine (modeType, onFadeOut, onComplete));
		}
		public void SendLoadComplete()
		{
			_loading = false;
		}
		#endregion

		#region PRIVATE METHODS
		private IEnumerator LoadRoutine(GameModeManager.GameModeTypes modeType, System.Action onFadeOut, System.Action onComplete, bool fade = true)
		{
			if (fade) {
				_faderContainer.SetActive (true);
				_loadingContainer.SetActive (true);
				while (_faderGroup.alpha < 1.0f) {
					_faderGroup.alpha += 0.05f;
					yield return new WaitForSeconds (FADER_SPEED);
					if (_faderGroup.alpha >= 1.0f) {
						_faderGroup.alpha = 1.0f;
						break;
					}
				}
			}
				
			switch (modeType) {
			case GameModeManager.GameModeTypes.MAIN_MENU:
				break;
			case GameModeManager.GameModeTypes.BATTLE:
				break;
			}
			if (_current != null) {
				_current.transform.SetParent(this.transform);
				_current.GetComponent<RectTransform> ().anchoredPosition = Vector3.zero;
				
				_current.transform.localScale = new Vector3 (1, 1, 1);
				_current.transform.SetAsFirstSibling ();
			}

			if (fade) {
				Logger.Highlight ("Fade Out Complete", "CORE");
			}
			onFadeOut ();

			while (_loading) {
				yield return null;
			}

			if (fade) {
				while (_faderGroup.alpha > 0.0f) {
					_faderGroup.alpha -= 0.05f;
					yield return new WaitForSeconds (FADER_SPEED);
					if (_faderGroup.alpha <= 0.0f) {
						_faderGroup.alpha = 0.0f;
						break;
					}
				}

				_loadingContainer.SetActive (false);
				_faderContainer.SetActive (false);
			}
				
			Logger.Highlight ("Load Complete", "CORE");

			onComplete ();
			yield return null;
		}
		#endregion
	}
}
	