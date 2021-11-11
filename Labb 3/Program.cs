using System;

namespace Labb_3
{
    public class Teckning
    {
        
       

        public virtual double Area()
        {
            return 10; 
        }



        static void Main(string[] args)
        {
            Teckning T1 = new Cirkel();
            Console.WriteLine("Cirkel area = " + T1.Area());
            Teckning F1 = new Fyrkant();
            Console.WriteLine("Fyrkants area = " + F1.Area());
            Teckning R1 = new Rektangel();
            Console.WriteLine("Rektangel area = " + R1.Area());

            Console.ReadKey();
        }
    }
}
