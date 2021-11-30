using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    internal class Application 
    {

        [Required]
        public string ApplicationId { get; set; }

        [Required]
        public DateTime SendDate { get; set; }

        [Required]
        [StringLength(300)]
        public string ApplicationBody { get; set; }

        [Required]
        [StringLength(300)]
        public string ReplyMessage { get; set; }
        [Required]
        public bool IsCancelled { get; set; }
        [Required]
        public Account Sender { get; set; }
        [Required]
        public Teacher Replier { get; set; } //Required but can be empty


        public void CancelApplication() 
        {
            IsCancelled = true;
        }

        public static List<Application> GetListOfApplications(DateTime minSendDate)
        {
            //Returns list of all Applications with sendDate later than minSendDate.
            return new List<Application> {};
        }

        public void UpdateApplicationBody(string newBody) 
        { 
            this.ApplicationBody = newBody;
        }

        public void UpdateReplyMessage(string newReply) 
        { 
            this.ReplyMessage = newReply;
        }
    }
}
