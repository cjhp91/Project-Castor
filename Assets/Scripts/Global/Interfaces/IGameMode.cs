using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Castor
{
	public interface IGameMode
	{
		void Init(GameModeData modeData);
		void Ready();
		void Clean();
	}
	public class GameModeData
	{
	}
}
	