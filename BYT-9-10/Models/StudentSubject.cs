using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    public class StudentSubject 
    {
        private DateTime _dateUpdated;
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
        public Double Grade { get; set; }

        public DateTime DateUpdated {
            get {
                return _dateUpdated;
            }
            set {
                if (value > DateTime.Now) { //Don't accept future updated dates
                    throw new ValidationException();
                }
                _dateUpdated = value;
            }
        }

        public StudentSubject(Student student, Subject subject, Double grade, DateTime dateUpdated) { 
            Student = student;
            Subject = subject;
            Grade = grade;
            DateUpdated = dateUpdated;
        }

        public void setGrade(Double newGrade) 
        {
            this.Grade = newGrade;
        }
    }
}
