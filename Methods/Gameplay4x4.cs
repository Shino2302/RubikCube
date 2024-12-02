namespace CubeRubikInArrays.Gameplay4x4;

using CubeRubikInArrays.Cube4x4;

public class Gameplay4x4
{
    private Cube4x4 _yourCube;

    public Gameplay4x4(Cube4x4 yourCube)
    {
        _yourCube = yourCube;
        _yourCube.Display();
    }

    public void MovesFactory(string moveSelected)
    {
        switch(moveSelected)
        {
            case "R": /*Method 1*/
                _yourCube.MoveR('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "R'": /*Method 2*/
                _yourCube.MoveR('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "L": /*Method 3*/
                _yourCube.MoveL('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "L'": /*Method 4*/
                _yourCube.MoveR('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "F": /*Method 5*/
                _yourCube.MoveF('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "F'": /*Method 6*/
                _yourCube.MoveF('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "B": /*Method 7*/
                _yourCube.MoveB('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "B'": /*Method 8*/
                _yourCube.MoveB('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "U": /*Method 9*/
                _yourCube.MoveU('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "U'": /*Method 10*/
                _yourCube.MoveU('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "D": /*Method 11*/
                _yourCube.MoveD('R');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "D'": /*Method 12*/
                _yourCube.MoveD('L');
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "CLU": /*Method 13*/
                _yourCube.MoveCenterLeftToUp();
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "CLD": /*Method 14*/
                _yourCube.MoveCenterLeftToDown();
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "CRU": /*Method 15*/
                _yourCube.MoveCenterRightToUp();
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "CRD": /*Method 16*/
                _yourCube.MoveCenterRightToDown();
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "CUR": /*Method 17*/
                _yourCube.MoveCenterUpToRight();
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            case "CUL": /*Method 18*/
                _yourCube.MoveCenterUpToLeft();
                Console.WriteLine("\n");
                _yourCube.Display();
            break;

            default:
                Console.WriteLine("Error");
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
        Console.WriteLine("CLU: Centro Izquierda Arriba.");
        Console.WriteLine("CLD: Centro Izquierda Abajo.");
        Console.WriteLine("CRU: Centro Derecha Arriba.");
        Console.WriteLine("CRD: Centro Derecha Abajo.");
        Console.WriteLine("CUR: Centro Arriba a la Derecha.");
        Console.WriteLine("CDR: Centro Abajo a la Derecha.");
        Console.WriteLine("CUL: Centro Arriba a la Izquierda.");
        // Console.WriteLine("CDL: Centro Abajo a la Izquierda.");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Las opciones originales se mueven al sentido de las manecillas del reloj.");
        Console.WriteLine("Con `'` se mueven en contra. \n");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
