using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationTrackerBackend.Models
{
    public class Applications
    {
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
