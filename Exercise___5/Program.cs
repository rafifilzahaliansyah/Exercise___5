﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___5
{
    
    class node
    {
        public string name;
        public node next;
        public node Rafi;
        public node Aliansyah;
    }

    class list
    {
        node START;
        public list()
        {
            START = null;

        }
        public void Insert(string nm,node rafi,node aliansyah)
        {
             if(rafi == null)
             {
                node temp = new node();
                temp.name = nm;
                rafi = temp;
                return;
             }
             node tempnode = rafi;
             while (tempnode.next !=null)
             {
                tempnode = tempnode.next;
             }
             node newelement = new node();
             newelement.name = nm;
             tempnode.next = newelement;
        }
        public void delete(node rafi)
        {
            if(rafi !=null)
            {
                if(rafi.next !=null)
                {
                    rafi = rafi.next;
                    return;
                }
                rafi = null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
