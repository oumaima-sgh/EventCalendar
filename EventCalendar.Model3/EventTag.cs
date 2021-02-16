using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventCalendar.Model
{
    class EventTag
    {
        [Key]
        public int IdEventTag { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
       
    }
}
