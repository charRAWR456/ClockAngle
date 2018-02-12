using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle;

namespace ClockAngle.Tests
{
  [TestClass]
  public class ClockAngleTest
  {
    [TestMethod]
    public void AngleCorrect_Angle0AtNoon_true()
    {
      Clock testClock = new Clock(12,0);
      Assert.AreEqual(0.0, testClock.Angle());
    }
    [TestMethod]
    public void AngleCorrect_Angle180AtSix_true()
    {
      Clock testClock = new Clock(6,0);
      Assert.AreEqual(180.0, testClock.Angle());
    }
    [TestMethod]
    public void AngleCorrect_Angle90AtThree_true()
    {
      Clock testClock = new Clock(3,0);
      Assert.AreEqual(90.0, testClock.Angle());
    }
    [TestMethod]
    public void AngleCorrect_Angle90AtNine_true()
    {
      Clock testClock = new Clock(9,0);
      Assert.AreEqual(90.0, testClock.Angle());
    }
    [TestMethod]
    public void AngleCorrect_Angle15AtSixThirty_true()
    {
      Clock testClock = new Clock(6,30);
      Assert.AreEqual(15.0, testClock.Angle());
    }
    [TestMethod]
    public void AngleCorrect_Angle165AtTwelveThirty_true()
    {
      Clock testClock = new Clock(12,30);
      Assert.AreEqual(165.0, testClock.Angle());
    }

  }
}
