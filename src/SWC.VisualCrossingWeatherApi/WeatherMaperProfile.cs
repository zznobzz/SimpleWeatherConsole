using AutoMapper;
using SWC.Dtos;

namespace SWC.VisualCrossingWeatherApi;

public class WeatherMaperProfile:Profile
{
    public WeatherMaperProfile()
    {
        CreateMap<Rootobject, WeatherData>();
        CreateMap<Day, DaylyWeather>();
        CreateMap<Hour, HourlyWeather>();
        CreateMap<CurrentConditions, CurrentCondition>();
    }
}