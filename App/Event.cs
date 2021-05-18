using System;
using System.Text;

namespace App
{
    public class Event : CalendarItem
    {

        public string Title { get; }
        public DateTime StartsAt { get; }
        public TimeSpan Duration { get; }

        public Event(string title, DateTime startsAt, TimeSpan duration) =>
            (Title, StartsAt, Duration) = (title, startsAt, duration);

        public override string TextToDisplay => Title;
        public DateTime EndsAt => StartsAt + Duration;

        public override void markComplete()
        {
        }

        public override void markIncomplete()
        {
        }

        public override bool isComplete => false;

        public override string iCalendar
        {
            get
            {
                if (Title == null) return "";

                return new StringBuilder()
                        .Append("BEGIN:VEVENT\n")
                        .Append($"DTSTART:{StartsAt.ToString("yyyy-MM-ddThh:mm")}\n")
                        .Append($"DTEND:{EndsAt.ToString("yyyy-MM-ddThh:mm")}\n")
                        .Append($"UID:{getUuid()}@example.com\n")
                        .Append($"DESCRIPTION:{TextToDisplay}\n")
                        .Append("END:VEVENT\n")
                        .ToString();
            }
        }

        public override string ToString()
        {
            var a = Title;
            var b = StartsAt.ToString(DATE_FORMATTER);
            var c = EndsAt.ToString(DATE_FORMATTER);
            return $"{a} at {b} (ends at {c})";
        }
    }
}
