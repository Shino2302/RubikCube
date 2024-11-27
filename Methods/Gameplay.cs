namespace CubeRubikInArrays.Gameplay;

using CubeRubikInArrays.Cube;

public class Gameplay
{
    private Cube _yourCube;

    public Gameplay(Cube yourCube)
    {
        _yourCube = yourCube;
        _yourCube.Display();
    }

    public void MovesFactory(string moveSelected)
    {
        switch(moveSelected)
        {
            case "R":
                _yourCube.MoveR('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "R'":
                _yourCube.MoveR('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "L":
                _yourCube.MoveL('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "L'":
                _yourCube.MoveL('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "D":
                _yourCube.MoveD('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "D'":
                _yourCube.MoveD('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "U":
                _yourCube.MoveU('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "U'":
                _yourCube.MoveU('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "F":
                _yourCube.MoveF('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "F'":
                _yourCube.MoveF('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;
            
            case "B":
                _yourCube.MoveB('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "B'":
                _yourCube.MoveB('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "CU":
                _yourCube.MoveCenterToUp();
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "CD":
                _yourCube.MoveCenterToDown();
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "CL":
                _yourCube.MoveCenterToLeft();
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "CR":
                _yourCube.MoveCenterToRight();
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            default:
                Console.WriteLine("Finish");
            break;
        }
    }
    public void ListMenuOptions()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("U: Cara Superior.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("D: Cara Inferior.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("R: Cara Derecha.");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("L: Cara Izquierda.");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("F: Cara Frontal.");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("B: Cara Trasera.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("CU: Centro Arriba.");
        Console.WriteLine("CD: Centro Abajo.");
        Console.WriteLine("CR: Centro Derecha.");
        Console.WriteLine("CL: Centro Izquierda.");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Las opciones originales se mueven al sentido de las manecillas del reloj.");
        Console.WriteLine("Con `'` se mueven en contra. \n");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
