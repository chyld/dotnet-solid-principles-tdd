using System;
using System.Text;

namespace App
{
    public class Todo : CalendarItem
    {

        public string Text { get; }
        public string Description { get; set; }
        public TodoStatus Status { get; private set; } = TodoStatus.INCOMPLETE;
        public DateTime? CompletedAt { get; private set; }
        public string OwnerFirstName { get; }
        public string OwnerLastName { get; }
        public string OwnerEmail { get; }
        public string OwnerJobTitle { get; }

        public Todo(string text, string ownerFirstName, string ownerLastName, string ownerEmail, string ownerJobTitle) =>
            (Text, OwnerFirstName, OwnerLastName, OwnerEmail, OwnerJobTitle) = (text, ownerFirstName, ownerLastName, ownerEmail, ownerJobTitle);

        public override string TextToDisplay => Text;

        public override void markComplete() =>
            (Status, CompletedAt) = (TodoStatus.COMPLETE, DateTime.Now);

        public override void markIncomplete() =>
            (Status, CompletedAt) = (TodoStatus.INCOMPLETE, null);

        public override bool isComplete => Status == TodoStatus.COMPLETE;

        public override string iCalendar
        {
            get
            {
                if (Text == null) throw new ArgumentException("You must specify the text");

                return new StringBuilder()
                        .Append("BEGIN:VTODO\n")
                        .Append($"COMPLETED::{CompletedAt}\n")
                        .Append($"UID:{getUuid()}@example.com\n")
                        .Append($"SUMMARY:{TextToDisplay}\n")
                        .Append("END:VTODO\n")
                        .ToString();
            }
        }

        public override string ToString()
        {
            var a = Text;
            var b = OwnerFirstName;
            var c = OwnerLastName;
            var d = OwnerEmail;
            var e = OwnerJobTitle;
            var f = Status == TodoStatus.INCOMPLETE ? "incomplete" : "complete";

            return $"{a} <{b} {c}> {d} ({e}): {f}";
        }
    }
}
