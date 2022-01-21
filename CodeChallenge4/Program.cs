using System;
using System.Collections.Generic;

namespace CodeChallenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            //question();
            longest();
        }
        static void longest()
        {

            int coin = 5;
            int s = 1;
            while (s <= coin)
            {
                coin -= s;
                s++;
            }
            Console.WriteLine(s - 1);
        }
        static void question()
        {
            List<int> num = new List<int>() { 1, 2, 2, 5, 3, 2, 3, 7 };
            SortedList<int, int> sort = new SortedList<int, int>();
            foreach (var x in num)
            {
                if (sort.ContainsKey(x))
                {
                    sort[x] = sort[x] + 1;
                }
                else
                {
                    sort.Add(x, 1);
                }
            }

            int h = 0;
            int hold = 0;
            int count = 0;
            int countt = 0;
           
            for (int i = 1; i < sort.Count - 1; i++)
            {
                if ((sort.Keys[i]) - (sort.Keys[i] - 1) == 1)
                {
                    if (sort.Values[i] > count)
                    {
                        countt = sort.Values[i];
                        count = sort.Values[i];

                    }

                }
            }
            if (count > hold)
            {
                hold = count;


            }
            if (hold > h)
            {
                h = hold;

            }
            Console.WriteLine(h+countt);
           
        }
    }
}
