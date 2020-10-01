using System;

namespace RenderEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertex vertex = new Vertex(1, 1, 1);

            double[] a = { 1, 2, 3 };
            double[] b = { 1, 2, 3 };

            AbstractArray.Print(a);
        }
    }

    abstract class AbstractArray
    {
        public static void Print(double[] a)
        {
            System.Console.Write("[");
            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1) 
                {
                    System.Console.Write(a[i]);
                    break;
                }
                System.Console.Write(a[i] + ",");
            }
            System.Console.WriteLine("]");
        }
        public static double[] Add(double[] a, double[] b)
        {
            int length = Math.Min(a.Length, b.Length);
            double[] c = new double[length];

            for(int i = 0; i < length; i++)
            {
                c[i] = a[i] + b[i];
            }

            return c;
        }
    }

}
