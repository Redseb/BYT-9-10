using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT_9_10.Models;
using System;
using System.Collections.Generic;

namespace AppTests
{
    [TestClass]
    public class CafeteriaOrderTest {

        CafeteriaOrder order;
        public DateTime past = new DateTime(2020, 7, 15);
        public static DateTime future = new DateTime(3020, 7, 15);
        public List<CafeteriaProduct> products = new List<CafeteriaProduct>();

        [TestInitialize]
        public void InitializeTest() {
            products.Add(new CafeteriaProduct(0, 0.5, future));
            order = new CafeteriaOrder(1, PaymentMethod.Online, past, OrderStatus.Accepted, products);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidIDNegative() {
            CafeteriaOrder badOrder = new CafeteriaOrder(-1, PaymentMethod.Online, past, OrderStatus.Accepted, products);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidOrderDateFuture() {
            CafeteriaOrder badOrder = new CafeteriaOrder(1, PaymentMethod.Online, future, OrderStatus.Accepted, products);
            Console.WriteLine("Finished");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.DataAnnotations.ValidationException))]
        public void InvalidProductsList() {
            List<CafeteriaProduct> products2 = new List<CafeteriaProduct>();
            CafeteriaOrder badOrder = new CafeteriaOrder(1, PaymentMethod.Online, past, OrderStatus.Accepted, products2);
            Console.WriteLine("Finished");
        }
    }

}
