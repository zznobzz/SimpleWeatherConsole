using SWC.WeatherManager.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.WeatherManager.Command
{
    public abstract class ApplicationCommand
    {
        private readonly bool _isTerminatingCommand;
        protected IUserInterface Interface { get; }
        protected ApplicationCommand(bool commandIsTerminating, IUserInterface userInterface)
        {
            _isTerminatingCommand = commandIsTerminating;
            Interface = userInterface;
        }

        public (bool wasSuccessful, bool shouldQuit) RunCommand()
        {
            if (this is IParameterisedCommand parameterisedCommand)
            {
                var allParametersCompleted = false;

                while (allParametersCompleted == false)
                {
                    allParametersCompleted = parameterisedCommand.GetParameters();
                }
            }

            return (InternalCommand(), _isTerminatingCommand);
        }
        protected abstract bool InternalCommand();

        protected string? GetParameter(string parameterName)
        {
            return Interface.ReadValue($"Введите {parameterName}:");
        }

    }
}
