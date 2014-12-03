﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntNode_1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = rand.Next(2, 100);

            IntNode chain = new IntNode(2);

            for (int i = 3; i < n; i++)
            {
                chain.next = new IntNode(i);
                chain = chain.next;
            }

            Console.WriteLine(IntNode.printIntNode(chain));
        }
    }
}
