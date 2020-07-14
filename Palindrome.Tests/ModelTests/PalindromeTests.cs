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
    public void IsArray_ReturnArray_True()
    {
      Palindrome testString = new Palindrome();
      Assert.AreEqual(true, testString.IsPalindrome("apple"));
    }
  }
}


// Assert.AreEqual(true, testPalindrome.GetWordArray == string[] { "A"..."e" })