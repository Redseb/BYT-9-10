using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;

namespace AppTests
{
    [TestClass]
    public class TeacherTest {

        public Teacher teacher;
        [TestInitialize]
        public void InitializeTest() {
            //Create a regular student, where all parameters fit
            teacher = new Teacher("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "sAmogus");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidEmailPrefixTooShort() {
            Student badStudent = new Student("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "a");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidEmailPrefixTooLong() {
            Student badStudent = new Student("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "abcdefghijklmnopqrstuvwxyz");
            Console.WriteLine("Finished");
        }
    }

}
