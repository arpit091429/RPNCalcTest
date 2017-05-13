using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RPNCalcTest
{
  [TestFixture]
  class RPNCalcexp
  {
    [Test]
    public void TestCase1()
      {
      RPNCalc RPNCalc = new RPNCalc();
      Assert.AreEqual(4 , RPNCalc.AddTwoNumber("2,2,+"));
      }
 
    //public void TestCase2()
    //{

    //}
  }
}
