using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;

namespace AppTests
{
    [TestClass]
    public class CafeteriaProductTest {

        CafeteriaProduct product;
        public DateTime past = new DateTime(2020, 7, 15);
        public DateTime future = new DateTime(3020, 7, 15);

        [TestInitialize]
        public void InitializeTest() {
            product = new CafeteriaProduct(0, 0.5, future);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidID() {
            CafeteriaProduct badProduct = new CafeteriaProduct(-1, 0.5, future);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidPrice() {
            CafeteriaProduct badProduct = new CafeteriaProduct(1, 0.001, future);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidPriceNegative() {
            CafeteriaProduct badProduct = new CafeteriaProduct(1, -1.0, future);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidBestBeforeDate() {
            CafeteriaProduct badProduct = new CafeteriaProduct(1, 5.0, past);
            Console.WriteLine("Finished");
        }
    }

}
