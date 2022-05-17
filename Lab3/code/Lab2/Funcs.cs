using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lab2
{
    class Funcs
    {
        public static void ConesOut(List<Cone> cones)
        {
            for (int i = 0; i < cones.Count; i++)
            {
                Vector3 center = cones[i].GetCenter();
                Vector3 coneApex = cones[i].GetConeApex();
                float radius = cones[i].GetRadius();
                double generatrix = cones[i].GetGeneratrix();
                Console.WriteLine($"\nCone {i}\n");
                Console.WriteLine($"Center cords: {center.X} {center.Y} {center.Z}");
                Console.WriteLine($"Cone apex cords: {coneApex.X} {coneApex.Y} {coneApex.Z}");
                Console.WriteLine($"Radius: {radius}");
                Console.WriteLine($"Generatrix: {generatrix}");
            }
        }

        public static double FindMaxGeneratrix(List<Cone> cones)
        {
            double max = Double.MinValue;
            for (int i = 0; i < cones.Count; i++)
            {
                if (cones[i].GetGeneratrix() > max)
                    max = cones[i].GetGeneratrix();
            }
            return max;
        }
    }
}