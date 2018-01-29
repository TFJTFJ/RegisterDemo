using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace RegisterDemo.Test.Unit
{
    [TestFixture]
    class RegisterDemoUnitTest
    {
        [Test]
        public void Test1()
        {
            var uut = new Register();
            Assert.That(uut.GetNItems(), Is.Zero);
        }
    }
}
