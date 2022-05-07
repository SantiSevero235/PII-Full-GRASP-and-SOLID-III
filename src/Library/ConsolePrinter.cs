using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //Creamos la clase ConsolePrinter, la cual se encargará de imprimir la receta por consola.
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe, Destination destination)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}