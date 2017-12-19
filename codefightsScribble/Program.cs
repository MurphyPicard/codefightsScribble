using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefightsScribble
{
    
    class Program
    {

        static void FirstDuplicate(int[] a)
        {
            // var answerList = new List<int>();
            var indexTest = Array.IndexOf(a, 66);

            for (var i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[i] " + a[i]);
                Console.WriteLine();
                Console.WriteLine("indexTest 5: " + indexTest);
                Console.WriteLine();
            }

            
        }

        static void Main(string[] args)
        {
            int[] testNums = {1, 2, 2, 3, 3, 66, 55, 44, 33, 22};
            
            FirstDuplicate(testNums);
        }


    }
}
