﻿namespace Castor
{
	// ←↑→↓↔↕
	public static class Constants
	{
		public static class Prefabs
		{
			public const string PREFAB_CAR_BLUE = "Unit/pf_game_car_blue";
			public const string PREFAB_CAR_ORANGE = "Unit/pf_game_car_orange";
	
			public const string PREFAB_STAGE_TEST = "Stage/pf_stage_arena_standard";
			
			public const string PREFAB_UI_MAIN_MENU = "UI/pf_ui_main_menu";
		}

		public static class Folders
		{
			public const string FOLDER_STAGE = "Stage/";
		}
		public static class Input
		{
			public const int COUNT_BUTTON = 14;
			public const int COUNT_AXIS = 8;
			public const int AXIS_MULTIPLIER = 1000;

			public const int BUTTON_A = 0;
			public const int BUTTON_B = 1;
			public const int BUTTON_X = 2;
			public const int BUTTON_Y = 3;
			public const int BUTTON_L = 4;
			public const int BUTTON_R = 5;
			public const int BUTTON_BACK = 6;
			public const int BUTTON_START = 7;
			public const int BUTTON_UP = 8;
			public const int BUTTON_DOWN = 9;
			public const int BUTTON_LEFT = 10;
			public const int BUTTON_RIGHT = 11;
			public const int BUTTON_STICK_L = 12;
			public const int BUTTON_STICK_R = 13;

			public const int AXIS_LEFT_X = 1;
			public const int AXIS_LEFT_Y = 2;
			public const int AXIS_TRIGGER = 3;
			public const int AXIS_RIGHT_X = 4;
			public const int AXIS_RIGHT_Y = 5;
			public const int AXIS_TRIGGER_LEFT = 6;
			public const int AXIS_TRIGGER_RIGHT = 7;
			public const int PAD_X = 8;
			public const int PAD_Y = 9;
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
	