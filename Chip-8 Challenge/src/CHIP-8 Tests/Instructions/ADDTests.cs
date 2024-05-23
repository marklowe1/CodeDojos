using CHIP_8_Virtual_Machine;
using CHIP_8_Virtual_Machine.Instructions;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHIP_8_Tests.Instructions
{
    [TestFixture]
    public class ADDTests
    {
        private VM _virtualMachine;
        private Register _register;
        private ADD _add;

        [SetUp]
        public void SetUp()
        {
            _virtualMachine = new VM();
            _register = new Register();

        }

        [TestCase(0x00)]
        [TestCase(0x01)]
        [TestCase(0x02)]
        [TestCase(0x03)]
        [TestCase(0x04)]
        [TestCase(0x05)]
        public void ADD_AddsValue(byte valueToAdd)
        {
            _add = new ADD(_register, valueToAdd);

            var expectedResult = new Register();
            expectedResult += valueToAdd;

            _add.Execute(_virtualMachine);

            Assert.That((Register)_virtualMachine.V[_register], Is.EqualTo(expectedResult));
        }
    }
}
