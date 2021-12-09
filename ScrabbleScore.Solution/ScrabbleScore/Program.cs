using System;
using System.Collections.Generic;
using Score.Models;
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome, please enter a word with no spaces!");
    string choice = Console.ReadLine();
    Console.WriteLine(Scrabble.CalcScore(choice.ToLower()));
  }
}