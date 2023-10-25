using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
  internal class Node<T>
  {
    //ctor
    public Node(T item)
    {
      m_data = item;
    }

    public Node<T> m_next { get; set; }

    public T m_data { get; set; }
  }

  public class SinglyLinkedList<T>
  {
    Node<T> m_head { get; set; }
    Node<T> m_last { get; set; }
    int m_cnt { get; set; }

    public void Add(T item)
    {
      m_cnt++; //increment counter

      Node<T> tmp = new Node<T>(item); //create new node
      if(m_head == null)
      {
        //in case SSL is empty so far
        m_head = tmp;
        m_last = tmp;
        return;
      }

      //else append at the end
      m_last.m_next = tmp;
      m_last = tmp;
    }

    public bool Contains(T item)
    {
      for (Node<T> i = m_head; i != null; i = i.m_next)
      {
        if (i.m_data.Equals(item))
          return true;
      }

      return false;
    }

    public bool Remove(T item) 
    {
      Node<T> prev = null;
      for (Node<T> i = m_head; i != null; i = i.m_next)
      {
        if (i.m_data.Equals(item))
        {
          prev.m_next = i.m_next;
          m_cnt--;
          return true;
        }
        prev = i;
      }

      return false;
    }

    public void Clear()
    {
      m_head = null;
      m_last = null;
      m_cnt = 0;
    }
  }
}
