using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    public delegate void PrintDelegate(int a, int b);


    class SuperClass
    {
        int a;
        int b;
      
        public void PrintOK(int a, int b)
        {
            Console.WriteLine(a + 2*b);

        }
    }


    class SimpleClass
    {
        public int a;
        public int b;
        public PrintDelegate pd;
        public void PrintOK()
        {
            pd.Invoke(this.a, this.b);
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            SuperClass c = new SuperClass();
            SimpleClass s = new SimpleClass();
            s.a = 6;
            s.b = 3;
            s.pd = c.PrintOK;
            s.PrintOK();
        }
    }
}
