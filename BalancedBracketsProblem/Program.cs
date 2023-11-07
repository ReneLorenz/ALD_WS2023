using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBracketsProblem
{
  internal class Program
  {

    static bool isSymmetric(String input)
    {
      char[] inputArray = input.ToCharArray();
      Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();
      keyValuePairs.Add('}', '{');
      keyValuePairs.Add(')', '(');
      keyValuePairs.Add('>', '<');
      keyValuePairs.Add(']', '[');

      Stack<char> stack = new Stack<char>();
      for (int i = 0; i < inputArray.Length; i++)
      {
        if (keyValuePairs.ContainsValue(inputArray[i]))
        {
          stack.Push(inputArray[i]);
        }
        else if (keyValuePairs.ContainsKey(inputArray[i]))
        {
          if (stack.Peek().Equals(keyValuePairs[inputArray[i]]))
          {
            stack.Pop();
          }
          else
          {
            //error
            return false;
          }
        }
        else
        {
          //ignore
        }
      }

      return stack.Count == 0;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("please input");
      String input = Console.ReadLine();


      if (isSymmetric(input))
      {
        Console.WriteLine("Input is symmetric");
      } 
      else
      {
        Console.WriteLine("Input is NOT symmetric");
      }


      Console.Read();
    }
  }
}
