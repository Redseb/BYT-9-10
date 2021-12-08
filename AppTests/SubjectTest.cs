using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;
using System.Collections.Generic;

namespace AppTests
{
    [TestClass]
    public class SubjectTest {

        public Teacher teacher;
        public Subject subject;

        [TestInitialize]
        public void InitializeTest() {
            teacher = new Teacher("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "sAmogus");
            subject = new Subject("Computer Science Algorithms", "CSA", PassMode.Pass, teacher);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidNameShort() {
            Subject badSubject = new Subject("a", "CSA", PassMode.Pass, teacher);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidNameLong() {
            Subject badSubject = new Subject("ABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABC", "CSA", PassMode.Pass, teacher);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidShorteningLong() {
            Subject badSubject = new Subject("Computer Science Algorithms", "CSAA", PassMode.Pass, teacher);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidShorteningShort() {
            Subject badSubject = new Subject("Computer Science Algorithms", "CS", PassMode.Pass, teacher);
            Console.WriteLine("Finished");
        }

    }

}
