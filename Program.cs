//Name: Ishraq Alam
//Date: March 12, 2024
//Title: CCCPractice2_DusaAndTheYobis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCCPractice2_DusaAndTheYobis_IshraqAlam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            string strUser;
            int intDusaSize;
            int intYobiSize;


            //Input
            Console.WriteLine("Enter dusa size initially: ");
            strUser = Console.ReadLine();
            intDusaSize = Int32.Parse(strUser);

            Console.WriteLine("Enter the size of the first Yobi: ");
            strUser = Console.ReadLine();
            intYobiSize = Int32.Parse(strUser);

            //Process
            while (intDusaSize > intYobiSize)
            {
                intDusaSize = intDusaSize + intYobiSize;

                Console.WriteLine("What is the size of the next Yobi?");
                strUser = Console.ReadLine();
                intYobiSize = Int32.Parse(strUser);
            }

            //Output
            Console.WriteLine("The size of Dusa when running away is: " + intDusaSize);

            Console.ReadKey();
        }
    }
}
