/*
Write function bmi that calculates body mass index (bmi = weight / height2).

if bmi <= 18.5 return "Underweight"

if bmi <= 25.0 return "Normal"

if bmi <= 30.0 return "Overweight"

if bmi > 30 return "Obese"
*/

//Solution
public class Kata
{
  public static string Bmi(double weight, double height)
  {
    double bmi = weight/(height*height);
    switch (bmi)
    {
        case <= 18.5:
        return "Underweight";
        case <= 25.0:
        return "Normal";
        case <= 30.0:
        return "Overweight";
        case > 30:
        return "Obese";
    }
    return "";
  }
}