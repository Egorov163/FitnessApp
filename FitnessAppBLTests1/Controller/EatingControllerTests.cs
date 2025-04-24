using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessAppBL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAppBL.Controller.Tests
{
    [TestClass()]
    public class EatingControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            var userName = Guid.NewGuid().ToString();
            var userController = new UserController(userName);
            Assert.Fail();
        }
    }
}