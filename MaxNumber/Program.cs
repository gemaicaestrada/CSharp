using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {   //This is the first output:
            Console.WriteLine(Util.Max(1, 2, 4, 5, 89, 20, -11));

            //This is the second output:
            Console.WriteLine(Util.Max(2, 5, 5, 8));
        }
    }
    class Util
    {
        public static int Max(params int[] paramList)
        {
            int min = paramList[0];
            for(int i=1; i<paramList.Length; i++)
            {
                if (min < paramList[i]) min = paramList[i];
            }
            return min;
        }
    }
}
