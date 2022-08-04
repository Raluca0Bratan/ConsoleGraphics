using ConsoleGraphics.Shapes;
using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics.DynamicCommands
{
    internal class AddTriangleCommand : ICommand
    {
        private CompositeShape composite;
        public AddTriangleCommand(CompositeShape composite)
        {
            this.composite = composite;
        }
    
        public void Execute()
        {
            composite.AddShape(new Triangle());
            Console.WriteLine("Adaugare triunghi");
            Console.ReadLine();
        }
    }
}
