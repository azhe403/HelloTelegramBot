using System.Threading.Tasks;
using BotFramework.Attributes;
using BotFramework.Setup;
using BotFramework.Utils;
using HelloTelegramBot.Utils;

namespace HelloTelegramBot.Handlers
{
    public class DebugHandler : ZiziEventHandler
    {
        [Command("dbg", CommandParseMode.Both)]
        public async Task Debug()
        {
            var update = RawUpdate.ToJson(indented: true);

            var htmlStr = new HtmlString()
                .Bold("Debug Message").Br()
                .Code(update).Br();

            await SendMessageTextAsync(htmlStr);
        }
    }
}
