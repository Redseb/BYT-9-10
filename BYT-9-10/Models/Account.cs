using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    public abstract class Account 
    {
        
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name {
            get {
                return Name;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (value.Length < 2 || value.Length > 20) {
                    throw new ValidationException();
                }
            }
        }

        [Required]
        [StringLength(50, MinimumLength =2)]
        public string Surname {
            get {
                return Surname;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (value.Length < 2 || value.Length > 50) {
                    throw new ValidationException();
                }
            }
        }

        [StringLength(12, MinimumLength = 9)] //With or without country code
        public string PhoneNumber {
            get {
                return PhoneNumber;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (value.Length < 9 || value.Length > 12 || value.Any(x => !char.IsLetter(x)) ){
                    throw new ValidationException();
                }
            }
        }

        [Required]
        [EmailAddress]
        public string PersonalEmail {
            get {
                return PersonalEmail;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (!value.Contains('@') || !value.Contains('.')) {
                    throw new ValidationException();
                }
            }
        }

        [Required]
        [MinLength(10)]
        public string Password { get; set; }
        public List<CafeteriaOrder> CafeteriaOrders { get; set; }
        public List<Application> SentApplications { get; set; }

        public Account(string name, string surname, string phoneNumber, string personalEmail, string password) { 
            this.Name = Name;
            this.Surname = Surname;
            this.PhoneNumber = PhoneNumber;
            this.PersonalEmail = PersonalEmail;
            this.Password = Password;
        }

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
