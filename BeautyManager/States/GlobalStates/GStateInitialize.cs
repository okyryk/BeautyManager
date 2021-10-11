using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyManager.States.GlobalStates
{
	class GStateInitialize : IState
	{
		public void Execute(AppState AppData)
		{
			AppData.SetNextState(new GStateInstallation());
		}
	}
}
