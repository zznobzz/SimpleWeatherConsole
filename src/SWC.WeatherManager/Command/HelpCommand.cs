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
            Interface.WriteMessage("1 - Установить ключ API");
            Interface.WriteMessage("2 - Узнать текущую погоду.");
            Interface.WriteMessage("?, h, help - Получить справку по командам");
            Interface.WriteMessage("q - Выход из приложения.");
           
            return true;
        }
    }
}
