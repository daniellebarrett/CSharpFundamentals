using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class InClassTypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            int age = 32;

            byte someByte = 23; //goes from 0-255

            int anotherNumber = 23;

            anotherNumber = 256;

            double someDouble = 23.4532234;
            float someFloat = 23.325423f;
            decimal someDecimal = 32.32414m;

            char letter = 'm';
            bool trueOrFalseValue = true;

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string randomCharacters = ";ljfkdajk a234312#@$@";

        }
    }
}