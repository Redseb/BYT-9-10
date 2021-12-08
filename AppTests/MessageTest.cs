using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;
using System.Collections.Generic;

namespace AppTests
{
    [TestClass]
    public class MessageTest {

        public Message message;
        public Student student1;
        public Student student2;
        public DateTime past = new DateTime(2020, 7, 15);
        public DateTime future = new DateTime(3020, 7, 15);
        public string longBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis congue quis felis vel imperdiet. Aenean ultricies volutpat arcu vestibulum ornare. Mauris aliquam, elit a mollis consectetur, quam velit sollicitudin mi, id tristique augue metus quis erat. Ut luctus tincidunt egestas. Nam auctor metus eget est fringilla, ac luctus erat porta. Curabitur facilisis tortor varius leo vulputate, sed placerat lorem dictum. In non sollicitudin libero. Integer volutpat erat massa. Integer a sagittis eros. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis congue quis felis vel imperdiet. Aenean ultricies volutpat arcu vestibulum ornare. Mauris aliquam, elit a mollis consectetur, quam velit sollicitudin mi, id tristique augue metus quis erat. Ut luctus tincidunt egestas. Nam auctor metus eget est fringilla, ac luctus erat porta. Curabitur facilisis tortor varius leo vulputate, sed placerat lorem dictum. In non sollicitudin libero. Integer volutpat erat massa. Integer a sagittis eros. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis congue quis felis vel imperdiet. Aenean ultricies volutpat arcu vestibulum ornare. Mauris aliquam, elit a mollis consectetur, quam velit sollicitudin mi, id tristique augue metus quis erat. Ut luctus tincidunt egestas. Nam auctor metus eget est fringilla, ac luctus erat porta. Curabitur facilisis tortor varius leo vulputate, sed placerat lorem dictum. In non sollicitudin libero. Integer volutpat erat massa. Integer a sagittis eros.";


        [TestInitialize]
        public void InitializeTest() {
            student1 = new Student("Sus", "Amogus", "+48517826284", "amogus@amogus.com", "1234567890", "s20961");
            student2 = new Student("Joe", "Biden", "+48517826284", "amogus@amogus.com", "1234554890", "s30961");
            message = new Message(1, "Hello this is a message", past, future, student1, student2);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidIdNegative() {
            Message badMessage = new Message(-1, "Hello this is a message", past, future, student1, student2);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InvalidBodyLengthShort() {
            Message badMessage = new Message(1, "", past, future, student1, student2);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidBodyLengthLong() {
            Message badMessage = new Message(1, longBody, past, future, student1, student2);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidSendReceive() {
            Message badMessage = new Message(1, "Hello this is a message", future, past, student1, student2);
            Console.WriteLine("Finished");
        }
    }

}
