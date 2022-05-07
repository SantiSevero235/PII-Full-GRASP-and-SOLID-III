using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //Se creó una clase llamada FilePrinter que es encargada de imprimir la receta atraves de un archivo de formato .txt (texto)
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe (Recipe recipe, Destination destination)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}