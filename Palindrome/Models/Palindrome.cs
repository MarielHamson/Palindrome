using System;

namespace Palindromes
{
  public class Palindrome
  {
    public string Word { get; set; }
    public string ReverseWord { get; set; }
    public Palindrome(string word)
    {
      Word = word;
      ReverseWord = "";
    }
    public bool IsPalindrome()
    {
      // return this.Word is string;
      string[] wordArray = this.Word.Split();
      return false;
    }
  }
}
