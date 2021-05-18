using System.Text;
namespace App
{
    public class ScheduleFormatter {
        public string format(Calendar calendar) {
            StringBuilder builder = new StringBuilder();

            calendar.dates().ForEach(date => {
                builder.Append(date).Append("\n");

                calendar.descriptionsFor(date.Value).ForEach(description => {
                    builder.Append(" - ").Append(description).Append("\n");
                });

                builder.Append("\n");
            });

            return builder.ToString();
        }
    }
}
