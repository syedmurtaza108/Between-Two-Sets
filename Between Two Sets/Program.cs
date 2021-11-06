using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Between_Two_Sets
{
    class Program
    {
        static int getTotalX(int[] a, int[] b)
        {
            Array.Sort(a);
            Array.Sort(b);

            ArrayList divList = new ArrayList();

            bool isAllowed = false;

            for(int i = 1; i<=b[0]; i++)
            {
                for(int j = 0; j<a.Length; j++)
                {
                    if (i % a[j] == 0)
                        isAllowed = true;
                    else
                    {
                        isAllowed = false;
                        break;
                    }
                }

                if (isAllowed)
                    divList.Add(i);
            }

            isAllowed = false;
            int count = 0;
            for(int i =0; i<divList.Count; i++)
            {
                int temp = (int)divList[i];
                for(int j = 0; j<b.Length; j++)
                {
                    if (b[j] % temp  == 0)
                        isAllowed = true;
                    else
                    {
                        isAllowed = false;
                        break;
                    }
                }

                if (!isAllowed)
                {
                    divList[i] = -1;
                    count++;
                }
            }

            for (int i = 0; i <=count; i++)
                divList.Remove(-1);

            return divList.Count;
        }

        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
            ;
            int total = getTotalX(a, b);

            Console.WriteLine(total);
        }
    }
}
