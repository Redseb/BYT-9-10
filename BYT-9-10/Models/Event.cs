using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    internal class Event {
        
        [Required]
        public int eventId { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public DateTime startDateTime { get; set; }

        [Required]
        public DateTime endDateTime { get; set; }

        public bool isCancelled { get; set; }
        public List<Student> attendees { get; set; }


        public void cancelEvent() { 
            this.isCancelled = true;
        }

        public void changeStartTime(DateTime newDateTime) {
            this.startDateTime = newDateTime;
        }
    }
}
