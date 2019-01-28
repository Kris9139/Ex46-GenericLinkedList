using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt
{
    public class MyLinkedList
    {

        Node Head;
        Node Tail;
        public int Count { get; private set; }


        public void Insert(object data)
        {
            Node NewNode = new Node(data);
            if (Count < 1)
            {
                Head = NewNode;
                Tail = NewNode;
            }
            else
            {
                Tail.Next = NewNode;
                NewNode.Prev = Tail;
                Tail = NewNode; 
            }
            Count++;
        }

        public void Insert(object data, int index)
        {

            Node NewNode = new Node(data);
            if (index == 0)
            {
                Node prevHead = Head;
                Head = NewNode;
                NewNode.Next = prevHead;
                prevHead.Prev = NewNode;
            }
            else
            {
                Node node = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    node = node.Next;
                }
                NewNode.Next = node.Next;
                node.Next = NewNode;
                NewNode.Prev = node;
            }
            Count++;
            
        }
        public void Delete()
        {
            if (Count > 0)
            {
                Head = Head.Next;
                Count--;

            }
        }

        public void Delete(int index)
        {
            if (index > Count) index = Count;
            if (index <= 0) Delete();
            else
            {
                Node position = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    position = position.Next;
                }
                position.Next = position.Next.Next;
                Count--;
            }
        }

        public object ItemAt(int index)
        {
            object result = null;
            if (index < Count && index >= 0)
            {
                Node position = Head;
                for (int i = 0; i < index; i++)
                {
                    position = position.Next;
                }
                result = position.Data;
            }
            return result;
        }

        public void Rervers()
        {
            Node node = Head;
            Head = Tail;
            Tail = node;
            for (int i = 0; i < Count; i++)
            {
                Node prevnext = node.Next;
                node.Next = node.Prev;
                node.Prev = prevnext;
                node = node.Prev;
            }
        }

        public void Swap(int index)
        {
            Node node = Head;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }
            if (node != null && node.Next != null)
            {
                Node prevNode = node.Prev;
                Node secNode = node.Next;
                secNode.Prev = prevNode;
                node.Prev = secNode;
                node.Next = secNode.Next;
                secNode.Next = node;
                prevNode.Next = secNode;
            }
        }

        public string FremTilbage()
        {
            string done = ToString();
            Node node = Tail.Prev;
            for (int i = 1; i < Count; i++)
            {
                done += node.Data.ToString() + "\n";
                node = node.Prev;
            }
            return done;
        }

        public override string ToString()
        {
            string result = "";
            Node pointernode = Head;
            while (pointernode != null)
            {
                result = result + pointernode.Data.ToString() + "\n";

                pointernode = pointernode.Next;
            }
            return result;
        }
    }
}