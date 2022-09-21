namespace Full_GRASP_And_SOLID.Library;

using System;
using System.IO;
public class ConsolePrinter : IPrinter
{

    public void PrintRecipe(Recipe recipe)
    {

        Console.WriteLine(recipe.GetTextToPrint());

    }

}