using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    internal class StudentSubject {

        public enum Grade {
            Insufficient = 2.0,
            Sufficient = 3.0,
            Satisfactory = 3.5,
            Good = 4.0,
            VeryGood = 4.5,
            Excellent = 5.0
        }

        [Required]
        public Student student { get; set; }

        [Required]
        public Subject subject { get; set; }

        [Required]
        public Grade grade { get; set; }

        public DateTime dateUpdated { get; set; }
    }
}
