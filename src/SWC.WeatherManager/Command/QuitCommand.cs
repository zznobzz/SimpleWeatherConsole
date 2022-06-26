using SWC.WeatherManager.UI;

namespace SWC.WeatherManager.Command
{
    public class QuitCommand : ApplicationCommand
    {
        public QuitCommand(IUserInterface userInterface):base(true, userInterface)
        {

        }
        protected override bool InternalCommand()
        {
            Interface.WriteMessage("Спасибо, что пользуетесь SWC!");
            return true;
        }
    }
}
