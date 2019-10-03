using System;
using System.Collections.Generic;
namespace NumbersToWords.Models
{
  public class Translator
  {
    public long Number { get; set; }
    public Dictionary<long, string> dictionary1 { get; set; } = new Dictionary<long, string>(){
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
    public Dictionary<long, string> dictionary2 { get; set; } = new Dictionary<long, string>(){
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
    public Dictionary<long, string> dictionary3 { get; set; } = new Dictionary<long, string>(){
      {10, "Ten"},
      {20, "Twenty"},
      {30, "Thirty"},
      {40, "Fourty"},
      {50, "Fifty"},
      {60, "Sixty"},
      {70, "Seventy"},
      {80, "Eighty"},
      {90, "Ninety"}
    };
    public Dictionary<long, string> dictionary4 { get; set; } = new Dictionary<long, string>(){
      {100, "Hundred"},
      {1000, "Thousand"},
      {1000000, "Million"},
      {1000000000, "Billion"},
      {1000000000000, "Trillion"}
    };
    public Translator(long num)
    {
      Number = num;
    }
    public string ParseData()
    {
      Stack<long> myStack = new Stack<long>();
      char[] numArr = Number.ToString().ToCharArray();
      for(int i = numArr.Length - 1; i >= 0; i--)
      {
        myStack.Push(Convert.ToInt64(Char.GetNumericValue(numArr[i])));
      }
      int count = myStack.Count;
      string output = "";
      string word;
      // for(int j = 0; j < count; j++)
      // {
      //   Console.WriteLine(myStack.Pop());
      // }
      while(count > 0)
      {
        word = "";
        long num = 0;
        switch(count)
        {
          case 15:
            num = myStack.Pop();
            dictionary1.TryGetValue(num, out word);
            output += word + " " + "Hundred" + " ";
            break;
          case 14:
            num = myStack.Pop();
            dictionary3.TryGetValue(num * 10, out word);
            output += word + " ";
            break;
          case 13:
            num = myStack.Pop();
            dictionary1.TryGetValue(num, out word);
            output += word + " " + "Trillion" + " ";
            break;
          case 12:
            num = myStack.Pop();
            dictionary1.TryGetValue(num, out word);
            output += word + " " + "Hundred" + " ";
            break;
          case 11:
            num = myStack.Pop();
            dictionary3.TryGetValue(num * 10, out word);
            output += word + " ";
            break;
          case 10:
            num = myStack.Pop();
            dictionary1.TryGetValue(num, out word);
            output += word + " " + "Billion" + " ";
            break;
          case 9:
            num = myStack.Pop();
            dictionary1.TryGetValue(num, out word);
            output += word + " " + "Hundred" + " ";
            break;
          case 8:
            num = myStack.Pop();
            dictionary3.TryGetValue(num * 10, out word);
            output += word + " ";
            break;
          case 7:
            num = myStack.Pop();
            dictionary1.TryGetValue(num, out word);
            output += word + " " + "Million" + " ";
            break;
          case 6:
            num = myStack.Pop();
            dictionary1.TryGetValue(num, out word);
            output += word + " " + "Hundred" + " ";
            break;
          case 5:
            num = myStack.Pop();
            dictionary3.TryGetValue(num * 10, out word);
            output += word;
            break;
          case 4:
            num = myStack.Pop();
            dictionary1.TryGetValue(num, out word);
            output += word + " " + "Thousand" + " ";
            break;
          case 3:
            num = myStack.Pop();
            dictionary1.TryGetValue(num, out word);
            output += word + " " + "Hundred" + " ";
            break;
          case 2:
            num = myStack.Pop();
            if(num > 1)
            {
              dictionary3.TryGetValue(num * 10, out word);
              output += word + " ";
            }
            else if( num == 0)
            {}
            else if(num == 1 && myStack.Peek() == 0)
            {
              dictionary3.TryGetValue(10, out word);
              output += word;
            }
            else
            {
              num = myStack.Pop();
              dictionary2.TryGetValue(num + 10, out word);
              output += word;
            }
            break;
          case 1:
            num = myStack.Pop();
            dictionary1.TryGetValue(num, out word);
            output += word;
            break;

        }
        count = myStack.Count;
      }
      return output;
    }
  }
}
