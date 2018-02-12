using System;
using System.Text;

namespace ClockAngle
{
  public class Clock
  {
    private int _minutes;
    private int _hours;

    public Clock (int hour, int minute)
    {
      _minutes = minute;
      _hours = hour;
    }

    public double Angle ()
    {
      double totalMinutes = Convert.ToDouble(_hours * 60 + _minutes);
      double hourAngle = (.5 * totalMinutes) % 360.0;
      double minuteAngle = (6 * totalMinutes) % 360.0;
      double angle = Math.Abs (hourAngle - minuteAngle);
      if (angle > 180.0)
        {
          angle = 360 - angle;
        }
      return angle;
    }

  }
}
