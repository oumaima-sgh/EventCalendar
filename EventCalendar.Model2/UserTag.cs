using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventCalendarModel
{
    class UserTag
    {
        [Key]
        public int IdUserTag { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }

    }
}
