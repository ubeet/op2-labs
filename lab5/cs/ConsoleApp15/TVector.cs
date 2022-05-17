using System;
using System.Numerics;

namespace ConsoleApp15
{
    public abstract class TVector<T>
    {
        public abstract bool IsParallel(T vector);
        
        public abstract bool IsPerpendicular(T vector);
        
        public abstract float VecLength();
    }
    
    public class TVector2d : TVector<TVector2d>
    {
        public readonly Vector2 _vector;
        public TVector2d(Vector2 vector)
        {
            _vector = vector;
        }
        
        public override bool IsParallel(TVector2d vector)
        {
            var v = (_vector.X / vector._vector.X) == (_vector.Y / vector._vector.Y);
            return v;
        }

        public override bool IsPerpendicular(TVector2d vector)
        {
            var v = _vector.X * vector._vector.X + _vector.Y * vector._vector.Y;
            return v == 0;
        }

        public override float VecLength()
        {
            float length = (float) Math.Sqrt(_vector.X * _vector.X + _vector.Y * _vector.Y);
            return length;
        }

    }
    
    public class TVector3d : TVector<TVector3d>
    {
        public readonly Vector3 _vector;

        public TVector3d(Vector3 vector)
        {
            _vector = vector;
        }

        public override bool IsParallel(TVector3d vector)
        {
            var v = _vector.X / vector._vector.X == _vector.Y / vector._vector.Y &&
                    _vector.Y / vector._vector.Y == _vector.Z / vector._vector.Z;
            return v;
        }

        public override bool IsPerpendicular(TVector3d vector)
        {
            float v = _vector.X * vector._vector.X + _vector.Y *
                vector._vector.Y + _vector.Z * vector._vector.Z;
            return v == 0;
        }
        
        public override float VecLength()
        {
            float length = (float) Math.Sqrt(_vector.X * _vector.X + _vector.Y * _vector.Y + _vector.Z * _vector.Z);
            return length;
        }
    }
}