using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    internal class Message {
        [Required]
        public int messageId { get; set; }
        [Required]
        [StringLength(1000,MinimumLength = 1)]
        public string body { get; set; }
        [Required]
        public DateTime sendDateTime { get; set; }
        [Required]
        public DateTime readDateTime { get; set; }
        [Required]
        public Student sender { get; set; }
        [Required]
        public Student receiver { get; set; }

        public static bool sendMessage(string studentNumberSender, string studentNumberReceiver, string body) {
            //Sends a message to studentNumber
            return true;
        }
    }
}
