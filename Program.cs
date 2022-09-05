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
            Console.WriteLine("Choose Option:\n1.UC1-Getting the co-ordinates of two lines\n2.Equality of Two Lines\n3.Comparing length of two lines\n4.Compare the length of lines using Oops");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    GetCartesion.getCartesian();
                    break;
                    case 2:
                        EqualityOffTwoLines.getCartesian();
                    break;
                case 3:
                    CompareLength.getCartesian();
                    break ;
                    case 4:
                        CompareLengthOops compareLengthOops = new CompareLengthOops();
                    compareLengthOops.input();
                    compareLengthOops.cal();
                    compareLengthOops.CompareLines();
                    break ;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
        }
    }
}
