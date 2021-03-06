﻿using System;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;

namespace HelperProject
{
    class Node
    {
        public static void Print(Node<int> in1)
        {
            while (in1 != null)
            {
                Console.Write(in1.ToString() + " -> ");
                in1 = in1.GetNext();
            }
            Console.WriteLine("null");
        }

        public static Node<int> merge(Node<int> c1, Node<int> c2)
        {
            Node<int> c3 = null;
            if (c1.GetInfo() < c2.GetInfo())
            {
                c3 = new Node<int>(c1.GetInfo(), null);

                c1 = c1.GetNext();
            }
            else
            {
                c3 = new Node<int>(c2.GetInfo(), null);

                c2 = c2.GetNext();
            }
            Node<int> pos = c3;
            while (c1 != null && c2 != null)
            {
                if (c1.GetInfo() < c2.GetInfo())
                {
                    Node<int> temp = new Node<int>(c1.GetInfo(), null);
                    pos.SetNext(temp);
                    pos = pos.GetNext();

                    c1 = c1.GetNext();
                }
                else
                {
                    Node<int> temp = new Node<int>(c2.GetInfo(), null);
                    pos.SetNext(temp);
                    pos = pos.GetNext();
                    c2 = c2.GetNext();
                }
            }
            while (c1 != null)
            {
                Node<int> temp = new Node<int>(c1.GetInfo(), null);
                pos.SetNext(temp);
                pos = pos.GetNext();
                c1 = c1.GetNext();
            }
            while (c2 != null)
            {
                Node<int> temp = new Node<int>(c2.GetInfo(), null);
                pos.SetNext(temp);
                pos = pos.GetNext();
                c2 = c2.GetNext();
            }


            return c3;
        }


        //תרגיל מבגרות
        //מקבלת שרשרת חוליות
        //מחזירה שרשרת חוליות הפוכה
        public static Node<int> Hafuch(Node<int> chain)
        {
            Node<int> newchain = new Node<int>(chain.GetInfo());
            Node<int> p = chain.GetNext();
            while (p != null)
            {
                Node<int> temp = new Node<int>(p.GetInfo());
                temp.SetNext(newchain);
                newchain = temp;
                p = p.GetNext();
            }
            return newchain;
        }
        //מקבלת שרשרת חוליות ומספר
        //מחזירה את המרחק של המספר מההתחלה
        public static int Merhak(Node<int> c, int n)
        {
            int mone = 0;
            Node<int> p = c;
            while (p.GetInfo() != n)
            {
                mone++;
                p = p.GetNext();
            }
            return mone;
        }
        //מקבלת שרשרת חוליות
        //מחזירה את המספר שמרחקו משני הקצוות מינימלי
        public static int Ktsavot(Node<int> chain)
        {
            Node<int> opchain = Hafuch(chain);
            Node<int> p = chain.GetNext();
            int min = chain.GetInfo();
            int mer = Merhak(chain, p.GetInfo()) + Merhak(opchain, p.GetInfo());
            while (p != null)
            {
                if (Merhak(chain, p.GetInfo()) + Merhak(opchain, p.GetInfo()) < mer)
                {
                    mer = Merhak(chain, p.GetInfo()) + Merhak(opchain, p.GetInfo());
                    min = p.GetInfo();
                }
                p = p.GetNext();
            }
            return min;
        }
    }
}
