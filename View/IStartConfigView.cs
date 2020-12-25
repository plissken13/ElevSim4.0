using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface IStartConfigView
    {
        int FloorsNumber { get; }
        int LiftsNumber { get; }

        public event Action AddStartConfig;
        void ShowError(string message);

    }
}
