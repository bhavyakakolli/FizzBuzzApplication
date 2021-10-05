using FizzBuzzApplication.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzzUnitTestProject
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void isMultipleOf3Pass()
      {
         string expectedResult = "Fizz";
         string originalResult = "";
         originalResult = FizzBuzzController.getValue("3");
         Assert.AreEqual(expectedResult, originalResult);
      }
      [TestMethod]
      public void isMultipleOf5Pass()
      {
         string expectedResult = "Buzz";
         string originalResult = "";
         originalResult = FizzBuzzController.getValue("10");
         Assert.AreEqual(expectedResult, originalResult);
      }
      [TestMethod]
      public void isMultipleOf3And5Pass()
      {
         string expectedResult = "FizzBuzz";
         string originalResult = "";
         originalResult = FizzBuzzController.getValue("15");
         Assert.AreEqual(expectedResult, originalResult);
      }
      [TestMethod]
      public void invalidCharValuePass()
      {
         string expectedResult = "Invalid Item";
         string originalResult = "";
         originalResult = FizzBuzzController.getValue("A");
         Assert.AreEqual(expectedResult, originalResult);
      }
      [TestMethod]
      public void invalidEmptyValuePass()
      {
         string expectedResult = "Invalid Item";
         string originalResult = "";
         originalResult = FizzBuzzController.getValue("");
         Assert.AreEqual(expectedResult, originalResult);
      }
      [TestMethod]
      public void isMultipleof3Or5Faill()
      {
         string expectedResult = "";
         string originalResult = "";
         originalResult = FizzBuzzController.getValue("23");
         Assert.AreEqual(expectedResult, originalResult);
      }
   }
}
