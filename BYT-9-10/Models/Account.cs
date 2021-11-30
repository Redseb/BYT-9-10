using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    abstract class Account 
    {
        
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength =2)]
        public string Surname { get; set; }

        [StringLength(12, MinimumLength = 9)] //With or without country code
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string PersonalEmail { get; set; }

        [Required]
        [MinLength(10)]
        public string Password { get; }
        public List<CafeteriaOrder> CafeteriaOrders { get; set; }
        public List<Application> SentApplications { get; set; }

        public abstract bool Login();

        public void Logout() 
        {
            //Logs the user out of the system.
            return;
        }
        
        public bool ChangePassword(string newPassword) 
        {
            if (newPassword.Length > 10) 
            { //According to exemplary password requirements.
                return true;
            }
            return false;
        }
    }
}
