using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CastorEditor
{
	public static class DGUI
	{
		private static GUISkin _skin;
		private static GUISkin _gameSkin;
		public static void Draw(System.Action draw, int fontSize = 16)
		{
			GUI.skin.button.margin = new RectOffset (0,4,0,4);
			GUI.skin.textField.margin = new RectOffset (0,4,0,4);
			GUI.skin.label.margin = new RectOffset (0,4,0,4);

			GUI.skin.label.alignment = TextAnchor.MiddleCenter;
			GUI.skin.textField.alignment = TextAnchor.MiddleCenter;

			int bfs = GUI.skin.button.fontSize;
			int tfs = GUI.skin.textField.fontSize;
			int lfs = GUI.skin.label.fontSize;

			GUI.skin.button.fontSize = (int)(Screen.height * 0.002f * fontSize);
			GUI.skin.textField.fontSize = (int)(Screen.height * 0.002f * fontSize);
			GUI.skin.label.fontSize = (int)(Screen.height * 0.002f * fontSize);

			GUI.skin.horizontalSlider.fixedHeight = Screen.height * 0.002f * fontSize;
			GUI.skin.verticalScrollbar.fixedWidth = Screen.height * 0.002f * fontSize;

			GUI.skin.horizontalSliderThumb.fixedHeight = Screen.height * 0.002f * fontSize;
			GUI.skin.verticalSliderThumb.fixedWidth = Screen.height * 0.002f * fontSize;

			draw ();

			GUI.skin.label.alignment = TextAnchor.MiddleLeft;
			GUI.skin.textField.alignment = TextAnchor.MiddleLeft;

			GUI.skin.button.fontSize = bfs;
			GUI.skin.textField.fontSize = tfs;
			GUI.skin.label.fontSize = lfs;
		}

		/// <summary>
		/// Begin Area; 0 - 100.
		/// </summary>
		public static void Area(float xpos, float ypos, float xsize, float ysize)
		{
			GUILayout.BeginArea (new Rect(xpos/100 * Screen.width,ypos/100 * Screen.height, xsize/100 * Screen.width, ysize/100 * Screen.height));
			GUI.enabled = true;
		}
		/// <summary>
		/// EndArea
		/// </summary>
		public static void XArea()
		{
			GUI.color = Color.white;
			GUI.backgroundColor = Color.white;
			GUILayout.EndArea ();
		}

		/// <summary>
		/// Begin Horizontal
		/// </summary>
		public static void Hori() { GUILayout.BeginHorizontal (); }
		/// <summary>
		/// End Horizontal
		/// </summary>
		public static void XHori() { GUILayout.EndHorizontal (); }
		/// <summary>
		/// Begin Vertical
		/// </summary>
		public static void Vert() { GUILayout.BeginVertical (); }
		/// <summary>
		/// End Vertical
		/// </summary>
		public static void XVert() { GUILayout.EndVertical (); }
		/// <summary>
		/// Begin Indent
		/// </summary>
		public static void Indent() { GUILayout.BeginHorizontal (); Label("",25,25); GUILayout.BeginVertical(); }
		/// <summary>
		/// End Indent
		/// </summary>
		public static void XIndent() { GUILayout.EndVertical(); GUILayout.EndHorizontal (); }
		/// <summary>
		/// Begin Center
		/// </summary>
		public static void Center()
		{
			GUILayout.BeginHorizontal ();
			GUILayout.FlexibleSpace ();
			GUILayout.BeginVertical ();
			GUILayout.FlexibleSpace ();
		}
		/// <summary>
		/// End Center
		/// </summary>
		public static void XCenter()
		{
			GUILayout.FlexibleSpace ();
			GUILayout.EndVertical ();
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();
		}


		public static bool Button(string s, float xsize, float ysize)
		{
			return GUILayout.Button(s,GUILayout.Width(xsize/100 * Screen.width - 4),GUILayout.Height(ysize/100  * Screen.height - 4));
		}
		public static bool Button(int i, float xsize, float ysize)
		{
			return GUILayout.Button(i.ToString(),GUILayout.Width(xsize/100 * Screen.width - 4),GUILayout.Height(ysize/100 * Screen.height - 4));
		}
		public static bool Button(float f, float xsize, float ysize)
		{
			return GUILayout.Button(f.ToString(),GUILayout.Width(xsize/100 * Screen.width - 4),GUILayout.Height(ysize/100 * Screen.height - 4));
		}

		public static void Label(string s, float xsize, float ysize)
		{
			GUILayout.Label(s,GUILayout.Width(xsize/100 * Screen.width - 4),GUILayout.Height(ysize/100 * Screen.height - 4));
		}
		public static void Label(int i, float xsize, float ysize)
		{
			GUILayout.Label(i.ToString(),GUILayout.Width(xsize/100 * Screen.width - 4),GUILayout.Height(ysize/100 * Screen.height - 4));
		}
		public static void Label(float f, float xsize, float ysize)
		{
			GUILayout.Label(f.ToString(),GUILayout.Width(xsize/100 * Screen.width - 4),GUILayout.Height(ysize/100 * Screen.height - 4));
		}

		public static int IntField(int i, float xsize, float ysize)
		{
			string s = GUILayout.TextField(i.ToString(),GUILayout.Width(xsize/100 * Screen.width - 4),GUILayout.Height(ysize/100 * Screen.height - 4));
			int output = 0;
			int.TryParse(s,out output);
			return output;
		}
		public static string StringField(string s, float xsize, float ysize)
		{
			return GUILayout.TextField(s,GUILayout.Width(xsize/100 * Screen.width - 4),GUILayout.Height(ysize/100 * Screen.height - 4));
		}

		public static Vector2 Scroll(Vector2 scroll, float xsize, float ysize)
		{
			return GUILayout.BeginScrollView(scroll,GUILayout.Width(xsize/100 * Screen.width - 4),GUILayout.Height(ysize/100 * Screen.height - 4));
		}
		public static void XScroll()
		{
			GUILayout.EndScrollView ();
		}
	}
	public static class EGUI
	{
		private static GUISkin _skin;
		private static GUISkin _gameSkin;

		public static void Title(string title)
		{
			GUILayout.Label(title,GUILayout.ExpandWidth(true),GUILayout.Height(20));
		}
		public static bool Title(string title, bool collapsed)
		{
			Hori ();
			GUILayout.Label(title,GUILayout.ExpandWidth(true),GUILayout.Height(20));
			if (Button (collapsed ? "+" : "-", 20)) {
				collapsed = !collapsed;
			}
			XHori ();
			return collapsed;
		}

		/// <summary>
		/// Begin Horizontal
		/// </summary>
		public static void Hori() { GUILayout.BeginHorizontal (); }
		/// <summary>
		/// End Horizontal
		/// </summary>
		public static void XHori() { GUILayout.EndHorizontal (); }
		/// <summary>
		/// Begin Vertical
		/// </summary>
		public static void Vert() { GUILayout.BeginVertical (); }
		/// <summary>
		/// End Vertical
		/// </summary>
		public static void XVert() { GUILayout.EndVertical (); }
		/// <summary>
		/// Begin Indent
		/// </summary>
		public static void Indent() { GUILayout.BeginHorizontal (); Label("",25); GUILayout.BeginVertical(); }
		/// <summary>
		/// End Indent
		/// </summary>
		public static void XIndent() { GUILayout.EndVertical(); GUILayout.EndHorizontal (); }

		public static bool Button(string s)
		{
			return GUILayout.Button(s,GUILayout.ExpandWidth(true),GUILayout.Height(20));
		}
		public static bool Button(string s, float xsize)
		{
			return GUILayout.Button(s,GUILayout.Width(xsize),GUILayout.Height(20));
		}
		public static bool Button(int i, float xsize)
		{
			return GUILayout.Button(i.ToString(),GUILayout.Width(xsize),GUILayout.Height(20));
		}
		public static bool Button(float f, float xsize)
		{
			return GUILayout.Button(f.ToString(),GUILayout.Width(xsize),GUILayout.Height(20));
		}
		public static void Label(string s)
		{
			GUILayout.Label(s,GUILayout.Width(100),GUILayout.Height(20));
		}
		public static void Label(string s, float xsize)
		{
			GUILayout.Label(s,GUILayout.Width(xsize),GUILayout.Height(20));
		}
		public static void Label(int i, float xsize)
		{
			GUILayout.Label(i.ToString(),GUILayout.Width(xsize),GUILayout.Height(20));
		}
		public static void Label(float f, float xsize)
		{
			GUILayout.Label(f.ToString(),GUILayout.Width(xsize),GUILayout.Height(20));
		}

		public static int IntField(int i, float xsize)
		{
			string s = GUILayout.TextField(i.ToString(),GUILayout.Width(xsize),GUILayout.Height(20));
			int output = 0;
			int.TryParse(s,out output);
			return output;
		}
		public static string StringField(string s, float xsize)
		{
			return GUILayout.TextField(s,GUILayout.Width(xsize),GUILayout.Height(20));
		}

		public static Vector2 Scroll(Vector2 scroll, float xsize)
		{
			return GUILayout.BeginScrollView(scroll,GUILayout.Width(xsize),GUILayout.Height(20));
		}
		public static void XScroll()
		{
			GUILayout.EndScrollView ();
		}
	}
}
	