using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLibTests
{
    [TestClass]
    public class PasswordCheckerTests
    {
        private const string Password5point = "Pt231#@1";
        private const string Password3point = "PtirPtir";
        private const string Password5pointSpecialChar = "Ptir0@@Ptir";

        [TestMethod]
        public void GetPasswordStrength_AllChars_5Points()
        {
            var expected = 5;
            var actual = PasswordChecker.GetPasswordStrength(Password5point);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_UpperCase_3Points()
        {
            var expected = 3;
            var actual = PasswordChecker.GetPasswordStrength(Password3point);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_5Points()
        {
            var expected = 5;
            var actual = PasswordChecker.GetPasswordStrength(Password5pointSpecialChar);
            Assert.AreEqual(expected, actual);
        }
    }
}