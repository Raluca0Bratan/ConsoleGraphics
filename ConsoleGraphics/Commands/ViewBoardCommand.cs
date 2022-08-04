using ConsoleGraphics.Shapes;
using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics.Commands
{
    internal class ViewBoardCommand : ICommand
    {
        private CompositeShape composite;
        public ViewBoardCommand(CompositeShape composite)
        {
            this.composite = composite;
        }
    
        public void Execute()
        {

            Console.WriteLine("Vizualizare plansa \n");
            Console.WriteLine(composite.Draw());
            Console.ReadLine();
        }
    }
}
