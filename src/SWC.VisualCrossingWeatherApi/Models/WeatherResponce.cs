
public class Rootobject
{
    public int queryCost { get; set; }
    public float latitude { get; set; }
    public float longitude { get; set; }
    public string resolvedAddress { get; set; }
    public string address { get; set; }
    public string timezone { get; set; }
    public float tzoffset { get; set; }
    public string description { get; set; }
    public List<Day> days { get; set; }
    public object[] alerts { get; set; }
    public Stations stations { get; set; }
    public CurrentConditions currentConditions { get; set; }
}

public class Stations
{
    public ULPB ULPB { get; set; }
}

public class ULPB
{
    public float distance { get; set; }
    public float latitude { get; set; }
    public float longitude { get; set; }
    public int useCount { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public int quality { get; set; }
    public float contribution { get; set; }
}

public class CurrentConditions
{
    public string datetime { get; set; }
    public int datetimeEpoch { get; set; }
    public float temp { get; set; }
    public float feelslike { get; set; }
    public float humidity { get; set; }
    public float dew { get; set; }
    public float precip { get; set; }
    public object precipprob { get; set; }
    public float snow { get; set; }
    public float snowdepth { get; set; }
    public object preciptype { get; set; }
    public object windgust { get; set; }
    public float windspeed { get; set; }
    public float winddir { get; set; }
    public float pressure { get; set; }
    public float visibility { get; set; }
    public float cloudcover { get; set; }
    public float solarradiation { get; set; }
    public float solarenergy { get; set; }
    public float uvindex { get; set; }
    public string conditions { get; set; }
    public string icon { get; set; }
    public string[] stations { get; set; }
    public string sunrise { get; set; }
    public int sunriseEpoch { get; set; }
    public string sunset { get; set; }
    public int sunsetEpoch { get; set; }
    public float moonphase { get; set; }
}

public class Day
{
    public string datetime { get; set; }
    public int datetimeEpoch { get; set; }
    public float tempmax { get; set; }
    public float tempmin { get; set; }
    public float temp { get; set; }
    public float feelslikemax { get; set; }
    public float feelslikemin { get; set; }
    public float feelslike { get; set; }
    public float dew { get; set; }
    public float humidity { get; set; }
    public float precip { get; set; }
    public float precipprob { get; set; }
    public float precipcover { get; set; }
    public object preciptype { get; set; }
    public float snow { get; set; }
    public float snowdepth { get; set; }
    public float windgust { get; set; }
    public float windspeed { get; set; }
    public float winddir { get; set; }
    public float pressure { get; set; }
    public float cloudcover { get; set; }
    public float visibility { get; set; }
    public float solarradiation { get; set; }
    public float solarenergy { get; set; }
    public float uvindex { get; set; }
    public float severerisk { get; set; }
    public string sunrise { get; set; }
    public int sunriseEpoch { get; set; }
    public string sunset { get; set; }
    public int sunsetEpoch { get; set; }
    public float moonphase { get; set; }
    public string conditions { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
    public string[] stations { get; set; }
    public string source { get; set; }
    public List<Hour> hours { get; set; }
}

public class Hour
{
    public string datetime { get; set; }
    public int datetimeEpoch { get; set; }
    public float temp { get; set; }
    public float feelslike { get; set; }
    public float humidity { get; set; }
    public float dew { get; set; }
    public float precip { get; set; }
    public float precipprob { get; set; }
    public float snow { get; set; }
    public float snowdepth { get; set; }
    public object preciptype { get; set; }
    public float windgust { get; set; }
    public float windspeed { get; set; }
    public float winddir { get; set; }
    public float pressure { get; set; }
    public float visibility { get; set; }
    public float cloudcover { get; set; }
    public float solarradiation { get; set; }
    public float? solarenergy { get; set; }
    public float uvindex { get; set; }
    public float severerisk { get; set; }
    public string conditions { get; set; }
    public string icon { get; set; }
    public string[] stations { get; set; }
    public string source { get; set; }
}
