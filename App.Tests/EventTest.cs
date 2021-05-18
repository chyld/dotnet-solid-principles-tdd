using System;
using Xunit;
using FluentAssertions;

namespace App.Tests
{
    public class EventTest
    {
        [Fact]
        public void testICalendar()
        {
            var twoHours = new TimeSpan(2, 0, 0);
            var event1 = new Event("My birthday party", new DateTime(2028, 6, 7, 8, 9, 0), twoHours);
            var uuid = event1.getUuid();

            string expected = "BEGIN:VEVENT\n" +
                    "DTSTART:2028-06-07T08:09\n" +
                    "DTEND:2028-06-07T10:09\n" +
                    $"UID:{uuid}@example.com\n" +
                    "DESCRIPTION:My birthday party\n" +
                    "END:VEVENT\n";

            event1.iCalendar.Should().Be(expected);
        }

        [Fact]
        public void toStringWorks()
        {
            var twoHours = new TimeSpan(2, 0, 0);
            var event1 = new Event("My birthday party", new DateTime(2028, 6, 7, 8, 9, 0), twoHours);
            event1.ToString().Should().Be("My birthday party at Jun 7, 2028 8:09 AM (ends at Jun 7, 2028 10:09 AM)");
        }
    }
}
