using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    public class Message 
    {

        private int _messageId;
        private string _body;
        private DateTime _sendDateTime;
        private DateTime? _receivedDateTime;
        private Student _sender;
        private Student _receiver;
        [Required]
        public int MessageId {
            get {
                return _messageId;
            }
            set {
                if (value < 0) {
                    throw new ValidationException();
                }
                _messageId = value;
            }
        }
        [Required]
        [StringLength(1000,MinimumLength = 1)]
        public string Body {
            get {
                return _body;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (value.Length > 500) {
                    throw new ValidationException();
                }
                _body = value;
            }
        }
        [Required]
        public DateTime SendDateTime {
            get {
                return _sendDateTime;
            }
            set {
                if (value > DateTime.Now) { //Don't accept future dates
                    throw new ValidationException();
                }
                if (_receivedDateTime != null && _receivedDateTime < value) { //Don't allow send to be after receive
                    throw new ValidationException();
                }
                _sendDateTime = value;
            }
        }
        [Required]
        public DateTime? ReadDateTime {
            get {
                return _receivedDateTime;
            }
            set {
                if (value < DateTime.Now) { //Don't accept past dates
                    throw new ValidationException();
                }

                if (_sendDateTime.Year != 1 && _sendDateTime > value) { //Don't allow send to be after receive
                    throw new ValidationException();
                }
                _receivedDateTime = value;
            }
        }
        [Required]
        public Student Sender { get; set; }
        [Required]
        public Student Receiver { get; set; }

        public Message(int messageId, string body, DateTime sent, DateTime? received, Student sender, Student receiver) {
            MessageId = messageId;
            Body = body;
            SendDateTime = sent;
            ReadDateTime = received;
            Sender = sender;
            Receiver = receiver;
        }

        public static bool SendMessage(string studentNumberSender, string studentNumberReceiver, string body) 
        {
            //Sends a message to studentNumber
            return true;
        }
    }
}
