﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using CommonInputValidations;

namespace UnitTestValidations
{

    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void IsValidPT()
        {
            Assert.That(CommonPT.IsPhoneNumberPT("289920456"), Is.EqualTo(true));
        }
    }
}
