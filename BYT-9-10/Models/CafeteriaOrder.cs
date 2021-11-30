using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    public enum PaymentMethod { 
        OnPickup,
        Online
    }
    public enum OrderStatus { 
        Accepted,
        BeingPrepared,
        ReadyForPickup,
        Cancelled
    }
    internal class CafeteriaOrder {
        [Required]
        public int orderId { get; set; }
        [Required]
        public PaymentMethod paymentMethod { get; set; }
        [Required]
        public DateTime orderDateTime { get; set; }
        [Required]
        public OrderStatus status { get; set; }

        public void cancelOrder() {
            this.status = OrderStatus.Cancelled;
            return;
        }

        public void sendNotification() {
            //Sends this.status
            return;
        }
    }
}
