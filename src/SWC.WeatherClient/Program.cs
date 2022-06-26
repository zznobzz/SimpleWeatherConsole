using SWC.WeatherClient;

var service = new ApplicationService(new ConsoleUI());
service.Run();
Console.WriteLine("Программа закрывается.");
