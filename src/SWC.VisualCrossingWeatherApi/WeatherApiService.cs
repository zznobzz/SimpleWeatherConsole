using System.Text.Json;
using SWC.Dtos;
using Flurl;
using Flurl.Http;
using AutoMapper;
namespace SWC.VisualCrossingWeatherApi;

public class WeatherApiService
{
    public async Task<WeatherData?> GetCurrentWeatherAsync(string inputPlace, string apiKey)
    {
        var requestUrl = VisualCrossingConsts.BaseApiUrl
            .AppendPathSegment(inputPlace)
            .AppendPathSegment("/today")
            .SetQueryParam("key", apiKey)
            .SetQueryParam("unitGroup", "metric")
            .SetQueryParam("include", "current,hours")
            .SetQueryParam("lang","ru");
        //var requestResult = await requestUrl.GetStringAsync();
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        Console.WriteLine(response.StatusCode);
        using Stream responseStream = await response.Content.ReadAsStreamAsync();
        Rootobject? weather = await JsonSerializer.DeserializeAsync<Rootobject>(responseStream);
        
        var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<WeatherMaperProfile>());
        var mapper = mapperConfig.CreateMapper();
        var adapted = mapper.Map<WeatherData>(weather);
        return adapted;
    }
}