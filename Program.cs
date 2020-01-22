using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables here
            int x;
            string falsifier = "no";
            int z; //z is used to confirm if there is anything else
            //start program here
            //y is input for order type
            float ccounter = 0f; float fcounter = 0f; float bcounter = 0f; float dcounter = 0f; float rcounter = 0f;
            float price = 0f;
            float cprice = 2.00f; float fprice = 1.00f; float bprice = 2.00f; float dprice = 0.50f;float rprice = 3.00f;
                Console.WriteLine("Enter Order");
                Console.WriteLine("we sell:");
                Console.WriteLine("fried chicken-----$2.00");
                Console.WriteLine("fries-------------$1.00");
                Console.WriteLine("burger------------$2.00");
                Console.WriteLine("drink-------------$0.50");
                Console.WriteLine("fried rice--------$3.00");
            do
            {
                string y = Console.ReadLine();

                Console.WriteLine("enter amount");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Anything else?");

                string b = Console.ReadLine();

                if (b.Equals(falsifier))
                { z = 1; }

                else { z = 2; }

                if (y.Equals("fried chicken"))
                { ccounter = ccounter + x; }
                else if (y.Equals("fries"))
                { fcounter = fcounter + x; }
                else if (y.Equals("burger"))
                { bcounter = bcounter + x; }
                else if (y.Equals("drink"))
                { dcounter = dcounter + x; }
                else if (y.Equals("fried rice"))
                { rcounter = rcounter + x; }
                else
                { Console.WriteLine("previous order Invalid order. Please Re-enter your previous order");z = 2; }
            } while (z.Equals(2));

            price = price + (ccounter * cprice);
            price = price + (fcounter * fprice);
            price = price + (bcounter * bprice);
            price = price + (dcounter * dprice);
            price = price + (rcounter * rprice);

            Console.WriteLine("The total amount is");
            Console.Write("$ "); Console.WriteLine(price);



            Console.ReadLine();

        }
    }
}

