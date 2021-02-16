using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventCalendar.Model
{
   public class EventCalendarDbContext : DbContext
    {
        public EventCalendarDbContext (DbContextOptions<EventCalendarDbContext> options) : base(options)
        {

        }


        public DbSet<Event> Events { get; set; }
        public DbSet<EventTag> EventTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }
        public DbSet<UserTag> UserTags { get; set; }

    }
}
