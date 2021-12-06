using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    public enum PaymentMethod 
    { 
        OnPickup,
        Online
    }
    public enum OrderStatus 
    { 
        Accepted,
        BeingPrepared,
        ReadyForPickup,
        Cancelled
    }
    public class CafeteriaOrder 
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
        [Required]
        public DateTime OrderDateTime { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        public List<CafeteriaProduct> Products { get; set; }

        public void CancelOrder() 
        {
            this.Status = OrderStatus.Cancelled;
            return;
        }

        public void SendNotification() 
        {
            //Sends this.status
            return;
        }
    }
}
