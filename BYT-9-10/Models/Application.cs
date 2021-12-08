using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    public class Application 
    {

        private int _applicationId;
        private DateTime _sendDate;
        private string _applicationBody;
        private string _replyMessage;

        [Required]
        public int ApplicationId {
            get {
                return _applicationId;
            }
            set {
                if (value < 0) {
                    throw new ValidationException();
                }
                _applicationId = value;
            }
        }

        [Required]
        public DateTime SendDate {
            get {
                return _sendDate;
            }
            set {
                if (value > DateTime.Now) { //Don't accept future send dates
                    throw new ValidationException();
                }
                _sendDate = value;
            }
        }

        [Required]
        [StringLength(300)]
        public string ApplicationBody {
            get {
                return _applicationBody;
            }
            set {
                if (value.Length > 300) {
                    throw new ValidationException();
                }
                _applicationBody = value;
            }
        }

        [Required]
        [StringLength(300)]
        public string ReplyMessage {
            get {
                return _replyMessage;
            }
            set {
                if (value.Length > 300) {
                    throw new ValidationException();
                }
                _replyMessage = value;
            }
        }
        [Required]
        public bool IsCancelled { get; set; }
        [Required]
        public Account Sender { get; set; }
        [Required]
        public Teacher Replier { get; set; } //Required but can be empty

        public Application(int applicationId, DateTime sendDate, string applicationBody, string replyMessage, bool isCancelled, Account sender, Teacher replier) { 
            this.ApplicationId = applicationId;
            this.ApplicationBody = applicationBody;
            this.SendDate = sendDate;
            this.ReplyMessage = replyMessage;
            this.IsCancelled = isCancelled;
            this.Sender = sender;
            this.Replier = replier;
        }

        public Application(int applicationId, DateTime sendDate, string applicationBody, string replyMessage, bool isCancelled, Account sender) {
            this.ApplicationId = applicationId;
            this.ApplicationBody = applicationBody;
            this.SendDate = sendDate;
            this.ReplyMessage = replyMessage;
            this.IsCancelled = isCancelled;
            this.Sender = sender;
        }

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
