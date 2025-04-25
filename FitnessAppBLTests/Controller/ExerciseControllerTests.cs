using System;
using System.Linq;
using FitnessAppBL.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitnessAppBL.Controller.Tests
{
    [TestClass()]
    public class ExerciseControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            var userName = Guid.NewGuid().ToString();
            var activityName = Guid.NewGuid().ToString();
            var random = new Random();
            var userController = new UserController(userName);
            var exerciseController = new ExerciseController(userController.CurrentUser);
            var activity = new Activity(activityName, random.Next(10, 50));

            // Act
            exerciseController.Add(activity, DateTime.Now, DateTime.Now.AddHours(1));

            // Assert 
            Assert.AreEqual(activityName, exerciseController.Activities.First().Name);
        }
    }
}