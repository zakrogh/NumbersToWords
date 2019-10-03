using System;
using System.Collections.Generic;
namespace NumbersToWords.Models
{
  public class Translator
  {
    public ulong Number { get; set; }
    public Dictionary<ulong, string> dictionary1 { get; set; } = new Dictionary<ulong, string>(){
      {1, "One"},
      {2, "Two"},
      {3, "Three"},
      {4, "Four"},
      {5, "Five"},
      {6, "Six"},
      {7, "Seven"},
      {8, "Eight"},
      {9, "Nine"}
    };
    public Dictionary<ulong, string> dictionary2 { get; set; } = new Dictionary<ulong, string>(){
      {10, "Ten"},
      {11, "Eleven"},
      {12, "Twelve"},
      {13, "Thirteen"},
      {14, "Fourteen"},
      {15, "Fifteen"},
      {16, "Sixteen"},
      {17, "Seventeen"},
      {18, "Eighteen"},
      {19, "Nineteen"}
    };
    public Dictionary<ulong, string> dictionary3 { get; set; } = new Dictionary<ulong, string>(){
      {20, "Twenty"},
      {30, "Thirty"},
      {40, "Fourty"},
      {50, "Fifty"},
      {60, "Sixty"},
      {70, "Seventy"},
      {80, "Eighty"},
      {90, "Ninety"}
    };
    public Dictionary<ulong, string> dictionary4 { get; set; } = new Dictionary<ulong, string>(){
      {100, "Hundred"},
      {1000, "Thousand"},
      {1000000, "Million"},
      {1000000000, "Billion"},
      {1000000000000, "Trillion"}
    };
    public Translator(ulong num)
    {
      Number = num;
    }
  }
}
