using System;
using System.Diagnostics.CodeAnalysis;

namespace Structures
{
    public struct PointS
    {
        double x;
        double y;
        public PointS(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(PointS other)
        {
            return Math.Sqrt((x - other.x) * (x - other.x) + (y - other.y) * (y - other.y));
        }

        public override string ToString()
        {
            return $"x = {x}  y = {y}";
        }
    }

    public struct CircleS:IComparable<CircleS>
    {
        double rad;
        PointS center;
        public PointS Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
            }
        }
        public CircleS(double x, double y, double rad)
        {
            this.rad = rad;
            center = new PointS(x, y);
        }
        public double Length
        {
            get
            {
                return 2 * Math.PI * rad;
            }
        }

        public int CompareTo(CircleS other)
        {
            return rad.CompareTo(other.rad);
        }
        public override string ToString()
        {
            return $"Centre: {center}  radius = {rad:f2}";
        }
    }
}
