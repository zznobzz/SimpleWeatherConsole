using SWC.WeatherManager.UI;


namespace SWC.WeatherManager.Command
{
    public class UnknownCommand : NonTerminatingCommand
    {
        public UnknownCommand(IUserInterface userInterface) : base(userInterface)
        {
        }
        protected override bool InternalCommand()
        {
            Interface.WriteMessage("Неизвестная команда, может вы опечатались?");
            return true;
        }
    }
}
