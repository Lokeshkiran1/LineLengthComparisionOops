using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLengthComparisionOops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comoarision Program!");
            Console.WriteLine("Choose Option:\n1.UC1-Getting the co-ordinates of two lines");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    GetCartesion.getCartesian();
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
        }
    }
}
