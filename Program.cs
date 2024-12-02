using CubeRubikInArrays.Cube;
using CubeRubikInArrays.Cube4x4;
using CubeRubikInArrays.Gameplay;
using CubeRubikInArrays.Gameplay4x4;

internal class Program
{
    static void Main(string[] args)
    {
        Gameplay4x4 gameplay = new Gameplay4x4(new Cube4x4());

        while(true)
        {
            Console.WriteLine("\nSelecciona una opción: \n");
            gameplay.ListMenuOptions();
            Console.Write("Tu opción: ");
            string selectMove = Console.ReadLine();
            gameplay.MovesFactory(selectMove);
            Console.WriteLine("\n");
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