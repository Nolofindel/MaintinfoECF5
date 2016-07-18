using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaintinfoMVC.Controllers;
using System.Web.Mvc;
using MaintinfoBo;
namespace MaintinfoMVC.Tests.Controllers
{
    [TestClass]
    public class BonDeCommandeControllerTest
    {
        [TestMethod]
        public void TestMethodIndex()
        {
            // Arrange
            BonDeCommandesController controller = new BonDeCommandesController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethodCreate()
        {
            // Arrange
            BonDeCommandesController controller = new BonDeCommandesController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodEdit()
        {
            // Arrange
            BonDeCommandesController controller = new BonDeCommandesController();
            // Act
            ViewResult result = controller.Edit(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetails()
        {
            // Arrange
            BonDeCommandesController controller = new BonDeCommandesController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
