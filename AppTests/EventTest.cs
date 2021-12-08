using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;
using System.Collections.Generic;

namespace AppTests
{
    [TestClass]
    public class EventTest {

        public TimedEvent goodEvent;
        public DateTime past = new DateTime(2020, 7, 15);
        public static DateTime future = new DateTime(3020, 7, 15);
        public static DateTime future2 = new DateTime(4020, 7, 15);


        [TestInitialize]
        public void InitializeTest() {
            goodEvent = new TimedEvent(1, "Name", future, future2, false);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidIDNegative() {
            TimedEvent badEvent = new TimedEvent(-1, "Name", future, future2, false);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidNameShort() {
            TimedEvent badEvent = new TimedEvent(1, "N", future, future2, false);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidNameLong() {
            TimedEvent badEvent = new TimedEvent(1, "ABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABC", future, future2, false);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidStartPast() {
            TimedEvent badEvent = new TimedEvent(1, "N", past, future2, false);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidStartAfterEnd() {
            TimedEvent badEvent = new TimedEvent(1, "N", future2, future, false);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidEndPast() {
            TimedEvent badEvent = new TimedEvent(1, "N", future, past, false);
            Console.WriteLine("Finished");
        }
    }

}
