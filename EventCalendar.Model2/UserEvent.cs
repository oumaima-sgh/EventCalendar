using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventCalendarModel
{
    class UserEvent
    {
        [Key]
        public int IdUserEvent { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
