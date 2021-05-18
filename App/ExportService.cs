using System.Text;
using System.Collections.Generic;

namespace App
{
    public class ExportService {
        public string export(List<CalendarItem> objectsToExport) {
            StringBuilder builder = new StringBuilder()
                     .Append("BEGIN:VCALENDAR\n")
                     .Append("VERSION:2.0\n");

            objectsToExport.ForEach(o => builder.Append(o.iCalendar));

            return builder
                    .Append("END:VCALENDAR\n")
                    .ToString();
        }
    }
}
