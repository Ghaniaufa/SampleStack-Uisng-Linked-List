using System;

namespace StackUsingLinkedList_CSarp
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }
    
    class Stacks
    {
        Node top;

        public Stacks()
        {
            top = null;
        }
        bool empty ()
        {
            if (top == null)
                return (true);
            else
                return
        }
        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);
        }
    }
}