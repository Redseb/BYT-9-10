using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    internal class StudentSubject {

        public struct Grade {
            public const double Insufficient = 2.0;
            public const double Sufficient = 3.0;
            public const double Satisfactory = 3.5;
            public const double Good = 4.0;
            public const double VeryGood = 4.5;
            public const double Excellent = 5.0;
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
