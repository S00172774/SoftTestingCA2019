using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAssignment;

namespace TestingAssignment
{
    public class TestClass
    {
        static double expectedOutcome;
        static Program.InsuranceService p1;

        [SetUp]
        public static void Init()
        {
            p1 = new Program.InsuranceService();
        }
        [Test]
        public static void Test1()
        {
            expectedOutcome = 6;
            double outcome;
        }
    }
}
