using System;
using System.Collections.Generic;
using NumbersToWords.Models;

namespace NumbersToWords
{
  public class Program
  {
    public static void Main()
    {
      Translator myTranslator = new Translator(10);
      foreach(KeyValuePair<ulong, string> item in myTranslator.dictionary1)
      {
        Console.WriteLine("{0}: {1}", item.Key, item.Value);
      }
      foreach(KeyValuePair<ulong, string> item in myTranslator.dictionary2)
      {
        Console.WriteLine("{0}: {1}", item.Key, item.Value);
      }
      foreach(KeyValuePair<ulong, string> item in myTranslator.dictionary3)
      {
        Console.WriteLine("{0}: {1}", item.Key, item.Value);
      }
      foreach(KeyValuePair<ulong, string> item in myTranslator.dictionary4)
      {
        Console.WriteLine("{0}: {1}", item.Key, item.Value);
      }

    }
  }
}
