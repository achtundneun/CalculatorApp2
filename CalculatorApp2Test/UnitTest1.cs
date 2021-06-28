using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorApp2;

namespace CalculatorApp2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSumm32and23res55()
        {
            // arrenge
            double num_1 = 32;
            double num_2 = 23;
            double ex = 55;
            // act
            double res = SimpleMath.Summ(num_1, num_2);
            // asseret
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodSumm11and56res67()
        {
            double num_1 = 11;
            double num_2 = 56;
            double ex = 67;

            double res = SimpleMath.Summ(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodSumm41and66res118()
        {
            double num_1 = 41;
            double num_2 = 66;
            double ex = 118;

            double res = SimpleMath.Summ(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodDivision25and5res2()
        {
            double num_1 = 25;
            double num_2 = 5;
            double ex = 2;

            double res = SimpleMath.Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodDivision35and7res5()
        {
            double num_1 = 35;
            double num_2 = 7;
            double ex = 5;

            double res = SimpleMath.Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodDivision100and10res10()
        {
            double num_1 = 100;
            double num_2 = 10;
            double ex = 10;

            double res = SimpleMath.Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

       
        [TestMethod]
        public void TestMethodSubtraction13and5res6()
        {
            double num_1 = 13;
            double num_2 = 5;
            double ex = 6;

            double res = SimpleMath.Subtraction(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodSubtraction22and5res17()
        {
            double num_1 = 22;
            double num_2 = 5;
            double ex = 17;

            double res = SimpleMath.Subtraction(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodSubtraction69and43res26()
        {
            double num_1 = 69;
            double num_2 = 43;
            double ex = 26;

            double res = SimpleMath.Subtraction(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodMultiplication4and40res80()
        {
            double num_1 = 4;
            double num_2 = 40;
            double ex = 80;

            double res = SimpleMath.Multiplication(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodMultiplication15and8res120()
        {
            double num_1 = 15;
            double num_2 = 8;
            double ex = 120;

            double res = SimpleMath.Multiplication(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodMultiplication6and6res36()
        {
            double num_1 = 6;
            double num_2 = 6;
            double ex = 36;

            double res = SimpleMath.Multiplication(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodReminderDivision11and5res1()
        {
            double num_1 = 11;
            double num_2 = 5;
            double ex = 1;

            double res = SimpleMath.Remainder_Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodReminderDivision12and7res5()
        {
            double num_1 = 12;
            double num_2 = 7;
            double ex = 5;

            double res = SimpleMath.Remainder_Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodReminderDivision30and16res5()
        {
            double num_1 = 30;
            double num_2 = 16;
            double ex = 5;

            double res = SimpleMath.Remainder_Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
    }


}