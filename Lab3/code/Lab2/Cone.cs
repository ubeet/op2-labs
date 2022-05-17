using System;
using System.Numerics;

namespace Lab2
{
    public class Cone
    {
        private Vector3 center;
        private Vector3 coneApex;
        private float r;

        public Cone(Vector3 center, Vector3 coneApex, float radius)
        {
            this.center = center;
            this.coneApex = coneApex;
            this.r = radius;
        }

        public Vector3 GetCenter()
        {
            return center;
        }
        
        public Vector3 GetConeApex()
        {
            return coneApex;
        }

        public float GetRadius()
        {
            return r;
        }

        public double GetGeneratrix()
        {
            double h = Math.Sqrt(Math.Pow(center.X - coneApex.X, 2) + 
                              Math.Pow(center.Y - coneApex.Y, 2) + 
                              Math.Pow(center.Z - coneApex.Z, 2));
            double l = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r, 2));
            return l;
        }
    }
}