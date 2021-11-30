using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    internal class Application {

        [Required]
        public string applicationId { get; set; }

        [Required]
        public DateTime sendDate { get; set; }

        [Required]
        [StringLength(300)]
        public string applicationBody { get; set; }

        [Required]
        [StringLength(300)]
        public string replyMessage { get; set; }
        [Required]
        public bool isCancelled { get; set; }
        [Required]
        public Account sender { get; set; }
        [Required]
        public Teacher replier { get; set; } //Required but can be empty


        public void cancelApplication() {
            isCancelled = true;
        }

        public static List<Application> getListOfApplications(DateTime minSendDate) {
            //Returns list of all Applications with sendDate later than minSendDate.
            return new List<Application> {};
        }

        public void updateApplicationBody(string newBody) { 
            this.applicationBody = newBody;
        }

        public void updateReplyMessage(string newReply) { 
            this.replyMessage = newReply;
        }
    }
}
