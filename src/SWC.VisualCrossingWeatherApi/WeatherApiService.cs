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
            .SetQueryParam("lang", "ru");

        var response = await requestUrl.AllowAnyHttpStatus().GetAsync();
        if (response.StatusCode<300)
        {
            var weather1 = response.GetJsonAsync<Rootobject>();
            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<WeatherMaperProfile>());
            var mapper = mapperConfig.CreateMapper();
            var adapted = mapper.Map<WeatherData>(weather1.Result);
            return adapted;
        }
        else if(response.StatusCode<500)
        {
            Console.WriteLine($"Вы что то сделали не так! Код ошибки: {response.StatusCode}");
            return null;
        }
        else
        {
            Console.WriteLine($"На сервере что то пошло не так не так! Код ошибки: {response.StatusCode}");
            return null;
        }
        //TODO:Обработка ошибок запроса
        


        /*var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
        var response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            using Stream responseStream = await response.Content.ReadAsStreamAsync();
            Rootobject? weather = await JsonSerializer.DeserializeAsync<Rootobject>(responseStream);

            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<WeatherMaperProfile>());
            var mapper = mapperConfig.CreateMapper();
            var adapted = mapper.Map<WeatherData>(weather);
            return adapted;
        }
        else
        {
            Console.WriteLine($"Запрос завершился с ошибкой. Причина :{response.StatusCode} ");
            return null;
        }*/
    }
}