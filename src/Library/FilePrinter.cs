namespace Full_GRASP_And_SOLID.Library;

using System;
using System.IO;
public class FilePrinter : IPrinter
{

    public void PrintRecipe(Recipe recipe)
    {

        File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());

    }

}