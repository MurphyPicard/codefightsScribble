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

                // if there already it is the first duplicate
                else
                {
                    Console.WriteLine(a[i]);
                    break;
                }
                
            }

            ////////////////////////////// passes 11/11 tests but not hidden tests due to time constraints
            /*
            for (var i = 0; i < a.Length; i++)
            {

                if (Array.IndexOf(a, a[i]) < i)
                {
                    return a[i];
                }
                else
                {
                    Console.Write("run " + (i + 1) + "\n");
                }

            }
            return -1
            */

            //Dictionary<?>
            ////////////////////////////// 


        }

        static void Main(string[] args)
        {
            int[] testNums = {1, 2, 3, 3, 66, 55, 44, 33, 22};
            
            FirstDuplicate(testNums);
        }


    }
}
