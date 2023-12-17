using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }


        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data + "\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
            Node n1 = new Node(val);

            if (First == null)
            {
                n1.Next = First;
                First = n1;
                return;
            }
            Node move = First;
            while (move.Next != null)
            {
                move = move.Next;
            }
            move.Next = n1;


        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
            if (First == null)
                return;

            if (First.Data == key)
            {
                First = First.Next;
            }
            Node current = First;
            Node previose = First;
            while (current != null)
            {

                if (current.Data == key)
                {
                    previose.Next = current.Next;
                    current.Next = null;
                    return;
                }
                previose = current;
                current = current.Next;

            }
        }

        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
            Node current = First;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = other_list.First;
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
            Node current = First;
            Node next = null;
            Node previose = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previose;
                previose = current;
                current = next;
            }
            First = previose;
        }
    }
}
