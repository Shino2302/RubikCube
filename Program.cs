using CubeRubikInArrays.Cube;
using CubeRubikInArrays.Gameplay;

internal class Program
{
    static void Main(string[] args)
    {
        Gameplay game = new Gameplay(new Cube());

        while(true)
        {
            Console.WriteLine("\nSelecciona una opción: \n");
            game.ListMenuOptions();
            Console.Write("Tu opción: ");
            string selectMove = Console.ReadLine();
            game.MovesFactory(selectMove);
            Console.WriteLine("\n");
            game.GetPlainMatrix();
        }
    }

}