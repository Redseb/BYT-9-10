using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    internal class Student : Account {
        
        [Required]
        [StringLength(6, MinimumLength = 6)]
        private string studentNumber { get; set; }

        private List<Class> classes;

        private List<Event> events;
        public List<Message> messages { get; set; }
        [Required]
        public List<Subject> subjects { get; set; }


        public override bool login(){
            //Check this.studentNumber and this.password
            return true;
        }

        public List<Class> getListOfClasses() {
            return classes;
        }

        public List<Event> getListOfEvents() {
            return events;
        }

        public static List<Student> getAllStudentsFailingSubjects() { 
            //Returns list of all students failing subjects.
            return new List<Student> {};
        }
    }
}
