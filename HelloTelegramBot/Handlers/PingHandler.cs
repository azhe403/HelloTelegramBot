using System;
using System.Diagnostics;
using System.Threading.Tasks;
using BotFramework;
using BotFramework.Attributes;
using BotFramework.Setup;
using BotFramework.Utils;
using HelloTelegramBot.Utils;

namespace HelloTelegramBot.Handlers
{
    public class PingHandler : ZiziEventHandler
    {
        [Command("ping", CommandParseMode.Both)]
        public async Task Ping()
        {
            var currProcess = Process.GetCurrentProcess();
            var processStartTime = currProcess.StartTime;
            var processUptime = (DateTime.Now - processStartTime);

            await Bot.SendTextMessageAsync(Chat, $"Pong!" +
                                                 $"\nUptime: {processUptime.ToHumanDuration()}" +
                                                 $"\nTime: {TimeInit}");
        }
    }
}