using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brunner.OnlineShoppingCart.Service;
using Brunner.OnlineShoppingCart.Service.Model;
using System.Collections.Generic;
using Brunner.OnlineShopping.EnumsCollection;
namespace Brunner.OnlineShoppingCart.TestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPriceOnShoppingCartItemsWithOffer()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Customer = new Data.Entity.Customer() { Id = 1, Name = "Mark" };
            List<CartItems> lst = new List<CartItems> { new CartItems(){ Id=1, Price=0.45M, Product = ProductLookUp.Apple, Qty=3},
             new CartItems(){ Id=2, Price=0.65M, Product = ProductLookUp.Orange, Qty=3}
            };
            cart.Items = lst;
            CheckOutService service = new CheckOutService();
            service.CheckOut(cart, true);
            Decimal expectedResult = 2.2M;
            Assert.AreEqual(expectedResult, cart.Total);

        }

        [TestMethod]
        public void GetPriceOnShoppingCartItemsWithOutOffer()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Customer = new Data.Entity.Customer() { Id = 1, Name = "Mark" };
            List<CartItems> lst = new List<CartItems> { new CartItems(){ Id=1, Price=0.45M, Product = ProductLookUp.Apple, Qty=3},
             new CartItems(){ Id=2, Price=0.65M, Product = ProductLookUp.Orange, Qty=3}
            };
            cart.Items = lst;
            CheckOutService service = new CheckOutService();
            service.CheckOut(cart, false);
            Decimal expectedResult = 3.3M;
            Assert.AreEqual(expectedResult, cart.Total);

        }

        [TestMethod]
        public void GetPriceForOrangeOnlyWithOffer()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Customer = new Data.Entity.Customer() { Id = 1, Name = "Mark" };
            List<CartItems> lst = new List<CartItems> {  new CartItems(){ Id=2, Price=0.65M, Product = ProductLookUp.Orange, Qty=3}
             
            };
            cart.Items = lst;
            CheckOutService service = new CheckOutService();
            service.CheckOut(cart, true);
            Decimal expectedResult = 1.30M;
            Assert.AreEqual(expectedResult, cart.Total);

        }

        [TestMethod]
        public void GetPriceForOrangesOnlyWithOutOffer()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Customer = new Data.Entity.Customer() { Id = 1, Name = "Mark" };
            List<CartItems> lst = new List<CartItems> {  new CartItems(){ Id=2, Price=0.65M, Product = ProductLookUp.Orange, Qty=3}
             
            };
            cart.Items = lst;
            CheckOutService service = new CheckOutService();
            service.CheckOut(cart, false);
            Decimal expectedResult = 1.95M;
            Assert.AreEqual(expectedResult, cart.Total);

        }

        [TestMethod]
        public void GetPriceForApplesOnlyWithOffer()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Customer = new Data.Entity.Customer() { Id = 1, Name = "Mark" };
            List<CartItems> lst = new List<CartItems> { new CartItems(){ Id=1, Price=0.45M, Product = ProductLookUp.Apple, Qty=3}
             
            };
            cart.Items = lst;
            CheckOutService service = new CheckOutService();
            service.CheckOut(cart, true);
            Decimal expectedResult = 0.9M;
            Assert.AreEqual(expectedResult, cart.Total);

        }

        [TestMethod]
        public void GetPriceForApplesOnlyWithOutOffer()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Customer = new Data.Entity.Customer() { Id = 1, Name = "Mark" };
            List<CartItems> lst = new List<CartItems> { new CartItems(){ Id=1, Price=0.45M, Product = ProductLookUp.Apple, Qty=3}
             
            };
            cart.Items = lst;
            CheckOutService service = new CheckOutService();
            service.CheckOut(cart, false);
            Decimal expectedResult = 1.35M;
            Assert.AreEqual(expectedResult, cart.Total);

        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void GetPriceWithNullItemsWithOffer()
        {
            ShoppingCart cart = new ShoppingCart();
            CheckOutService service = new CheckOutService();
            service.CheckOut(null, true);
            Decimal expectedResult = 0.0M;
            Assert.AreEqual(expectedResult, cart.Total);

        }

    }
}
