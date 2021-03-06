﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StringToNode
{
    class Node<T>
    {
        public T info { get; set; }
        public Node<T> next { get; set; }

        public Node(T value)
        {
            this.info = value;
            this.next = null;
        }

        public Node(T value, Node<T> next)
        {
            this.info = value;
            this.next = next;
        }

        public static string removeNode(Node<T> chain, T valueToRemove)
        {
            Node<T> pos = chain;
            if (pos.info.ToString() == valueToRemove.ToString())
            {
                chain.next = chain.next;
                pos.next = null;
            }
            while (pos.next.info.ToString() != valueToRemove.ToString())
            {
                pos = pos.next;
                Node<T> temp = pos.next;
                pos.next = temp.next;
                temp.next = null;
            }
            return Node<T>.printNode(chain);
        }

        public static string printNode(Node<T> chain)
        {
            string chainString = null;
            if (chain.next == null)
                chainString += chain.ToString();
            else
            {
                chainString += chain.info + " --> ";
                chainString += printNode(chain.next);
            }
            return chainString;
        }

        public override string ToString()
        {
            return "" + this.info.ToString();
        }
    }
}
