using ConsoleGraphics.Shapes;
using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics.DynamicCommands
{
    internal class AddCircleCommand : ICommand
    {
        private CompositeShape composite;
        public AddCircleCommand(CompositeShape composite)
        {
            this.composite = composite;
        }
        public void Execute()
        {
            composite.AddShape(new Circle());
            Console.WriteLine("Adaugare cerc");
            Console.ReadLine();
        }
    }
}
