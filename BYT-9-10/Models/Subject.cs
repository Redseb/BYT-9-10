using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models
{
    public enum PassMode { 
        Exam,
        Pass,
        ExamPass
    }
    internal class Subject
    {
        [Required]
        [StringLength(50, MinimumLength =5)]
        public string subjectName { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string subjectShortening { get; set; }
        [Required]
        public PassMode passMode { get; set; }
        [Required]
        public List<Class> clases { get; set; }

        public Double getPassRate() { //Returns passrate as a percentage
            return 0.5;
        }
    }
}
