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

        protected async Task SendMessageTextAsync(
            HtmlString message,
            IReplyMarkup replyMarkup = null,
            ParseMode parseMode = ParseMode.Html,
            ChatId chatId = null,
            bool addStamp = true
        )
        {
            if (chatId == null) chatId = Chat.Id;

            if (addStamp)
            {
                message = new HtmlString()
                    .Append(message).Br()
                    .Code($"⏱ {TimeInit} s").Text(" | ").Code($"⌛ {TimeProc} s");
            }

            Log.Debug("Sending message to {chat}", chatId);
            await Bot.SendTextMessageAsync(chatId, message.ToString(), parseMode);
        }
    }
}