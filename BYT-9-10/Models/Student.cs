using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    public class Student : Account 
    {
        private string _studentNumber;
        [Required]
        [StringLength(6, MinimumLength = 6)]
        private string StudentNumber { 
            get {
                return _studentNumber;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (value.Length != 6 || value.First() != 's') {
                    throw new ValidationException();
                }
                _studentNumber = value;
            } }

        private List<Class> Classes;

        private List<Event_BYT> Events;



        public List<Message> Messages { get; set; }
        [Required]
        public List<StudentSubject> Subjects { get; set; }

        public Student(string name, string surname, string phoneNumber, string personalEmail, string password, string studentNumber) : base(name, surname, phoneNumber, personalEmail, password) {
            this.StudentNumber = studentNumber;
        }

        public override bool Login()
        {
            //Check this.studentNumber and this.password
            return true;
        }

        public List<Class> GetListOfClasses() 
        {
            return Classes;
        }

        public List<Event_BYT> GetListOfEvents() 
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
