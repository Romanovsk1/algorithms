﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1._2
{
    class Program2
    {
        static void Main(string[] args)
        {
            
            int[] inputArray =  { 11110,55,15} ;

            

            Console.WriteLine(StrangeSum(inputArray));
            Console.ReadKey();
        
        }


        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; //O(1)
            for (int i = 0; i < inputArray.Length; i++) //O(N)
            {
                for (int j = 0; j < inputArray.Length; j++) //O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++) //O(N)
                    {
                        int y = 0; //O(1)

                        if (j != 0) //O(2) - 2 шага если условие выполняется.
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y; //O(1)
                    }
                }
            }

            return sum; //O(1)
        }

        //Подсчет ассимптотической сложности?

        // O(1) + O(N) * ( O(N) * ( O(N) * ( O(1) + O(2) + O(1) ) ) ) + O(1) = 
        // = O(2) + O(N) * O(N) * O(3N) =
        // = O(2) + O(3N^3) =
        // = O(2+3N^3) =
        // = O(N^3)	
    }
}
