using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TVector2d> vec2dList = new List<TVector2d>();
            vec2dList.Add(new TVector2d(new Vector2(3, 1)));
            vec2dList.Add(new TVector2d(new Vector2(6, 2)));
            vec2dList.Add(new TVector2d(new Vector2(-1, 5)));

            List<TVector3d> vec3dList = new List<TVector3d>();
            vec3dList.Add(new TVector3d(new Vector3(10, 5, -3)));
            vec3dList.Add(new TVector3d(new Vector3(3, 8, 12)));
            vec3dList.Add(new TVector3d(new Vector3(-6, 1, 6)));
            vec3dList.Add(new TVector3d(new Vector3(-1, 2, 0)));

            float sumTVec2 = 0;
            for (int i = 1; i < vec2dList.Count; i++)
            {
                if (vec2dList[0].IsParallel(vec2dList[i]))
                    sumTVec2 += vec2dList[i].VecLength();
            }

            Console.WriteLine($"Sum of parallel 2d vectors lengths: {sumTVec2}");
            
            float sumTVec3 = 0;
            for (int i = 1; i < vec3dList.Count; i++)
            {
                if (vec3dList[0].IsPerpendicular(vec3dList[i]))
                    sumTVec3 += vec3dList[i].VecLength();
            }

            Console.WriteLine($"Sum of perpendicular 3d vectors lengths: {sumTVec3}");
        }
    }
}