using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{

    interface Company

    {
        void calculateRevenue(string x);

    }

    interface College

    {

        void calculateRevenue();

    }

    class AgricultureCompany : Company, College

    {
        public void calculateRevenue(string x)

        {

            string x2 = x;

            Console.WriteLine("Revenue of a agricultural company is " + x2);

        }

        public void calculateRevenue()

        {

            Console.WriteLine("the college had been recently opened");

        }

    }
    public class Program5

    {
        static void Main(string[] args)

        {

            AgricultureCompany a1 = new AgricultureCompany();

            a1.calculateRevenue("20000000");

            a1.calculateRevenue();

        }

    }

}
