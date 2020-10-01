using System;
using System.Collections.Generic;
using System.Text;

namespace RenderEngine
{

    public class Vertex : ISpace
    {
        double x, y, z;

        public Vertex(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double[] GetPos()
        {
            //returns vertex position
            return null;
        }

        public void SetPos()
        {
            //Sets vertex position
        }

        public void Move(double[] changePos)
        {
            double[] currentPos = GetPos();



        }
    }
}
