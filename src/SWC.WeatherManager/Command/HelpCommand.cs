using SWC.WeatherManager.UI;


namespace SWC.WeatherManager.Command
{
    public class HelpCommand:NonTerminatingCommand
    {
        public HelpCommand(IUserInterface userInterface):base(userInterface)
        {

        }
        protected override bool InternalCommand()
        {
            Interface.WriteMessage("Справка по программе:");
            Interface.WriteWarning("\t setApiKey (sak)");
            Interface.WriteMessage("-Установить ключ API.");
            Interface.WriteWarning("\t GetCurrentWeather (gcw)");
            Interface.WriteMessage("-Узнать текущую погоду.");
            Interface.WriteWarning("\t quit (q)");
            Interface.WriteMessage("-Выйти из программы.");
            return true;
        }
    }
}
