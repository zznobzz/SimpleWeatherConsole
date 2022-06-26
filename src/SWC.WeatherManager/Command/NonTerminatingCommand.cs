using SWC.WeatherManager.UI;

namespace SWC.WeatherManager.Command
{
    public abstract class NonTerminatingCommand:ApplicationCommand
    {
        protected  NonTerminatingCommand(IUserInterface userInterface):base(false, userInterface)
        {

        }
    }
}
