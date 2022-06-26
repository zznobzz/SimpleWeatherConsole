namespace SWC.Dtos;

public class DaylyWeather
{
    public DateTime DateTime { get; set; }
    public int DateTimeEpoch { get; set; }
    public float TempMax { get; set; }
    public float TempMin { get; set; }
    public float Temp { get; set; }
    public float FeelsLikeMax { get; set; }
    public float FeelsLikeMin { get; set; }
    public float FeelsLike { get; set; }
    public float Dew { get; set; }
    public float Humidity { get; set; }
    public float Precip { get; set; }
    public float PrecipProb { get; set; }
    public float PrecipCover { get; set; }
    public float Snow { get; set; }
    public float SnowDepth { get; set; }
    public float WindGust { get; set; }
    public float WindSpeed { get; set; }
    public float WindDir { get; set; }
    public float Pressure { get; set; }
    public float CloudCover { get; set; }
    public float Visibility { get; set; }
    public float SolarRadiation { get; set; }
    public float SolarEnergy { get; set; }
    public float UVindex { get; set; }
    public float SevereRisk { get; set; }
    public string Sunrise { get; set; }
    public int SunriseEpoch { get; set; }
    public string Sunset { get; set; }
    public int SunsetEpoch { get; set; }
    public float MoonPhase { get; set; }
    public string Conditions { get; set; }
    public string Description { get; set; }
    public string IconUrl { get; set; }
    public HourlyWeather[] hours { get; set; }
}