using System;

namespace building_material_using_class
{
    

    class Collecting_info
    {
        //variables
        int ordcement;
        int ordgravel;
        int ordsand;
        string conf = "yes";
        Double cost = 0;


        public void Acceptorder()
        {
            Console.WriteLine("enter order");
            Console.WriteLine("cement");
            ordcement = int.Parse (Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("gravel");
            ordgravel = int.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("sand");
            ordsand = int.Parse(Console.ReadLine());
            Console.ReadLine();
        }
        public void Confirmation()
        {
            int x = 1;
            while (x > 0)
            { 
             Console.WriteLine("cement {0}", ordcement);
             Console.WriteLine("gravel {0}", ordgravel);
             Console.WriteLine("sand {0}", ordsand);
             Console.WriteLine("confirm order?");
             string confirm = Console.ReadLine();
                if (confirm.Equals(conf))
                {
                    Console.WriteLine("order confirmed");
                    x = 0;
                }
            
                else
                {
                    Console.WriteLine("reenter order");
                    Console.WriteLine("enter order");
                    Console.WriteLine("cement");
                    ordcement = int.Parse(Console.ReadLine());
                    Console.ReadLine();
                    Console.WriteLine("gravel");
                    ordgravel = int.Parse(Console.ReadLine());
                    Console.ReadLine();
                    Console.WriteLine("sand");
                    ordsand = int.Parse(Console.ReadLine());
                    Console.ReadLine();
                }
                cost = ordcement * 2.00 + ordgravel * 1.50 + ordsand * 1.00;
            }
            
            
                
            

        }
        
        public void Display()
        {
          Console.WriteLine("cost: {0}",cost);
        }
    }   
   
    class Execute
    {
        static void Main(string[] args)
        {
            Collecting_info c = new Collecting_info();
            c.Acceptorder();
            c.Confirmation();
            c.Display();
            
            Console.ReadLine();

        }

        
        
            
        
    }
   
    
        
    

    
 }

