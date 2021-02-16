using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventCalendarModel
{
    class User
    {
        [Key]
        public int IdUser { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int IdTag { get; set; }
        [Required]
        public int IdEvent { get; set; }
    }
}
