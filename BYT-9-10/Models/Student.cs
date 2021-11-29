using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models
{
    internal class Student
    {
        private int studentNumber { get; set; }
        private string password { get; set; }
        private List<Class> classes { set; }
        private List<Event> events { set; }

        public Student(int studentNumber, string password) {
            this.studentNumber = studentNumber;
            this.password = password;
        }

        public void login(int studentNumber, string password) { //Returns true if login successfull.
            return true;
        }

        public List<Class> getListOfClasses() {
            return classes;
        }

        public List<Event> getListOfEvents() {
            return events;
        }

        public static getAllStudentsFailingSubjects() { //Returns list of all students failing subjects.
            return new List<Student>{};
        }
    }
}
