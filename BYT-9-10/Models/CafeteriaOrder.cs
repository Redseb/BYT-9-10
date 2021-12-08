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
        private int _orderId;
        private DateTime _orderedDateTime;
        private List<CafeteriaProduct> _products;
        [Required]
        public int OrderId {
            get {
                return _orderId;
            }
            set {
                if (value < 0) {
                    throw new ValidationException();
                }
                _orderId = value;
            }
        }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
        [Required]
        public DateTime OrderDateTime {
            get {
                return _orderedDateTime;
            }
            set {
                if (value > DateTime.Now) { //Don't accept future order dates
                    throw new ValidationException();
                }
                _orderedDateTime = value;
            }
        }
        [Required]
        public OrderStatus Status { get; set; }
        public List<CafeteriaProduct> Products {
            get {
                return _products;
            }
            set {
                if (value.Count < 1) { //Don't empty orders
                    throw new ValidationException();
                }
                _products = value;
            }
        }

        public CafeteriaOrder(int orderId, PaymentMethod paymentMethod, DateTime orderedDateTime, OrderStatus orderStatus, List<CafeteriaProduct> products) {
            OrderId = orderId;
            PaymentMethod = paymentMethod;
            OrderDateTime = orderedDateTime;
            Status = orderStatus;
            Products = products;
        }

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
