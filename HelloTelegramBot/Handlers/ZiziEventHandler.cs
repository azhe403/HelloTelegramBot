using BotFramework;
using HelloTelegramBot.Utils;

namespace HelloTelegramBot.Handlers
{
    public abstract class ZiziEventHandler : BotEventHandler
    {
        protected string TimeInit => RawUpdate.Message.Date.GetDelay();
        protected string TimeProc => RawUpdate.Message.Date.GetDelay();
        protected bool HasUsername => From.Username != null;
    }
}