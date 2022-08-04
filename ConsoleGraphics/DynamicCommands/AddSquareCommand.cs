using ConsoleGraphics.Shapes;
using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics.DynamicCommands
{
    internal class AddSquareCommand : ICommand
    {
        private CompositeShape composite;
        public AddSquareCommand(CompositeShape composite)
        {
            this.composite = composite;
        }
        public void Execute()
        {
            composite.AddShape(new Square());
            Console.WriteLine("Adaugare patrat");
            Console.ReadLine();
        }
    }
}
