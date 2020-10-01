using System;
using System.Collections.Generic;
using System.Text;

namespace RenderEngine
{
    public interface ISpace<T>
    {
        void Move(T t)
        {
            Vertex vertex = new Vertex(1, 1, 1);

            System.Console.WriteLine(vertex.GetPos());
        }
    }
}
