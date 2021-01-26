using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> plakalar = new MyDictionary<string, int>();
            plakalar.Add("Balıkesir", 10);            
            plakalar.Add("İzmir", 35);
            plakalar.Add("İstanbul", 34);
            plakalar.Add("Aydın", 9);
            plakalar.Add("Bursa", 16);
            Console.WriteLine(plakalar.Count);

            for (int i = 0; i < plakalar.Count; i++)
            {
                for (int j = 0; j < plakalar.Count; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine( plakalar.Items[i] + "," + plakalar.Items2[j]);
                        Console.WriteLine("---------");
                    }
                    
                }
            }
            Console.ReadLine();
        }


    }
}
