using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle;

namespace TriangleTest
{
    [TestFixture]
    class NUnitTest
    {
        [Test]
        public void AnalyzeTestMethod_ExpectedEquilateral() {
            Assert.AreEqual("It is Equilateral triangle",TriangleSolver.Analyze(5,5,5));
        }
        [Test]
        public void AnalyzeTestMethod_ExpectedIsoceles() {
            Assert.AreEqual("It is Isoceles triangle",TriangleSolver.Analyze(5,5,6));
        }
        [Test]
        public void AnalyzeTestMethod_ExpectedScalene() {
            Assert.AreEqual("It is Scalene triangle", TriangleSolver.Analyze(4, 5, 6));
        }
        [Test]
        public void AnalyzeTestMethod_ExpectedInvalid() {
            Assert.AreEqual("The values are invalid", TriangleSolver.Analyze(4,0,5));
        }
        [Test]
        public void AnalyzeTestMethod_Expected_Invalid() {
            Assert.AreEqual("The values are invalid", TriangleSolver.Analyze(-5,-5,-5));
        }     
    }
}
