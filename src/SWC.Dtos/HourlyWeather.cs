namespace SWC.Dtos;

public class HourlyWeather
{
    public string DateTime { get; set; }
    public int TimeEpoch { get; set; }
    public float Temp { get; set; }
    public float FeelsLike { get; set; }
    public float Humidity { get; set; }
    public float Dew { get; set; }
    public float Precip { get; set; }
    public float PrecipProb { get; set; }
    public float Snow { get; set; }
    public float SnowDepth { get; set; }
    public float WindGust { get; set; }
    public float WindSpeed { get; set; }
    public float WindDir { get; set; }
    public float Pressure { get; set; }
    public float Visibility { get; set; }
    public float CloudCover { get; set; }
    public float SolarRadiation { get; set; }
    public float UVindex { get; set; }
    public float SevereRisk { get; set; }
    public string Conditions { get; set; }
    public string Icon { get; set; }
    public float Solarenergy { get; set; }
    public TimeOnly Sunrise { get; set; }
    public int SunriseEpoch { get; set; }
    public TimeOnly Sunset { get; set; }
    public int SunsetEpoch { get; set; }
    public float Moonphase { get; set; }
}