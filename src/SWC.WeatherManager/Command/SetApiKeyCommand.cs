using SWC.WeatherManager.UI;

namespace SWC.WeatherManager.Command;

public class SetApiKeyCommand:NonTerminatingCommand,IParameterisedCommand
{
   public SetApiKeyCommand(IUserInterface userInterface) : base(userInterface)
    {
    }
   public string? ServiceApiKey { get; private set; }
   
   public bool GetParameters()
    {
        if (string.IsNullOrWhiteSpace(ServiceApiKey))
            ServiceApiKey = GetParameter("ключ API");
        return !string.IsNullOrWhiteSpace(ServiceApiKey);
    }
   protected override bool InternalCommand()
   {
       var appPath = AppContext.BaseDirectory;
       var keyFile = Path.Combine(appPath, "ApiKey.txt");
       File.WriteAllText(keyFile, ServiceApiKey);
       Interface.WriteWarning($"Ключ API {ServiceApiKey} успешно установлен");
       return true;
   }
}