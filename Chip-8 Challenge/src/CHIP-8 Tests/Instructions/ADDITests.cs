using CHIP_8_Virtual_Machine.Instructions;
using CHIP_8_Virtual_Machine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHIP_8_Tests.Instructions
{
    [TestFixture]
    public class ADDITests
    {
        private VM _virtualMachine;
        private Register _register;
        private ADDI _add;

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
        public void ADD_AddsValue(byte value)
        {
            _add = new ADDI(_register);
            _virtualMachine.I = new Tribble(value);

            var expectedResponse = new Tribble(value); 
            expectedResponse += _register;


            _add.Execute(_virtualMachine);

            Assert.That(_virtualMachine.I, Is.EqualTo(expectedResult));
        }
    }
}
