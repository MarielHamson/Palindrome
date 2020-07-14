using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    // [TestMethod]
    // public void IsPalindrome_ReturnString_True()
    // {
    //   Palindrome testString = new Palindrome("apple");
    //   Assert.AreEqual(true, testString.IsPalindrome());
    // }

    [TestMethod]
    public void IsPalindrome_ReturnArray_True()
    {
      Palindrome testString = new Palindrome();
      Assert.AreEqual(true, testString.IsPalindrome("apple"));
    }

    [TestMethod]
    public void IsPalindrome_ReversesArray_True()
    {
      Palindrome testString = new Palindrome();
      Assert.AreEqual(true, testString.IsPalindrome("mom"));
    }
  }
}


// Assert.AreEqual(true, testPalindrome.GetWordArray == string[] { "A"..."e" })