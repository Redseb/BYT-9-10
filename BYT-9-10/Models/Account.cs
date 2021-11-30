using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    abstract class Account {
        
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string name { get; set; }

        [Required]
        [StringLength(50, MinimumLength =2)]
        public string surname { get; set; }

        [StringLength(12, MinimumLength = 9)] //With or without country code
        public string phoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string personalEmail { get; set; }

        [Required]
        [MinLength(10)]
        public string password { get; }
        public List<CafeteriaOrder> cafeteriaOrders { get; set; }
        public List<Application> sentApplications { get; set; }

        public abstract bool login();

        public void logout() {
            //Logs the user out of the system.
            return;
        }
        
        public bool changePassword(string newPassword) {
            if (newPassword.Length > 10) { //According to exemplary password requirements.
                return true;
            }
            return false;
        }
    }
}
