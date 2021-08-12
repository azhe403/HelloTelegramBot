using System.Threading.Tasks;
using BotFramework;
using BotFramework.Attributes;
using BotFramework.Enums;
using BotFramework.Setup;
using Serilog;

namespace HelloTelegramBot.Handlers
{
    public class UpdateHandler : ZiziEventHandler
    {
        [Update(InChat.All, UpdateFlag.All)]
        [Priority(10)]
        public async Task<bool> OnUpdate()
        {
            await Bot.SendTextMessageAsync(Chat,"New Update!" +
                                                $"\nTime: {TimeInit}");

            return true;
        }
    }
}