using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            // Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;

            short smallWholeNumber = 16;
            Int16 anotherSmallNumber = 16; //Int16
            int wholeNumber = 32;           //Int32
            long largeWholeNumber = 64;     //Int64

            int newNumber = oneBytesWorth;

            // Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.2346543;
            decimal decimalExample = 1.70000m;

            //Character
            char letter = 'j';

            //Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int dif = numOne - numTwo;
            Console.WriteLine(dif);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo; //17 / 5 = 3 ??
            Console.WriteLine(quot);
            int remainder = numOne % numTwo; // 17 % 5 = 2
            Console.WriteLine(remainder);

            Console.WriteLine("hello");

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //Strings
            string stringExample = "This is a string."; //declare and initialize
            string name = "Danielle";

            string declared;
            declared = "Now it's initialized.";

            //Formatting strings
            string concatenate = stringExample + " " + name;                         // This is a string. Danielle
            string interpolate = $"{name}. Here is the string: {stringExample}"; // Danielle. here is the string: This is a string.

            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

                //Other Object Examples
            DateTime now = DateTime.Now; //shows date time for when this portion of the code executes
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomDate - now; //shows a time interval
            Console.WriteLine(waitTime.TotalSeconds);

            //Collections
            //Arrays
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" }; //string values without predetermined values go in quotes
            string[] students = new string[15]; //student array has 15 spots. can never have 14 or 16. can use blank value in spot though

            Console.WriteLine(stringArray);


            //Lists
            System.Collections.Generic.List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('d', "Danielle");

            //Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();

        }
    }
}
