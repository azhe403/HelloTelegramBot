using Serilog;

namespace HelloTelegramBot.Extensions
{
    public class LoggingExtension
    {
        public static void ConfigureSerilog()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console()
                .CreateLogger();
        }
    }
}