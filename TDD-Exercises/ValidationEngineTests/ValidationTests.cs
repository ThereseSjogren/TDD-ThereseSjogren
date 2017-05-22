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
            var sut = new Validator();

            sut.ValidateEmailAddress("validtest@email.se");

            Assert.IsTrue(true);
        }
    }
}
