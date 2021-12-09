using System;
using System.Collections.Generic;


namespace Score.Models
{
  public class Scrabble
  {
    public static int CalcScore(string input)
    {
      string str = input;      
      int score = 0;

      char[] arr = str.ToCharArray();
      foreach (char i in arr)
      {
        if (i.Equals('a') || i.Equals('e') || i.Equals('i') || i.Equals('o') || i.Equals('u') || i.Equals('l') || i.Equals('n') || i.Equals('r') || i.Equals('s') || i.Equals('t'))
        {
          score += 1;
        }
        else if (i.Equals('d') || i.Equals('g'))
        {
          score += 2;
        }
        else if (i.Equals('b') || i.Equals('c') || i.Equals('m') || i.Equals('p'))
        {
          score += 3;
        }
        else if (i.Equals('f') || i.Equals('h') || i.Equals('v') || i.Equals('w') || i.Equals('y'))
        {
          score += 4;
        }
        else if (i.Equals('k'))
        {
          score += 5;
        }
        else if (i.Equals('j') || i.Equals('x'))
        {
          score += 8;
        }
        else if (i.Equals('q') || i.Equals('z'))
        {
          score += 10;
        }
        else
        {
          score += 0;
          
        }
      }
      return score;
    }
  }
}