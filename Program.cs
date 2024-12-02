using CubeRubikInArrays.Cube;
using CubeRubikInArrays.Cube4x4;
using CubeRubikInArrays.Gameplay;
using CubeRubikInArrays.Gameplay4x4;
using CubeRubikInArrays.PaddingHelper;
internal class Program
{
    static void Main(string[] args)
    {
        string textPlain = "HolaMundoJaJa";
        PaddingHelper padding = new PaddingHelper();
        string textWhitPadding = padding.YourTextWhitPadding(textPlain);
        // Console.WriteLine(textWhitPadding);
        // Console.WriteLine(textWhitPadding.Length);
        Cube4x4 cube = new Cube4x4(textWhitPadding);

        Gameplay4x4 gameplay = new Gameplay4x4(cube);

        while(true)
        {
            Console.WriteLine("\nSelecciona una opción: \n");
            gameplay.ListMenuOptions();
            Console.Write("Tu opción: ");
            string selectMove = Console.ReadLine();
            gameplay.MovesFactory(selectMove);
            Console.WriteLine("\n");
            Console.WriteLine(cube.GetEncrytpString());
        }
        // Cube4x4 myCube = new Cube4x4();

        // myCube.Display();
        // Gameplay game = new Gameplay(new Cube());

        // while(true)
        // {
        //     Console.WriteLine("\nSelecciona una opción: \n");
        //     game.ListMenuOptions();
        //     Console.Write("Tu opción: ");
        //     string selectMove = Console.ReadLine();
        //     game.MovesFactory(selectMove);
        //     Console.WriteLine("\n");
        //     game.GetPlainMatrix();
        // }
    }

}