namespace Castor
{
	// ←↑→↓↔↕
	public static class Constants
	{
		public static class Prefabs
		{
			public const string PREFAB_UNIT_BASE = "Unit/pf_game_car";
	
			public const string PREFAB_STAGE_TEST = "Stage/pf_stage_arena_standard";
			
			public const string PREFAB_UI_MAIN_MENU = "UI/pf_ui_main_menu";
		}

		public static class Folders
		{
			public const string FOLDER_STAGE = "Stage/";
		}
		public static class Input
		{
			public const int ButtonA = 0;
			public const int ButtonB = 0;
			public const int ButtonX = 0;
			public const int ButtonY = 0;
			public const int ButtonL = 0;
			public const int ButtonR = 0;
			public const int ButtonBack = 0;
			public const int ButtonStart = 0;
			public const int ButtonUp = 0;
			public const int ButtonDown = 0;
			public const int ButtonLeft = 0;
			public const int ButtonRight = 0;
			public const int ButtonStickL = 0;
			public const int ButtonStickR = 0;

			public const int AxisLeftX = 0;
			public const int AxisLeftY = 0;
			public const int AxisRightX = 0;
			public const int AxisRightY = 0;
			public const int AxisTriggerLeft = 0;
			public const int AxisTriggerRight = 0;
			public const int PadX = 0;
			public const int PadY = 0;
		}
	}
	public static class Gameplay
	{
		public enum TileColor
		{
			BLANK,
			GREY,
			YELLOW,
			BLUE,
			RED,
			GREEN,
			PURPLE
		}
	}
}
	