using System;
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
        bool empty()
        {
            node rafi;
            if (rafi == null)
                return (true);
            else
                return (false);
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
        public void display()
        {
            node temp;
            node aliansyah;
            if (empty())
                Console.WriteLine("\nstack Empty");
            else
            {
                for (temp = aliansyah;temp !=null;temp = temp.next )
                {
                    Console.WriteLine(temp.next);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("\n***Stack Menu***");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Exit");
            Console.WriteLine("\nEnter Your Choice : ");
            char ch = Convert.ToChar(Console.ReadLine());
        }
    }
}
