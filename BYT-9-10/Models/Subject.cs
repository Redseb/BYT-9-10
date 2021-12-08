using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models
{
    public enum PassMode 
    { 
        Exam,
        Pass,
        ExamPass
    }
    public class Subject
    {
        private string _subjectName;
        private string _subjectShortening;
        private Teacher _supervisedBy;
        [Required]
        [StringLength(50, MinimumLength =5)]
        public string SubjectName { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string SubjectShortening { get; set; }
        [Required]
        public PassMode PassMode { get; set; }
        [Required]
        public List<Class> Clases { get; set; }
        [Required]
        public List<Student> Students { get; set; }
        [Required]
        public Teacher SupervisedBy { get; set; }

        public Subject(string name, string shortening, PassMode passmode, Teacher supervisedBy) {
            SubjectName = name;
            SubjectShortening = shortening;
            SupervisedBy = supervisedBy;
            PassMode = passmode;
        }

        public Double GetPassRate() 
        { //Returns passrate as a percentage
            return 0.5;
        }
    }
}
