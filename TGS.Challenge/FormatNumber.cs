using System;

namespace TGS.Challenge
{
  /*
      Devise a function that takes an input 'n' (integer) and returns a string that is the
      decimal representation of that number grouped by commas after every 3 digits. 

      NOTES: You cannot use any built-in formatting functions to complete this task.

      Assume: 0 <= n < 1000000000

      1 -> "1"
      10 -> "10"
      100 -> "100"
      1000 -> "1,000"
      10000 -> "10,000"
      100000 -> "100,000"
      1000000 -> "1,000,000"
      35235235 -> "35,235,235"

      There are accompanying unit tests for this exercise, ensure all tests pass & make
      sure the unit tests are correct too.
   */
  public class FormatNumber
  {
    public string Format(int value)
    {
      if (value > 999999999 || value < 0)
      {
        throw new ArgumentOutOfRangeException();
      }
      var digitArray = ReverseNumber(value);     

      return GetFormattedString(digitArray);
    }

    private string GetFormattedString(char[] digitArray)
    {
      string result = "";
      var digitCounter = 0;
      foreach (var digit in digitArray)
      {
        if (digitCounter != 0 && digitCounter % 3 == 0)
        {
          result = $",{result}";
        }
        digitCounter += 1;
        result = $"{digit}{result}";
      }
      return result;
    }

    private char[] ReverseNumber(int value)
    {
      string stringValue = $"{value}";
      var digitArray = stringValue.ToCharArray();
      Array.Reverse(digitArray);
      return digitArray;
    }

  }
}
