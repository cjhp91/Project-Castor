using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DebugVector
{
	public static void SetMargins()
	{
		GUI.skin.button.margin = new RectOffset (2, 2, 2, 2);
		GUI.skin.textArea.margin = new RectOffset (2, 2, 2, 2);
		GUI.skin.textField.margin = new RectOffset (2, 2, 2, 2);
		GUI.skin.label.margin = new RectOffset (2, 2, 2, 2);
	}

	public static float X1 { get { return Screen.width - 4; } }
	public static float X2 { get { return Screen.width / 2 - 4; } }
	public static float X3 { get { return Screen.width / 3 - 4; } }
	public static float X4 { get { return Screen.width / 4 - 4; } }
	public static float X6 { get { return Screen.width / 6 - 4; } }
	public static float X8 { get { return Screen.width / 8 - 4; } }

	public static float Y1 { get { return Screen.height - 4; } }
	public static float Y2 { get { return Screen.height / 2 - 4; } }
	public static float Y3 { get { return Screen.height / 3 - 4; } }
	public static float Y4 { get { return Screen.height / 4 - 4; } }
	public static float Y6 { get { return Screen.height / 6 - 4; } }
	public static float Y8 { get { return Screen.height / 8 - 4; } }
	public static float Y12 { get { return Screen.height / 12 - 4; } }

	public static GUILayoutOption[] Size(int x, int y)
	{
		float sx;
		float sy;
		switch (x) {
		case 1:
			sx = X1;
			break;
		case 2:
			sx = X2;
			break;
		case 3:
			sx = X3;
			break;
		case 6:
			sx = X6;
			break;
		case 8:
			sx = X8;
			break;
		default:
			sx = X4;
			break;
		}
		switch (y) {
		case 1:
			sy = Y1;
			break;
		case 2:
			sy = Y2;
			break;
		case 3:
			sy = Y3;
			break;
		case 6:
			sy = Y6;
			break;
		case 8:
			sy = Y8;
			break;
		case 12:
			sy = Y12;
			break;
		default:
			sy = Y4;
			break;
		}
		return new GUILayoutOption[] { GUILayout.Width(sx),GUILayout.Height(sy) };
	}
}
