using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace App.Tests
{
    public class TodoTest
    {
        [Fact]
        public void testICalendar() {
            Todo todo1 = new Todo("Do stuff", "Alex", "Hamilton", "alex@example.com", "Treasurer");

            String expected = "BEGIN:VTODO\n" +
                    "COMPLETED::\n" +
                    $"UID:{todo1.getUuid()}@example.com\n" +
                    "SUMMARY:Do stuff\n" +
                    "END:VTODO\n";

            todo1.iCalendar.Should().Be(expected);
        }

        [Fact]
        public void toStringWorks() {
            Todo todo1 = new Todo("Do stuff", "Alex", "Hamilton", "alex@example.com", "Treasurer");

            todo1.ToString().Should().Be("Do stuff <Alex Hamilton> alex@example.com (Treasurer): incomplete");

            todo1.markComplete();

            todo1.ToString().Should().Be("Do stuff <Alex Hamilton> alex@example.com (Treasurer): complete");
        }

        [Fact]
        public void itHasADescription() {
            Todo todo1 = new Todo("Do stuff", "Alex", "Hamilton", "alex@example.com", "Treasurer");
            todo1.Description = "There's a million things he hasn't done";
            todo1.Description.Should().Be("There's a million things he hasn't done");
        }
    }
}
