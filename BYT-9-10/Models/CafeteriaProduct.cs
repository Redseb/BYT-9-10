using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    internal class CafeteriaProduct {
        [Required]
        public int productID { get; set; }
        [Required]
        [Range(0.01, double.MaxValue)]
        public Double price { get; set; }
        [Required]
        public DateTime bestBeforeDate { get; set; }

        public void changePrice(double newPrice) {
            this.price = newPrice;
        }

    }
}
