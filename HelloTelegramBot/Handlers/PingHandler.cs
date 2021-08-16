using System;
using System.Diagnostics;
using System.Threading.Tasks;
using BotFramework;
using BotFramework.Attributes;
using BotFramework.Setup;
using BotFramework.Utils;
using HelloTelegramBot.Utils;
using Telegram.Bot.Types.Enums;

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

            var text = $"Pong!" +
                       $"\nUptime: {processUptime.ToHumanDuration()}" +
                       $"\nTime: {TimeInit}";

            var htmlMsg = new HtmlString()
                .Bold("🏓 Pong!").Br().Br()
                .Bold("🏃 Runtime: ").Code(processStartTime.ToString("yyyy-MM-dd HH:mm:ss.mmm")).Br()
                .Bold("⏱ Uptime: ").Code(processUptime.ToHumanDuration()).Br();

            await SendMessageTextAsync(htmlMsg, parseMode:ParseMode.Html);
        }
    }
}