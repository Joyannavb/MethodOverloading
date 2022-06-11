using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        public static int Add(int a, int b)
        {return a + b;}

        public static decimal Add(decimal a, decimal b)
        { return a + b;}

        public static string Add(int a, int b, bool Check)
        {   
            int c = a + b; 

            if (Check == true && c < 1)
                { return $"{c} dollars"; }
            else if (Check == true && c==1 )
                { return $"{c} dollar"; }
            else if (Check == true && c> 1)
                { return $"{c} dollars"; }
            else
                { return c.ToString(); }

        }


        static void Main(string[] args)
        {
        }
    }
}
