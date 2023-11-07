using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please enter some words");
      String input = Console.ReadLine();

      String[] inputArray = input.Split(' ');

      Stack<String> stack = new Stack<String>();
      for (int i = 0; i < inputArray.Length; i++)
      {
        stack.Push(inputArray[i]);
      }

      while(stack.Count > 0)
        Console.WriteLine(stack.Pop());

      Console.ReadLine();
    }
  }
}
