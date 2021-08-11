using Serilog;

namespace HelloTelegramBot.Extensions
{
    public class LoggingExtension
    {
        public static void ConfigureSerilog()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
        }
    }
}