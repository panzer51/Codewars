/*
Clock shows h hours, m minutes and s seconds after midnight.

Your task is to write a function which returns the time since midnight in milliseconds.

Example:
h = 0
m = 1
s = 1

result = 61000
Input constraints:

0 <= h <= 23
0 <= m <= 59
0 <= s <= 59
*/

//Solution

  using System;
  public static class Clock
  {
    public static int Past(int h, int m, int s)
    {
         if (h < 0 || h >= 24 || m < 0 || m >= 60 || s < 0 || s >= 60)
    {
        throw new ArgumentException("Hours, minutes, and seconds must be non-negative numbers.");
    }
      
      int milliseconds = (h * 3600 + m * 60 + s) * 1000;
      return milliseconds;
      

  }
}