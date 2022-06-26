namespace SWC.Dtos;

public class WeatherData
{
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public string ResolvedAddress { get; set; }
    public string Address { get; set; }
    public string Timezone { get; set; }
    public float TZOffset { get; set; }
    public DaylyWeather[] Days { get; set; }
    public object[] Alerts { get; set; }
    public CurrentCondition CurrentCondition { get; set; }
}