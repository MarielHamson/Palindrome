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
    public bool IsPalindrome(string Word)
    {
      string[] WordArray = Word.Split();
      return WordArray is string[];
    }
  }
}

// Assert.AreEqual(28, _actualFuel); // Tests whether the specified values are equal. 
// Assert.IsInstanceOfType(_actualRocket, typeof(Falcon9Rocket)); // Tests whether the specified object is an instance of the expected type