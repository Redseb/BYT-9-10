﻿using System;
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


        public abstract bool login();

        public void logout() {
            return;
        }
        
        public bool changePassword(string newPassword) {
            if (newPassword.Length > 10) { //for example...
                return true;
            }
            return false;
        }
    }
}
