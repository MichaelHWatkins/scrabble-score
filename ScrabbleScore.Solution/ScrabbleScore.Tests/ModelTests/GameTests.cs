using System;
using System.Collections.Generic;
using Score.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Score.TestTools{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void ScrabbleString_CreatesInstanceOfString_String()
    {
      String newString = new String("test");
      Assert.AreEqual(typeof(String), newString.GetType());
    }
    [TestMethod]

    public void CalcScore_CalculatesScrabbleScore_True()
    {
      string newString = "ae";
      int totalScore = Scrabble.CalcScore(newString);
      Console.WriteLine(totalScore);
      int expectedNum = 2;
      Assert.AreEqual(totalScore, expectedNum);
    }
  }
}