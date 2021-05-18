using System;
using System.Text;

namespace App
{
    public class Reminder : CalendarItem
    {

        public string Description { get; }
        public DateTime RemindsAt { get; }
        private bool complete;
        public Reminder(string description, DateTime remindsAt) => (Description, RemindsAt) = (description, remindsAt);
        public override string TextToDisplay => Description;
        public override bool isComplete => complete;
        public override void markComplete() => this.complete = true;
        public override void markIncomplete() => this.complete = false;

        public override string iCalendar
        {
            get
            {
                if (Description == null) return "";

                return new StringBuilder()
                        .Append("BEGIN:VALARM\n")
                        .Append($"TRIGGER:-{RemindsAt.ToString("yyyy-MM-ddThh:mm")}\n")
                        .Append("ACTION:DISPLAY\n")
                        .Append($"UID:{getUuid()}@example.com\n")
                        .Append($"DESCRIPTION:{TextToDisplay}\n")
                        .Append("END:VALARM\n")
                        .ToString();
            }
        }

        public override string ToString()
        {
            var isC = isComplete ? "complete" : "incomplete";
            var remind = RemindsAt.ToString(DATE_FORMATTER);
            return $"{Description} at {remind} ({isC})";
        }
    }
}
