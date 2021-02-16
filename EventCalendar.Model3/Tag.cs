using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventCalendar.Model
{
    class Tag
    {
        [Key]
        public int IdTag { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
