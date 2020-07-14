using System;

namespace Palindromes
{
  public class Palindrome
  {
    // public string Word { get; set; }
    // public string ReverseWord { get; set; }
    // public Palindrome(string word)
    // {
    //   Word = word;
    //   ReverseWord = "";
    // }
    // public bool IsArray()
    // {
    //   string[] WordArray = this.Word.Split();
    //   return WordArray is string[];
    // }
    public bool IsPalindrome(string Word) // "mom"
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
        return false;
      }
      else
      {
        return false;
      }
    }
  }
}
