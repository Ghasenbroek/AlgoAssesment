using System;

namespace TGS.Challenge
{
  /*
      Devise a function that takes a string & returns the number of 
      vowels (aeiou) in that string.

      "Hi there!" = 3
      "What do you mean?"  = 6

      There are accompanying unit tests for this exercise, ensure all tests pass & make
      sure the unit tests are correct too.
   */
  public class VowelCount
  {

    /// <summary>
    /// Counts the amount of vowels in a string
    /// </summary>
    /// <param name="value"></param>
    /// <returns>The count of vowels in the given value</returns>
    public int Count(string value)
    {
      if (value == string.Empty)
      {
        throw new ArgumentException();
      }
      var chars = value.ToLower().ToCharArray();
      return CountVowels(chars);
    }

    /// <summary>
    /// Counts the amount of vowels in a char array
    /// </summary>
    /// <param name="chars"></param>
    /// <returns>The count of vowels in the given char array</returns>
    private int CountVowels(char[] chars)
    {
      int vowelCounter = 0;
      foreach (var item in chars)
      {
        switch (item)
        {
          case 'a':
          case 'e':
          case 'i':
          case 'o':
          case 'u':
            vowelCounter += 1;
            break;
          default:
            break;
        }
      }
      return vowelCounter;
    }
  }
}
