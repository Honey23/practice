using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using practice.Controllers;

namespace practice.Tests.Controllers
{
    [TestClass]
    public class itemContTest
    {
        // global variables for multiple test in this class
        itemsController controller;
        Mock<IitemsMock> mock;
        List<item> items;

        [TestInitialize]

        public void TestInitialize()
        {
            // this method runs automatically
            // create a new mock data object to hold fake list data
            mock = new Mock<IitemsMock>();

            //populate mock data
            items = new List<item>
            {
                new item {item_id = 100, item_name = "new book", item_price = 200, item_quantity = 2},
                new item {item_id = 101, item_name = "rent book", item_price = 100, item_quantity = 1},
                new item {item_id = 101, item_name = "old book", item_price = 100, item_quantity = 1}
            };

            //put list into the mock object and pass
            mock.Setup(m => m.items).Returns(items.AsQueryable());
            controller = new itemsController(mock.Object);
        }

        [TestMethod]
        public void IndexLoadsView()
        {
            //now moved to test initialize
            //arrange
            // itemsController controller = new itemsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            //assert
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]

        public void IndexReturnitems()
        {
            //act
            var result = (List<item>)((ViewResult)controller.Index()).Model;

            //assert
            CollectionAssert.AreEqual(items, result);
        }
    }
}
