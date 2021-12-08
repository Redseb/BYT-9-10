using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;
using System.Collections.Generic;

namespace AppTests
{
    [TestClass]
    public class EventTest {

        public Event_BYT goodEvent;
        public DateTime past = new DateTime(2020, 7, 15);
        public static DateTime future = new DateTime(3020, 7, 15);
        public static DateTime future2 = new DateTime(4020, 7, 15);


        [TestInitialize]
        public void InitializeTest() {
            goodEvent = new Event_BYT(1, "Name", future, future2, false);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidIDNegative() {
            Event_BYT badEvent = new Event_BYT(-1, "Name", future, future2, false);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidNameShort() {
            Event_BYT badEvent = new Event_BYT(1, "N", future, future2, false);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidNameLong() {
            Event_BYT badEvent = new Event_BYT(1, "ABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABC", future, future2, false);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidStartPast() {
            Event_BYT badEvent = new Event_BYT(1, "N", past, future2, false);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidStartAfterEnd() {
            Event_BYT badEvent = new Event_BYT(1, "N", future2, future, false);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidEndPast() {
            Event_BYT badEvent = new Event_BYT(1, "N", future, past, false);
            Console.WriteLine("Finished");
        }
    }

}
