using ConsoleGraphics.Shapes;
using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics.Commands
{
      public class RemoveShapeCommand : ICommand
    {
        private CompositeShape composite;
        public RemoveShapeCommand(CompositeShape composite)
        {
            this.composite = composite;
        }

        public void Execute()
        {
            Console.WriteLine("Stergere forma");
            Console.WriteLine("Introduceti cheia:");
            int key =Convert.ToInt32( Console.ReadLine());
            this.composite.RemoveShape(key);
            Console.ReadLine();
        }
    }
}
