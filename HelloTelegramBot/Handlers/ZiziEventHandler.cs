using System;
using System.Threading.Tasks;
using BotFramework;
using BotFramework.Utils;
using HelloTelegramBot.Utils;
using Serilog;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace HelloTelegramBot.Handlers
{
    public abstract class ZiziEventHandler : BotEventHandler
    {
        protected string TimeInit => RawUpdate.Message == null ? string.Empty : RawUpdate.Message.Date.GetDelay();
        protected string TimeProc => RawUpdate.Message == null ? string.Empty : RawUpdate.Message.Date.GetDelay();

        protected bool HasUsername => From.Username != null;

    }
}