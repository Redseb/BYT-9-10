using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;
using System.Collections.Generic;

namespace AppTests
{
    [TestClass]
    public class ClassTest {

        public Class class1;
        public DateTime past = new DateTime(2020, 7, 15);
        public static DateTime future = new DateTime(3020, 7, 15);
        public static DateTime future2 = new DateTime(4020, 7, 15);
        public Teacher teacher;
        public Subject subject;

        [TestInitialize]
        public void InitializeTest() {
            teacher = new Teacher("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "sAmogus");
            subject = new Subject("Computer Science Algorithms", "CSA", PassMode.Pass, teacher);
            class1 = new Class(1, "CSA Tutorial 1", future, future2, false, "A112", false, "14C", teacher, subject);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidRoomNumberLength() {
            Class badClass = new Class(1, "CSA Tutorial 1", future, future2, false, "A1123", false, "14C", teacher, subject);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidRoomNumberNoLetter() {
            Class badClass = new Class(1, "CSA Tutorial 1", future, future2, false, "1112", false, "14C", teacher, subject);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidGroupLength() {
            Class badClass = new Class(1, "CSA Tutorial 1", future, future2, false, "A112", false, "14CC", teacher, subject);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidGroupAlphabet() {
            Class badClass = new Class(1, "CSA Tutorial 1", future, future2, false, "A112", false, "144", teacher, subject);
            Console.WriteLine("Finished");
        }
    }

}
