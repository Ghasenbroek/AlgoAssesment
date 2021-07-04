using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
	/*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        'Anagram': An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams('horse', 'shore') should return true
        areAnagrams('horse', 'short') should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
	public class Anagram
	{
		private static readonly List<char> _SpecialChars = new List<char> { '+', '&', '|', '!', '(', ')', '{', '}', '[', ']', '^', '~', '*', '?', ':', '\\', '/', '_', ' ' };

		/// <summary>
		/// Checks to see if two strings are Anagrams of one another
		/// </summary>
		/// <param name="firstAnagram"></param>
		/// <param name="secondAnagram"></param>
		/// <returns>Boolean</returns>
		public bool AreAnagrams(string firstAnagram, string secondAnagram)
		{
			try
			{
				AreAnagramsValid(firstAnagram, secondAnagram);
				var firstCharArray = RemoveSpecialCharacters(firstAnagram);
				var secondCharArray = RemoveSpecialCharacters(secondAnagram);

				return string.Equals(new string(firstCharArray), new string(secondCharArray));
			}
			catch (Exception)
			{
				throw new ArgumentException();
			}
		}

		/// <summary>
		/// Removes Special Characters and sorts the array
		/// </summary>
		/// <param name="word"></param>
		/// <returns>A sorted Character array</returns>
		private char[] RemoveSpecialCharacters(string word)
		{
			foreach (var character in _SpecialChars)
			{
				if (word.Contains(character))
				{
					word = word.Replace(character.ToString(), string.Empty);
				}
			}
			var result = word.ToLower().ToCharArray();
			Array.Sort<char>(result);

			return result;
		}

		/// <summary>
		/// Checks if both Anagrams are valid
		/// </summary>
		/// <param name="firstAnagram"></param>
		/// <param name="secondAnagram"></param>
		private void AreAnagramsValid(string firstAnagram, string secondAnagram)
    {
			if (firstAnagram == string.Empty || secondAnagram == string.Empty)
			{
				throw new ArgumentException();
			}
		}
	}
}
