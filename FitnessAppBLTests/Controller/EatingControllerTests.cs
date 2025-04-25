using System;
using System.Linq;
using FitnessAppBL.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var foodName = Guid.NewGuid().ToString();
            var random = new Random();
            var userController = new UserController(userName);
            var eatingController = new EatingController(userController.CurrentUser);
            var food = new Food(foodName,
                random.Next(50, 500),
                random.Next(50, 500),
                random.Next(50, 500),
                random.Next(50, 500));

            // Act
            eatingController.Add(food, 100);

            // Assert 
            Assert.AreEqual(food.Name, eatingController.Eating.Foods.First().Key.Name);
        }
    }
}