using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.WeatherManager.UI
{
    public interface IWriteUserInterface
    {
        void WriteMessage(string message);
        void WriteWarning(string message);
    }
}
