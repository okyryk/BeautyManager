using System;
using System.Collections.Generic;
using System.Text;
using BeautyManager.States.GlobalStates; 

namespace BeautyManager.States
{
	class AppState : IDisposable
	{
		private IState currentState = null;
		private bool isExit = false;
		public AppState()
		{
		}

        #region Execute application
        public void Init()
        {
            currentState = new GStateInitialize();
        }
        public void Execute()
        {
            while (!isExit)
            {
                if (currentState != null)
                {
                    currentState.Execute(this);
                }
                else
                {
                    return;
                }
            }
        }

        public void Ending()
        {
        }
        #endregion

        #region State

        public void SetNextState(IState State)
		{
			this.currentState = State;
		}

		public void ExitRequest()
		{
			isExit = true;
		}
		#endregion

		public void Dispose()
		{
			
		}
	}
}
