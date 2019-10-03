using System;
using System.Collections.Generic;
using NumbersToWords.Models;

namespace NumbersToWords
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Numbers to Words!");
      Console.WriteLine("Enter a number to translate:");
      long input = long.Parse(Console.ReadLine());
      Translator myTranslator = new Translator(input);
      // 16
      // foreach(KeyValuePair<long, string> item in myTranslator.dictionary1)
      // {
      //   string dictionary1Input = item.Key + item.Value;
      //   Console.WriteLine("dictionary1Input: {0}", dictionary1Input);
      // }
      // foreach(KeyValuePair<long, string> item in myTranslator.dictionary2)
      // {
      //   Console.WriteLine("{0}: {1}", item.Key, item.Value);
      // }
      // foreach(KeyValuePair<long, string> item in myTranslator.dictionary3)
      // {
      //   Console.WriteLine("{0}: {1}", item.Key, item.Value);
      // }
      // foreach(KeyValuePair<long, string> item in myTranslator.dictionary4)
      // {
      //   // Console.ReadLine("{0}: {1}", item.Key, item.Value);
      // }
      // 50214
      //4, 1, 2, 0, 5
      // string word;
      // string output;
      // myTranslator.dictionary1.TryGetValue(2, out word);
      // output = word + " ";
      // myTranslator.dictionary4.TryGetValue(1000, out word);
      // output += word + " ";
      // myTranslator.dictionary2.TryGetValue(19, out word);
      // output += word;
      // Console.WriteLine(output);
      Console.WriteLine(myTranslator.ParseData());
    }
  }
}
