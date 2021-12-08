using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;

namespace AppTests
{
    [TestClass]
    public class ApplicationTest {

        public Application application;
        public Student student;
        public Teacher teacher;
        public DateTime past = new DateTime(2020, 7, 15);
        public DateTime future = new DateTime(3020, 7, 15);
        public string longBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis congue quis felis vel imperdiet. Aenean ultricies volutpat arcu vestibulum ornare. Mauris aliquam, elit a mollis consectetur, quam velit sollicitudin mi, id tristique augue metus quis erat. Ut luctus tincidunt egestas. Nam auctor metus eget est fringilla, ac luctus erat porta. Curabitur facilisis tortor varius leo vulputate, sed placerat lorem dictum. In non sollicitudin libero. Integer volutpat erat massa. Integer a sagittis eros. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis congue quis felis vel imperdiet. Aenean ultricies volutpat arcu vestibulum ornare. Mauris aliquam, elit a mollis consectetur, quam velit sollicitudin mi, id tristique augue metus quis erat. Ut luctus tincidunt egestas. Nam auctor metus eget est fringilla, ac luctus erat porta. Curabitur facilisis tortor varius leo vulputate, sed placerat lorem dictum. In non sollicitudin libero. Integer volutpat erat massa. Integer a sagittis eros. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis congue quis felis vel imperdiet. Aenean ultricies volutpat arcu vestibulum ornare. Mauris aliquam, elit a mollis consectetur, quam velit sollicitudin mi, id tristique augue metus quis erat. Ut luctus tincidunt egestas. Nam auctor metus eget est fringilla, ac luctus erat porta. Curabitur facilisis tortor varius leo vulputate, sed placerat lorem dictum. In non sollicitudin libero. Integer volutpat erat massa. Integer a sagittis eros.";

        [TestInitialize]
        public void InitializeTest() {
            //Create a regular student, where all parameters fit
            student = new Student("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "s20961");
            teacher = new Teacher("Susus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "sAmogus");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidID() {
            application = new Application(-1, past, "Hello this is the body", "Hello this is the reply", false, student, teacher);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void FutureSendDate() {
            application = new Application(0, future, "Hello this is the body", "Hello this is the reply", false, student, teacher);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void BodyTooLong() {
            application = new Application(0, past, longBody, "Hello this is the reply", false, student, teacher);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void ReplyTooLong() {
            application = new Application(0, past, "Hello this is the body", longBody, false, student, teacher);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        public void NoResponder() {
            application = new Application(0, past, "Hello this is the body", "Hello this is the reply", false, student);
            Assert.IsTrue(application.Replier == null);
            Console.WriteLine("Finished");
        }

    }

}
