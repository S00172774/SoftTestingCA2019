using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 
using TestingAssignment; // reference to test basis

namespace ClassLibrary1
{
    [TestFixture]
    public class TestClass
    {
        static int myExpectedResult;
        static Program p1;

        [SetUp] // code here is executed before tests are executed
        public static void Init()
        {
            p1 = new Program();
        }

        [Test]
        public static void Test1()
        {
            myExpectedResult = 9; // what my code should be returning
            int actualResult = p1.Add(4, 5);
            Assert.AreEqual(myExpectedResult, actualResult);
        }
        // paramaterised test – allows us group a bunch of tests
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(-1, 10, ExpectedResult = 9)]
        [TestCase(5, 15, ExpectedResult = 20)]

        public int Test2(int a, int b)
        {
            int actualResult = p1.Add(a, b);
            return actualResult;
        }
        [Test]
        public void CheckingRange()
        {
            Assert.IsTrue(p1.CheckRange(5));
        }
        [Test]
        public void PassingOutOfRangeValueCausesAnException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { p1.CheckRange(43); });
        }
    }

