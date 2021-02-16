using System;
using System.Collections.Generic;
using System.Text;

namespace EventCalendar.Model
{
    class EventCalendarDbContext : DbContext
    {
        public EventCalendarDbContext (DbContextOptions<EventCalendarDbContext> options) : base(options)
        {

        }
    }
}
