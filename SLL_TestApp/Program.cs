using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL_TestApp
{

  internal class Helicopter
  {
    int id;
    public Helicopter(int id)
    {
      this.id = id;
    }


    public override bool Equals(object obj)
    {
      var heli = obj as Helicopter;
      if (heli == null) return false;

      return heli.id == this.id;
    }

  }

  internal class Program
  {
    static void Main(string[] args)
    {
      SinglyLinkedList.SinglyLinkedList<int> myList = new SinglyLinkedList.SinglyLinkedList<int>();
      myList.Add(1);
      myList.Add(2);
      myList.Add(3);
      myList.Add(3);
      myList.Add(4);

      foreach(int i in myList)
      { 
        System.Console.WriteLine(i);
      }

      List<int> list = new List<int>();

      foreach (int i in myList)
      {
        System.Console.WriteLine(i);
      }


      bool exist = myList.Contains(3);


      while (myList.Remove(3)) { }

      exist = myList.Contains(3);

      SinglyLinkedList.SinglyLinkedList<Helicopter> helis = new SinglyLinkedList.SinglyLinkedList<Helicopter>();
      Helicopter a = new Helicopter(1);
      Helicopter b = new Helicopter(2);

      helis.Add(a);
      helis.Add(b);

      Helicopter c = new Helicopter(1);

      var heliExist = helis.Contains(c);

      //Console.Read();

      ArrayList.ArrayList<int> myArrList = new ArrayList.ArrayList<int>();
      ArrayList.ArrayList<int> myArrList2 = new ArrayList.ArrayList<int>(100);


    }
  }
}
