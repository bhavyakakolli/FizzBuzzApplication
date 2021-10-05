using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzzApplication.Models;

namespace FizzBuzzApplication.Controllers
{
   public class FizzBuzzController : Controller
   {
      // GET: FizzBuzz
      public ActionResult Index()
      {
         string[] sampleArray = {"1", "3", "5", "", "15", "A", "23" };

         List<FizzBuzzResult> value = getResultSet(sampleArray);
       

         return View(value);
      }

      public List<FizzBuzzResult> getResultSet(Array sampleArray)
      {
         List<FizzBuzzResult> resultSet = new List<FizzBuzzResult>();

         foreach (string value in sampleArray)
         {
            FizzBuzzResult record = new FizzBuzzResult();
            record.input = value;
            
            if(getValue(value)!="")
            {
               record.output = getValue(value);
            }
            else
            {
               string[] outputMultiArray = { "Divided " + record.input + " by 3" , "Divided " + record.input + " by 5" };
               record.multiOutput = outputMultiArray;
            }
            
            resultSet.Add(record);
         }
         return resultSet;
      }
      //Return expected string result based on input value
      public static string getValue(string value)
      {
         string result = "";
         if (!value.Any(Char.IsDigit))
            result = "Invalid Item";
         else
         {
            int number = Int32.Parse(value);
            if (isMultipleOf3(number) && isMultipleOf5(number))
               result = "FizzBuzz";
            else if (isMultipleOf3(number))
               result = "Fizz";
            else if (isMultipleOf5(number))
               result = "Buzz";
            else
               result = "";
         }
         return result;
      }
      //Return booloean value if provided input is multiple of 3
      public static bool isMultipleOf3(int number)
      {
         if (number % 3 == 0)
            return true;
         else
            return false;
      }
      //Return booloean value if p5ovided input is multiple of 3
      public static bool isMultipleOf5(int number)
      {
         if (number % 5 == 0)
            return true;
         else
            return false;
      }
   }
}