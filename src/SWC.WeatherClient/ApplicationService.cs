using SWC.WeatherManager.Command;
using SWC.WeatherManager.UI;

namespace SWC.WeatherClient
{
    public class ApplicationService : IApplicationService
    {
        private readonly IUserInterface _userInterface;
        public ApplicationService(IUserInterface userInterface)=>_userInterface = userInterface;
        

        public void Run()
        {
            Greeting();
            CheckApiFile();
            var response = GetCommand("?").RunCommand();
            while (!response.shouldQuit)
            {
                
                var input = _userInterface.ReadValue("> ").ToLower();
                var command = GetCommand(input);

                response = command.RunCommand();

                if (!response.wasSuccessful)
                {
                    _userInterface.WriteMessage("Введите h чтобы посмотреть справку.");
                }
            }
        }
        private void Greeting()
        {
            _userInterface.WriteMessage("*********************************************************************************************");
            _userInterface.WriteMessage("*                                                                                           *");
            _userInterface.WriteMessage("*               Приветствуем в SWC! Давайте посмотрим погоду.                               *");
            _userInterface.WriteMessage("*                                                                                           *");
            _userInterface.WriteMessage("*********************************************************************************************");
            _userInterface.WriteMessage("");
        }

        public void CheckApiFile()
        {
            var apiFile = Path.Combine(AppContext.BaseDirectory + "ApiKey.txt");
            if (!File.Exists(apiFile))
            {
                _userInterface.WriteWarning("Необходимо указать ключ API");
                GetCommand("sak").RunCommand();
            }
        }
        public ApplicationCommand GetCommand(string input)
        {
            switch (input)
            {
                case "1":
                    return new SetApiKeyCommand(_userInterface);
               case "2":
                   return new GetCurrentWeatherCommand(_userInterface);
                case "?":
                case "h":
                case "help":
                    return new HelpCommand(_userInterface);
                case "q":
                case "quit":
                    return new QuitCommand(_userInterface);
                
                
                default:
                    return new UnknownCommand(_userInterface);
            }
        }
    }
}
