using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    internal class Student : Account 
    {
        
        [Required]
        [StringLength(6, MinimumLength = 6)]
        private string StudentNumber { get; set; }

        private List<Class> Classes;

        private List<Event> Events;
        public List<Message> Messages { get; set; }
        [Required]
        public List<StudentSubject> Subjects { get; set; }


        public override bool Login()
        {
            //Check this.studentNumber and this.password
            return true;
        }

        public List<Class> GetListOfClasses() 
        {
            return Classes;
        }

        public List<Event> GetListOfEvents() 
        {
            return Events;
        }

        public static List<Student> GetAllStudentsFailingSubjects() 
        { 
            //Returns list of all students failing subjects.
            return new List<Student> {};
        }
    }
}
