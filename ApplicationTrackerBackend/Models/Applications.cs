using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationTrackerBackend.Models
{
    public class Applications
    {
        public int ApplicationsId { get; set; }
        public DateTime DateTime {get; set;}
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Link { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
