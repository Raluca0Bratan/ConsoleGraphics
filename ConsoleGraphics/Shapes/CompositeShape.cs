using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleGraphics.Shapes
{
    public class CompositeShape : IShape
    {

        private Dictionary<int, IShape> shapes = new();
        public void AddShape(IShape shape)
        {
            shapes.Add(shapes.Count()+1,shape);
        }
        public  void RemoveShape(int key)
        {
            shapes.Remove(key);
        }
        public string Draw()
        {
            string display = "";
            foreach (var shape in shapes)
            {
                display +=shape.Key+"."+shape.Value.Draw()+"\n";
          
            }
            return display;
        }

    }
}
