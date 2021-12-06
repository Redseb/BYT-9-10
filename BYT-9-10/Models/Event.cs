using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    public class Event 
    {
        
        [Required]
        public int EventId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }

        [Required]
        public DateTime EndDateTime { get; set; }

        public bool IsCancelled { get; set; }
        public List<Student> Attendees { get; set; }


        public void CancelEvent() 
        { 
            this.IsCancelled = true;
        }

        public void ChangeStartTime(DateTime newDateTime) 
        {
            this.StartDateTime = newDateTime;
        }
    }
}
