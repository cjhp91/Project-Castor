using UnityEngine;

namespace Castor
{
	public static class Logger {
		public static void Log(string s, string category = "DEFAULT")
		{
			Debug.Log (category + "\n" + s);
		}
		public static void Caution(string s, string category = "DEFAULT")
		{
			Debug.Log ("<color=yellow>" + category + "\n" + s + "</color>");
		}
		public static void Warning(string s, string category = "DEFAULT")
		{
			Debug.Log ("<color=orange>" + category + "\n" + s + "</color>");
		}
		public static void Error(string s, string category = "DEFAULT")
		{
			Debug.Log ("<color=red>" + category + "\n" + s + "</color>");
		}
		public static void Highlight(string s, string category = "DEFAULT")
		{
			Debug.Log ("<color=green>" + category + "\n" + s + "</color>");
		}

		public static void Log(float s, string category = "DEFAULT")
		{
			Debug.Log (category + "\n" + s);
		}
		public static void Caution(float s, string category = "DEFAULT")
		{
			Debug.Log ("<color=yellow>" + category + "\n" + s + "</color>");
		}
		public static void Warning(float s, string category = "DEFAULT")
		{
			Debug.Log ("<color=orange>" + category + "\n" + s + "</color>");
		}
		public static void Error(float s, string category = "DEFAULT")
		{
			Debug.Log ("<color=red>" + category + "\n" + s + "</color>");
		}
		public static void Highlight(float s, string category = "DEFAULT")
		{
			Debug.Log ("<color=green>" + category + "\n" + s + "</color>");
		}
	}
}