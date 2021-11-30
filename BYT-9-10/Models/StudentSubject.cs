using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    internal class StudentSubject 
    {

        public struct GradesAvailable 
        {
            public const double Insufficient = 2.0;
            public const double Sufficient = 3.0;
            public const double Satisfactory = 3.5;
            public const double Good = 4.0;
            public const double VeryGood = 4.5;
            public const double Excellent = 5.0;
        }

        [Required]
        public Student Student { get; set; }

        [Required]
        public Subject Subject { get; set; }

        [Required]
        public GradesAvailable Grade { get; set; }

        public DateTime DateUpdated { get; set; }

        public void setGrade(GradesAvailable newGrade) 
        {
            this.Grade = newGrade;
        }
    }
}
