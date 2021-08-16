using System.Threading.Tasks;
using BotFramework;
using BotFramework.Attributes;
using BotFramework.Enums;
using BotFramework.Setup;
using HelloTelegramBot.Utils;
using Serilog;

namespace HelloTelegramBot.Handlers
{
    public class UpdateHandler : ZiziEventHandler
    {
        [Update(InChat.All, UpdateFlag.All)]
        [Priority(10)]
        public async Task<bool> OnUpdate()
        {
            Log.Debug("New Update: {@RawUpdate}", RawUpdate);

            await Task.Delay(0);

            return true;
        }
    }
}