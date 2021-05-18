using System;
using System.Linq;
using System.Collections.Generic;

namespace App
{
    public class Calendar {

        private List<CalendarItem> schedulables = new List<CalendarItem>();

        public void addSchedulable(CalendarItem schedulable) {
            schedulables.Add(schedulable);
            this.schedulables = schedulables.OrderBy(s => getLocalDateTime(s)).ToList();
        }
        public List<CalendarItem> items() => schedulables;

        public List<DateTime?> dates() {
            return schedulables.Select(s => getLocalDateTime(s)).ToList();
        }

        public List<string> descriptionsFor(DateTime date) => 
            schedulables.Where(s => getLocalDateTime(s).Value.Date == date).Select(s => s.ToString()).ToList();
        

        public DateTime? getFirstDateTime() {
            if (schedulables.Count == 0) return null;
            var item = schedulables.First();
            return getLocalDateTime(item);
        }

        public DateTime? getLastDateTime() {
            if (schedulables.Count == 0) return null;
            var item = schedulables.Last();
            return getLocalDateTime(item);
        }

        public String format() {
            MonthlyFormatter formatter = new MonthlyFormatter();
            return formatter.format(this);
        }

        private DateTime? getLocalDateTime(CalendarItem item) {
            var isEvent = typeof(Event).IsInstanceOfType(item);
            var isReminder = typeof(Reminder).IsInstanceOfType(item);

            if (isEvent) {
                return ((Event)item).StartsAt;
            } else if (isReminder) {
                return ((Reminder)item).RemindsAt;
            }

            return null;
        }
    }
}
