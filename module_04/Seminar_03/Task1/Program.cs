using System;

namespace Task1
{
    class Matrix2
    {
        double a11;

        double a12;

        double a21;

        double a22;

        public Matrix2(double a11, double a12, double a21, double a22)
        {
            this.a11 = a11;
            this.a12 = a12;
            this.a21 = a21;
            this.a22 = a22;
        }

        public Matrix2(double a11,double a22)
        {
            this.a11 = a11;
            this.a12 = 0;
            this.a21 = 0;
            this.a22 = a22;
        }

        public Matrix2(Matrix2 matrix)
        {
            a11 = matrix.a11;
            a12 = matrix.a12;
            a21 = matrix.a21;
            a22 = matrix.a22;
        }

        public double Det()
        {
            return a11 * a22 - a21 * a12;
        }

        public Matrix2 Inverse()
        {
            if (Det() == 0)
                throw new ArgumentException("Данная матрица не имеет обратную матрицу");
            return new Matrix2(a22 / Det(), -a12 / Det(), -a21 / Det(), a11 / Det());
        }

        public Matrix2 Transpose()
        {
            return new Matrix2(a11,a21,a12,a22);
        }

        public static Matrix2 operator +(Matrix2 matrix1, Matrix2 matrix2)
        {
            return new Matrix2(matrix1.a11 + matrix2.a11, matrix1.a12 + matrix2.a12, matrix1.a21 + matrix2.a21, matrix1.a22 + matrix2.a22);
        }

        public static Matrix2 operator -(Matrix2 matrix1, Matrix2 matrix2)
        {
            return new Matrix2(matrix1.a11 - matrix2.a11, matrix1.a12 - matrix2.a12, matrix1.a21 - matrix2.a21, matrix1.a22 - matrix2.a22);
        }

        public static Matrix2 operator *(double i, Matrix2 matrix)
        {
            return new Matrix2(i*matrix.a11, i * matrix.a12, i * matrix.a21, i * matrix.a22);
        }

        public static Matrix2 operator *( Matrix2 matrix, double i)
        {
            return new Matrix2(i * matrix.a11, i * matrix.a12, i * matrix.a21, i * matrix.a22);
        }

        public static Matrix2 operator *(Matrix2 m1, Matrix2 m2)
        {
            return new Matrix2(m1.a11*m2.a11 + m1.a12*m2.a21,m1.a11*m2.a12+ m1.a12 * m2.a22,m1.a21*m2.a11+ m1.a22 * m2.a21, m1.a21 * m2.a12 + m1.a22 * m2.a22);
        }

        public static Matrix2 operator /(Matrix2 m1, Matrix2 m2)
        {
            return m1 * m2.Inverse();
        }

        public override string ToString()
        {
            return $"({a11:g2} {a12:g2})\n({a21:g2} {a22:g2})\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix2 m1 = new Matrix2(4, 2, 9, 0);
            Matrix2 m2 = new Matrix2(3, 1, -3, 4);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m2.Inverse());
            Console.WriteLine(m1.Det());
            Console.WriteLine(m1.Transpose());
            Console.WriteLine(m1 + m2);
            Console.WriteLine(m1-m2);
            Console.WriteLine(m1*m2);
            Console.WriteLine(m1/m2);
        }
    }
}
