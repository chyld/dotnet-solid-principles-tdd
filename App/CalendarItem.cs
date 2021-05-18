using System;
namespace App
{
    public abstract class CalendarItem : ICompletable
    {
        public static string DATE_FORMATTER = "MMM d, yyyy h:mm tt";
        private string uuid;
        public CalendarItem() => uuid = Guid.NewGuid().ToString();
        public string getUuid() => uuid;
        public abstract string iCalendar { get; }
        public abstract string TextToDisplay { get; }
        public abstract bool isComplete { get; }
        public abstract void markComplete();
        public abstract void markIncomplete();
    }
}
