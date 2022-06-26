using SWC.WeatherManager.UI;

namespace SWC.WeatherManager.Command
{
    public class GetCurrentWeatherCommand : NonTerminatingCommand, IParameterisedCommand
    {
        public GetCurrentWeatherCommand(IUserInterface userInterface):base(userInterface)
        {

        }
        public string? PlaceName { get; private set; }
        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(PlaceName))
                            PlaceName = GetParameter("город");
            return !string.IsNullOrWhiteSpace(PlaceName);
            
        }

        protected override bool InternalCommand()
        {
            throw new NotImplementedException("Implement later");
        }
    }
}
