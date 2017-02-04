using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Castor
{
	public class CameraController : MonoBehaviour
	{
		#region PUBLIC MEMBERS
		public static CameraController Instance;

		private SpriteRenderer _renderer;
		private bool _fading;
		#endregion

		#region PRIVATE MEMBERS
		#endregion

		#region INIT
		public void Init()
		{
			Instance = this;
			
			_renderer = gameObject.GetComponentInChildren<SpriteRenderer> ();
			_renderer.color = new Color (1.0f, 1.0f, 1.0f, 0.0f);
			_renderer.enabled = false;
		}
		#endregion

		#region FADER
		public void ShowFader()
		{
			_renderer.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
			_renderer.enabled = true;
		}
		public void HideFader()
		{
			_renderer.color = new Color (1.0f, 1.0f, 1.0f, 0.0f);
			_renderer.enabled = false;
		}
		public void FadeIn(float duration, bool force = false)
		{
			if (!_fading || force) {
				_fading = true;
				StartCoroutine (FadeInRoutine (duration));
			}
		}
		private IEnumerator FadeInRoutine(float duration)
		{
			float stepAmount = duration * 0.01f;

			while (_renderer.color.a > 0.0f) {
				_renderer.color = new Color(1.0f,1.0f,1.0f,_renderer.color.a -stepAmount);
				yield return new WaitForSeconds (0.01f);
				if (_renderer.color.a <= 0.0f) {
					_renderer.color = new Color (1.0f, 1.0f, 1.0f, 0.0f);
					break;
				}
			}

			_renderer.enabled = false;

			Logger.Highlight ("Fade In Complete", "CORE");
			_fading = false;
			yield return null;
		}
		public void FadeOut(float duration, bool force = false)
		{
			if (!_fading || force) {
				_fading = true;
				StartCoroutine (FadeOutRoutine (duration));
			}
		}
		private IEnumerator FadeOutRoutine(float duration)
		{
			float stepAmount = duration * 0.01f;

			_renderer.enabled = true;

			while (_renderer.color.a < 1.0f) {
				_renderer.color = new Color(1.0f,1.0f,1.0f,_renderer.color.a + stepAmount);
				yield return new WaitForSeconds (0.01f);
				if (_renderer.color.a >= 1.0f) {
					_renderer.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
					break;
				}
			}

			Logger.Highlight ("Fade Out Complete", "CORE");
			_fading = false;

			yield return null;
		}
		#endregion

		#region PUBLIC METHODS
		public void SnapTo(Vector3 position)
		{
			this.transform.position = new Vector3 (position.x, position.y, this.transform.position.z);
		}
		public void MoveTo(Vector3 position)
		{
			this.transform.position = new Vector3 (position.x, position.y, this.transform.position.z);
		}
		#endregion

		#region PRIVATE METHODS
		#endregion
	} 
}