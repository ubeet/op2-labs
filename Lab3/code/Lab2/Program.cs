using System;
using System.Collections.Generic;
using System.Numerics;
using static Lab2.Funcs;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cone> coneList = new List<Cone>();
            Random rand = new Random();
            int n = -10;
            int m = 11;
            for (int i = 0; i < 10; i++)
            {
                Cone newCone = new Cone(new Vector3(rand.Next(n, m), rand.Next(n, m), rand.Next(n, m)),
                    new Vector3(rand.Next(n, m), rand.Next(n, m), rand.Next(n, m)), rand.Next(0, m));
                coneList.Add(newCone);
            }

            ConesOut(coneList);
            Console.WriteLine($"\nMax generatrix: {FindMaxGeneratrix(coneList)}");
        }
    }
} 