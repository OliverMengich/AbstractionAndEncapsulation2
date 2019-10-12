using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrationAndEncapsulation2
{
    class Program
    {
        int num;
        static int cnt;
        public static void Add()
        {
            // Static functions works only on static Data
            
        }
        public void increment()
        {
            num++;
            cnt ++;
        }
        public void display()
        {
            Console.WriteLine("Num = {0}, cnt = {1}", num, cnt);
        }
        static void Main(string[] args)
        {
            // The static holds the value of the reference. Changes of the Value of
            // The Variable Also changes the original Value
            Program p1 = new Program();
            p1.increment();
            p1.display();
            Program p2 = new Program();
            p2.increment();
            p2.display();
            ////////////////////////////
            Add();
            Console.Read();
        }
    }
    class CLASS
    {
        // Calling A static Method inside Anther Class outside the used Class
        public static void MyMethod()
        {
            Program.Add();
        }
    }
}
