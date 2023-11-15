using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
  internal class Node<T>
  {
    public T m_data { get; set; }
    public Node(T value)
    {
      m_data = value;
    }
  }

  public class ArrayList<T>
  {
    private Node<T>[] m_array;
    private int m_itemCnt;

    public ArrayList(int len = 10) //optional argument
    {
      m_array = new Node<T>[len];
      m_itemCnt = 0;
    }

    public int Length { get { return m_array.Length; } }

    public void Add(T item)
    {
      //create new Node...
      Node<T> tmp = new Node<T>(item);
      IncreaseOnDemand();

      //append value at next available position
      m_array[m_itemCnt] = tmp;

      //increment for next insert
      m_itemCnt++;
    }

    private void IncreaseOnDemand()
    {
      if ((m_itemCnt + 1) > m_array.Length) //check if new Node element fits into array
      {
        //increase size of array
        Array.Resize(ref m_array, m_array.Length * 2);
      }
    }

    public void InserAt(int index, T item)
    {
      if (index < 0 || index >= m_array.Length) throw new IndexOutOfRangeException("bla");
      m_array[index] = new Node<T>(item);
    }

    public T this[int i]
    {
      get 
      {
        if (i < 0 || i > m_array.Length) throw new IndexOutOfRangeException();
        if (m_array[i] == null) throw new IndexOutOfRangeException();
        return m_array[i].m_data;
      }
      set 
      {
        if (i < 0 || i > m_array.Length) throw new IndexOutOfRangeException();
        if (m_array[i] == null)
        {
          Node<T> tmp = new Node<T>(value); 
          m_array[i] = tmp;
        }
        else
        {
          m_array[i].m_data = value;
        }
      }
    }


    public void Remove(T item)
    {
      for (int i = 0; i < m_array.Length; i++)
      {
        if (m_array[i] != null && m_array[i].Equals(item))
        {
          m_array[i] = null;
          Array.Copy(m_array, i + 1, m_array, i, (m_itemCnt - i));
          m_itemCnt--;
        }
      }

      decreaseOnDemand();
    }

    private void decreaseOnDemand()
    {
      if(m_array.Length > m_itemCnt + 2)
      {
        Array.Resize(ref m_array, m_itemCnt);
      }
    }

  }
}
