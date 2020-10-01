using System;
using System.Collections.Generic;
using System.Text;

namespace RenderEngine
{

    public class Vertex
    {
        double x, y, z;

        public Vertex(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            double[] a = GetPos();
            System.Console.WriteLine(a.ToString());
        }
        public double[] GetPos()
        {
            double[] a = {x+1, y, z};

            System.Console.WriteLine(a.ToString());

            return a;
        }
    }
}
