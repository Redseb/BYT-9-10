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
        [Required]
        public int MessageId { get; set; }
        [Required]
        [StringLength(1000,MinimumLength = 1)]
        public string Body { get; set; }
        [Required]
        public DateTime SendDateTime { get; set; }
        [Required]
        public DateTime ReadDateTime { get; set; }
        [Required]
        public Student Sender { get; set; }
        [Required]
        public Student Receiver { get; set; }

        public static bool SendMessage(string studentNumberSender, string studentNumberReceiver, string body) 
        {
            //Sends a message to studentNumber
            return true;
        }
    }
}
