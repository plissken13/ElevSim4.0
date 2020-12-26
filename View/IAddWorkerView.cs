using System;
using System.Collections.Generic;
using System.Text;

namespace View
{
    public interface IAddWorker 
    {
        string WorkerName { get; }
        int StartFloor { get; }
        int EndFloor { get; }

        event Action AddW;
        void ShowError(string message);
    }
}
