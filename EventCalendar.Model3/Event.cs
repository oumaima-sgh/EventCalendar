using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventCalendar.Model
{
    class Event
    {
        [Key]
        public int IdEvent { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string Enddate { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Photo { get; set; }

    }
}
