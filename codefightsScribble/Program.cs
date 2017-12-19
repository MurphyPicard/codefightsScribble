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
            var answerList = new List<int>();

            

            for (var i = 0; i < a.Length; i++)
            {
                var indexTest = answerList.IndexOf(a[i]);

                // if not there
                if (indexTest < 0)
                {
                    answerList.Add(a[i]);
                }
                else
                {
                    Console.WriteLine(a[i]);
                    break;
                }
                
            }

            
        }

        static void Main(string[] args)
        {
            int[] testNums = {1, 2, 3, 3, 66, 55, 44, 33, 22};
            
            FirstDuplicate(testNums);
        }


    }
}
