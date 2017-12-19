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
            foreach (var num in a)
            {
                Console.WriteLine("testing loop: " + num);
            }

            // return -1;
        }

        static void Main(string[] args)
        {
            int[] testNums = {1, 2, 3};
            FirstDuplicate(testNums);
        }


    }
}
