using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models
{
    internal class Student : Account
    {
        private int studentNumber { get; set; }
        private string password { get; set; }
        private List<Class> classes;
        private List<Event> events;

        public Student(int studentNumber, string password) {
            this.studentNumber = studentNumber;
            this.password = password;
        }
        public override bool login()
        {
            //Check this.studentNumber and this.password
            return true;
        }

        public List<Class> getListOfClasses() {
            return classes;
        }

        public List<Event> getListOfEvents() {
            return events;
        }

        public static List<Student> getAllStudentsFailingSubjects() { //Returns list of all students failing subjects.
            return new List<Student>{};
        }


    }
}
