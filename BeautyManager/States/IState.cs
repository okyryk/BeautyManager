using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyManager.States
{
    interface IState
    {
        void Execute(AppState AppData);
    }
}
