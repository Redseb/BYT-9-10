using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;
using System.Collections.Generic;

namespace AppTests
{
    [TestClass]
    public class StudentSubjectTest {

        public Student student1;
        public Subject subject;
        public Teacher teacher;
        public StudentSubject studentSubject;
        public DateTime past = new DateTime(2020, 7, 15);
        public DateTime future = new DateTime(3020, 7, 15);


        [TestInitialize]
        public void InitializeTest() {
            student1 = new Student("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "s20961");
            teacher = new Teacher("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "sAmogus");
            subject = new Subject("Computer Science Algorithms", "CSA", PassMode.Pass, teacher);
            studentSubject = new StudentSubject(student1, subject, StudentSubject.GradesAvailable.VeryGood, past);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidUpdatedDateFuture() {
            StudentSubject badStudentSubject = new StudentSubject(student1, subject, StudentSubject.GradesAvailable.VeryGood, future);
            Console.WriteLine("Finished");
        }

    }

}
