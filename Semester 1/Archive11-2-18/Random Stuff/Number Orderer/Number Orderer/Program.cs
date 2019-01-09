using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Orderer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10] { 0, 1, 2, 3, 3, 5, 6, 7, 8, 9 };
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (myArray[i] < myArray[j])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
