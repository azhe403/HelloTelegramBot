using System;
using System.Text;

namespace HelloTelegramBot.Utils
{
    public static class TimeUtil
    {
        public static string ToHumanDuration(this TimeSpan duration, bool displaySign = true)
        {
            // if (duration == null) return null;

            var builder = new StringBuilder();
            if (displaySign)
            {
                builder.Append(duration.TotalMilliseconds < 0 ? "-" : "+");
            }

            duration = duration.Duration();

            if (duration.Days > 0)
            {
                builder.Append($"{duration.Days}d ");
            }

            if (duration.Hours > 0)
            {
                builder.Append($"{duration.Hours}h ");
            }

            if (duration.Minutes > 0)
            {
                builder.Append($"{duration.Minutes}m ");
            }

            if (duration.TotalHours < 1)
            {
                if (duration.Seconds > 0)
                {
                    builder.Append(duration.Seconds);
                    if (duration.Milliseconds > 0)
                    {
                        builder.Append($".{duration.Milliseconds.ToString().PadLeft(3, '0')}");
                    }

                    builder.Append("s ");
                }
                else
                {
                    if (duration.Milliseconds > 0)
                    {
                        builder.Append($"{duration.Milliseconds}ms ");
                    }
                }
            }

            if (builder.Length <= 1)
            {
                builder.Append(" <1ms ");
            }

            builder.Remove(builder.Length - 1, 1);

            return builder.ToString();
        }
    }
}