using System;

namespace Palindromes
{
  public class Palindrome
  {
    public bool IsPalindrome(string Word)
    {
      string[] WordArray = Word.Split();
      string[] ReverseArray = Word.Split();
      Array.Reverse(ReverseArray);
      int MatchingLetterCount = 0;

      for (int index = 0; index < ReverseArray.Length; index++)
      {
        if (ReverseArray[index] == WordArray[index])
        {
          MatchingLetterCount++;
        }
      }

      if (MatchingLetterCount == ReverseArray.Length)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
