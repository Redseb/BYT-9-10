using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    internal class CafeteriaProduct 
    {
        [Required]
        public int ProductID { get; set; }
        [Required]
        [Range(0.01, double.MaxValue)]
        public Double Price { get; set; }
        [Required]
        public DateTime BestBeforeDate { get; set; }

        public void ChangePrice(double newPrice) 
        {
            this.Price = newPrice;
        }

    }
}
