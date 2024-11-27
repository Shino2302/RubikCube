using CubeRubikInArrays.Cube;

internal class Program
{
    static void Main(string[] args)
    {
        Cube cube = new Cube();

        Console.WriteLine("Cubo inicial:");
        cube.Display();

        Console.WriteLine("\n");

        cube.MoveB('L');
        cube.Display();
        Console.WriteLine("\n");
        cube.MoveL('R');
        cube.Display();
        Console.WriteLine("\n");
        cube.MoveCenterToDown();
        cube.Display();
        Console.WriteLine("\n");
        cube.MoveF('R');
        cube.Display();
        Console.WriteLine("\n");
        cube.MoveD('R');
        cube.Display();
        Console.WriteLine("\n");
        cube.MoveCenterToRight();
        cube.Display();
        Console.WriteLine("Cubo desordenado\n");

        cube.MoveCenterToLeft();
        cube.Display();
        Console.WriteLine("\n");
        cube.MoveD('L');
        cube.Display();
        Console.WriteLine("\n");
        cube.MoveF('L');
        cube.Display();
        Console.WriteLine("\n");
        cube.MoveCenterToUp();
        cube.Display();
        Console.WriteLine("\n");
        cube.MoveL('L');
        cube.Display();
        Console.WriteLine("\n");
        cube.MoveB('R');
        cube.Display();

    }

}