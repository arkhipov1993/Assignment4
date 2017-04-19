using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4;
using NUnit.Framework;


namespace Assignment4.Test
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void NonIntegerValues() // User types the Non Inneger Values
        {
            float a=1.2F;
            float b=1.4F;
            float c=1.3F;
            string expected = "The triangle is SCALENE\n";
            string actual = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SumOfTwoLessThanThird() // The sum of two sides Less than the third one
        {
            float a = 1;
            float b = 2;
            float c = 4;
            string expected = "Triangle doesn't exist, try again\n";
            string actual = TriangleSolver.Validation(1, a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SumOfTwoEqualToThird() //The sum of two sides are equal the third one
        {
            float a = 1;
            float b = 2;
            float c = 3;
            string expected = "Triangle doesn't exist, try again\n";
            string actual = TriangleSolver.Validation(1, a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void NegativeValue() //Prevent user typing negative value
        {
            float a = -1;
            float b = 2;
            float c = 2;
            string expected = "Triangle doesn't exist, try again\n";
            string actual = TriangleSolver.Validation(1, a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OneZeroValue() // The case when user types on zero value 
        {
            float a = 0;
            float b = 3;
            float c = 2;
            string expected = "Triangle doesn't exist, try again\n";
            string actual = TriangleSolver.Validation(1, a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Isosceles() //The case when triangle is ISOSCELES
        {
            float a = 2;
            float b = 2;
            float c = 3;
            string expected = "The triangle is ISOSCELES\n";
            string actual = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expected, actual);    
        }
        [Test]
        public void Equilateral() //The case when triangle is EQUILATERAL 
        {
            float a = 2;
            float b = 2;
            float c = 2;
            string expected = "The triangle is EQUILATERAL\n";
            string actual = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expected, actual);     
        }
        [Test]
        public void Scalene() //The case when the triangle is Scalene
        {
            float a = 2;
            float b = 3;
            float c = 4;
            string expected = "The triangle is SCALENE\n";
            string actual = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expected, actual);
        }  
    }
}
