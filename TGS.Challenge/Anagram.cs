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
		private static readonly List<char> SpecialChars = new List<char> { '+', '&', '|', '!', '(', ')', '{', '}', '[', ']', '^', '~', '*', '?', ':', '\\', '/', '_', ' ' };
		
		public bool AreAnagrams(string first, string second)
		{
			try
			{
				var firstCharArray = RemoveChars(first);
				var secondCharArray = RemoveChars(second);

				Array.Sort<char>(firstCharArray);
				Array.Sort<char>(secondCharArray);

				return string.Equals(new string(firstCharArray), new string(secondCharArray));
			}
			catch (Exception e)
			{
				throw new ArgumentException();
			}
		}

		public char[] RemoveChars(string word)
		{
			if (word == string.Empty)
			{
				throw new ArgumentException();
			}
			foreach (var character in SpecialChars)
			{
				if (word.Contains(character))
				{
					word = word.Replace(character.ToString(), "");
				}
			}

			return word.ToLower().ToCharArray();
		}
	}
}
