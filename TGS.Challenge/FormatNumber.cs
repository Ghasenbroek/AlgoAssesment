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
    /// <summary>
    /// Formats the int value to a string with thousand separators
    /// </summary>
    /// <param name="value"></param>
    /// <returns>A string value that is thousand separated</returns>
    public string Format(int value)
    {
      if (value > 999999999 || value < 0)
      {
        throw new ArgumentOutOfRangeException();
      }
      var digitArray = ReverseValueToCharArray(value);     

      return GetFormattedString(digitArray);
    }

    /// <summary>
    /// Formats the char array to string with comma seperation
    /// </summary>
    /// <param name="digitArray"></param>
    /// <returns>A comma separated string</returns>
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

    /// <summary>
    /// Reverses the int value to a char array
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Reversed char array of value</returns>
    private char[] ReverseValueToCharArray(int value)
    {
      string stringValue = $"{value}";
      var digitArray = stringValue.ToCharArray();
      Array.Reverse(digitArray);
      return digitArray;
    }

  }
}
