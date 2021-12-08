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
        private string _name;
        private string _surname;
        private string _email;
        private string _password;
        private string _phone;
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name {
            get {
                return _name;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (value.Length < 2 || value.Length > 20) {
                    throw new ValidationException();
                }
                _name = value;
            }
        }

        [Required]
        [StringLength(50, MinimumLength =2)]
        public string Surname {
            get {
                return _surname;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (value.Length < 2 || value.Length > 50) {
                    throw new ValidationException();
                }
                _surname = value;
            }
        }

        [StringLength(12, MinimumLength = 9)] //With or without country code
        public string PhoneNumber {
            get {
                return _phone;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (value.Length < 9 || value.Length > 12 || value.Any(x => char.IsLetter(x)) ){
                    throw new ValidationException();
                }
                _phone = value;
            }
        }

        [Required]
        [EmailAddress]
        public string PersonalEmail {
            get {
                return _email;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (!value.Contains('@') || !value.Contains('.')) {
                    throw new ValidationException();
                }
                _email = value;
            }
        }

        [Required]
        [MinLength(10)]
        public string Password {
            get {
                return _password;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (value.Length < 10) {
                    throw new ValidationException();
                }
                _password = value;
            }
        }
        public List<CafeteriaOrder> CafeteriaOrders { get; set; }
        public List<Application> SentApplications { get; set; }

        public Account(string name, string surname, string phoneNumber, string personalEmail, string password) { 
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
            this.PersonalEmail = personalEmail;
            this.Password = password;
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
