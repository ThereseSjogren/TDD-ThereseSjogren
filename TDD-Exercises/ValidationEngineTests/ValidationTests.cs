using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ValidationEngine;

namespace ValidationEngineTests
{
    [TestFixture]
    public class ValidationTests
    {

        [Test]
        public void TrueForValidAddress()
        {
            //Arrange
            var sut = new Validator();

            //Act
            var res=sut.ValidateEmailAddress("validtest@email.se");
 
            //Assert
            Assert.IsTrue(res);
        }

        [Test]
        public void CheckWhatHappensIfInvalidCasesReturnFalse()
        {
            //Arrange
            var sut = new Validator();

            //Act
            var res=sut.ValidateEmailAddress("something");

            //Assert
            Assert.IsFalse(res);
        }

        [Test]
        public void IfMailEmptyReturnFalse()
        {
            var sut=new Validator();

            var res = sut.ValidateEmailAddress("");

            Assert.IsFalse(res);
        }

        
    }
}
