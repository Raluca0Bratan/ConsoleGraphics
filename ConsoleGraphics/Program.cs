// See https://aka.ms/new-console-template for more information
using ConsoleGraphics.Commands;
using ConsoleGraphics.DynamicCommands;
using ConsoleGraphics.Shapes;
using DynamicApp.Abstractions;
using DynamicApp.Shared;


CompositeShape composite = new();

List<IMenu> addFormItems = new() { 
    new MenuItem(new AddTriangleCommand(composite), "Triunghi"),      
    new MenuItem(new AddCircleCommand(composite),"Cerc"),    
    new MenuItem(new AddSquareCommand(composite), "Patrat")    
};

List<IMenu> mainMenuItems = new() {
    new MenuItem(new ViewBoardCommand(composite), "Vizualizare plansa"),
    new Menu(addFormItems) { DisplayText = "Adaugare forma" },
    new MenuItem(new RemoveShapeCommand(composite),"Stergere Forma" )
};

Menu mainMenu = new Menu(mainMenuItems) ;
mainMenu.Execute(null);



