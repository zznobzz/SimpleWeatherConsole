using SWC.Dtos;
using SWC.VisualCrossingWeatherApi;
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
            var apiKey = File.ReadAllText(Path.Combine(AppContext.BaseDirectory + "ApiKey.txt"));

            var unused = GetWeather(PlaceName, apiKey);
            return true;

        }

        protected async Task GetWeather(string place, string apiKey)
        {
            var weatherService = new WeatherApiService();
            var weather=  await weatherService.GetCurrentWeatherAsync(PlaceName, apiKey);
            if (weather != null)
            {
                Interface.WriteMessage($"Текущая погода в {weather.Address}");
                foreach (var day in weather.Days)
                {
                    Interface.WriteMessage($"{day.DateTime.Date.ToShortDateString()}:");
                    Interface.WriteMessage($"Температура: {day.Temp} C.");
                    Interface.WriteMessage($"Ощущается как: {day.FeelsLike} C.");
                    Interface.WriteMessage($"Условия: {day.Conditions}");
                    Interface.WriteMessage($"{day.Description}");
                    Interface.WriteWarning("Температура по часам:");
                    foreach (var hourlyWeather in day.hours)
                    {
                        Interface.WriteMessage($"{hourlyWeather.DateTime} : Температура: {hourlyWeather.Temp} C;" +
                                               $"Ощущается как: {hourlyWeather.FeelsLike} C." +
                                               $" Условия: {hourlyWeather.Conditions};"
                                              );
                    }
                }
            }
        }
    }
}
