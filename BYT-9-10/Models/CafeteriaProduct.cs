using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    public class CafeteriaProduct 
    {
        private int _productId;
        private Double _price;
        private DateTime _bestBeforeDate;
        [Required]
        public int ProductID {
            get {
                return _productId;
            }
            set {
                if (value < 0) {
                    throw new ValidationException();
                }
                _productId = value;
            }
        }
        [Required]
        [Range(0.01, double.MaxValue)]
        public Double Price {
            get {
                return _price;
            }
            set {
                if (value < 0.01) {
                    throw new ValidationException();
                }
                _price = value;
            }
        }
        [Required]
        public DateTime BestBeforeDate {
            get {
                return _bestBeforeDate;
            }
            set {
                if (value < DateTime.Now) { //Don't accept past best before dates
                    throw new ValidationException();
                }
                _bestBeforeDate = value;
            }
        }

        public CafeteriaProduct(int productId, Double price, DateTime bestBeforeDate) {
            ProductID = productId;
            Price = price;
            BestBeforeDate = bestBeforeDate;
        }

        public void ChangePrice(double newPrice) 
        {
            Price = newPrice;
        }

    }
}
