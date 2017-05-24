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
    [Category("ExerciseOne")]
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
        public void IfMailHasADotBeforeReturnFalse()
        {
            //Arrange
            var sut = new Validator();

            //Act
            var res=sut.ValidateEmailAddress("name.test@com");

            //Assert
            Assert.IsFalse(res);
        }

        [Test]
        public void IfMailEmptyReturnFalse()
        {
            //Arrange
            var sut=new Validator();

            Assert.Throws<ExceptionMadeBy>(() => { sut.ValidateEmailAddress(""); });

            ////Act
            //var res = sut.ValidateEmailAddress("");

            ////Assert
            //Assert.IsFalse(res);

        }

        [Test]
        public void IfMailNullReturnFalse()
        {
            var sut = new Validator();

            Assert.Throws<ExceptionMadeBy>(() => { sut.ValidateEmailAddress(""); });

            //var res = sut.ValidateEmailAddress(null);

            //Assert.IsFalse(res);
        }

        [Test]
        public void MethodThatThrowCustomException()
        {
            var sut = new Validator();

            Assert.Throws<ExceptionMadeBy>(() => { sut.ValidateEmailAddress(""); });
        }

    }
}
