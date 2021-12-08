using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;

namespace AppTests
{
    [TestClass]
    public class StudentTest {

        public Student student;
        [TestInitialize]
        public void InitializeTest() {
            //Create a regular student, where all parameters fit
            student = new Student("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "s20961");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void AccountNameTooShort() {
            Student badStudent = new Student("S", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void AccountNameTooLong() {
            Student badStudent = new Student("abcdefghijklmnoqrstuvwxyz", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void AccountNameEmpty() {
            Student badStudent = new Student("", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void AccountSurnameTooShort() {
            Student badStudent = new Student("Sus", "A", "+48517826284", "amogus@amogus.com", "1234567890", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void AccountSurnameTooLong() {
            Student badStudent = new Student("Sus", "abcdefghijklmnoqrstuvwxyzabcdefghijklmnoqrstuvwxyzabcdefghijklmnoqrstuvwxyz", "+48517826284", "amogus@amogus.com", "1234567890", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void AccountSurnameEmpty() {
            Student badStudent = new Student("Sus", "", "+48517826284", "amogus@amogus.com", "1234567890", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void AccountPhonenumberTooShort() {
            Student badStudent = new Student("Sus", "Amogus", "+48514", "amogus@amogus.com", "123", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void AccountPhonenumberTooLong() {
            Student badStudent = new Student("Sus", "Amogus", "+48517882655454574", "amogus@amogus.com", "12345678901234567890", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void AccountPhonenumberAlphabet() {
            Student badStudent = new Student("Sus", "Amogus", "+abcf", "amogus@amogus.com", "abc123abc", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void AccountPhonenumberEmpty() {
            Student badStudent = new Student("Sus", "Amogus", "", "amogus@amogus.com", "abc123abc", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void AccountEmailInvalid() {
            Student badStudent = new Student("Sus", "Amogus", "+48517826284", "abc", "1234567890", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void AccountEmailEmpty() {
            Student badStudent = new Student("Sus", "Amogus", "+48517826284", "", "1234567890", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void AccountPasswordLength() {
            Student badStudent = new Student("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "123", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void AccountPasswordEmpty() {
            Student badStudent = new Student("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "", "s20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void StudentNumberNoSTest()
        {
            Student badStudent = new Student("Sus","Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "20961");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void StudentNumberIncorrectLengthTest() {
            Student badStudent = new Student("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "s209611");
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void NoStudentNumberTest() {
            Student badStudent = new Student("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "");
            Console.WriteLine("Finished");
        }
    }

}
