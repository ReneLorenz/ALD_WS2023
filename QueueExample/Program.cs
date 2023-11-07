using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Queue<String> queue = new Queue<String>();
      while (true)
      {
        String input = Console.ReadLine();
        if(input.StartsWith("set "))
        {
          queue.Enqueue(input.Substring(4, input.Length-4));
        }
        else if (input.StartsWith("get all"))
        {
          while (queue.Count > 0)
            Console.WriteLine(queue.Dequeue());
        }
        else if(input.StartsWith("get"))
        {
          Console.WriteLine(queue.Dequeue());
        }
        else
        {

        }
      }
    }
  }
}
