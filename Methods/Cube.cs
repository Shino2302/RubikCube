using System.ComponentModel;

namespace CubeRubikInArrays.Cube;

public class Cube
{
    private char[,] faces;

    public Cube()
    {
        faces = new char[6, 9]
        {
            { 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W' }, // Cara superior (blanca)
            { 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y' }, // Cara inferior (amarilla)
            { 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R' }, // Cara frontal (roja)
            { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' }, // Cara trasera (naranja)
            { 'G', 'G', 'G', 'G', 'G', 'G', 'G', 'G', 'G' }, // Cara izquierda (verde)
            { 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B' }  // Cara derecha (azul)
        };
    }
    public void ListPlainMatrix()
    {
        for (int i = 0; i < 6; i++)
            for(int j = 0; j < 9; j++)
            {
                if( j == 0 )
                    Console.Write("\n");
                Console.Write($"[{i},{j}]: {faces[i,j]}, ");
            }
            Console.WriteLine("\n");
    }
    public void Display()
    {
        // Mostrar cara superior
        Console.WriteLine("       {0} {1} {2}", faces[0, 0], faces[0, 1], faces[0, 2]);
        Console.WriteLine("       {0} {1} {2}", faces[0, 3], faces[0, 4], faces[0, 5]);
        Console.WriteLine("       {0} {1} {2}", faces[0, 6], faces[0, 7], faces[0, 8]);

        // Mostrar las caras laterales (Izquierda, Frontal, Derecha, Trasera)
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("{0} {1} {2}  {3} {4} {5}  {6} {7} {8}  {9} {10} {11}",
                faces[4, i * 3], faces[4, i * 3 + 1], faces[4, i * 3 + 2], // Izquierda
                faces[2, i * 3], faces[2, i * 3 + 1], faces[2, i * 3 + 2], // Frontal
                faces[5, i * 3], faces[5, i * 3 + 1], faces[5, i * 3 + 2], // Derecha
                faces[3, i * 3], faces[3, i * 3 + 1], faces[3, i * 3 + 2]  // Trasera
            );
        }

        // Mostrar cara inferior
        Console.WriteLine("       {0} {1} {2}", faces[1, 0], faces[1, 1], faces[1, 2]);
        Console.WriteLine("       {0} {1} {2}", faces[1, 3], faces[1, 4], faces[1, 5]);
        Console.WriteLine("       {0} {1} {2}", faces[1, 6], faces[1, 7], faces[1, 8]);
    }
    public void MoveToRight(int face)
    {
        char[] temporal = new char[9];
        for(int i = 0; i < 9; i++)
            temporal[i] = faces[face, i];
        faces[face, 0] = temporal[6];
        faces[face, 1] = temporal[3];
        faces[face, 2] = temporal[0];
        faces[face, 3] = temporal[7];
        faces[face, 4] = temporal[4];
        faces[face, 5] = temporal[1];
        faces[face, 6] = temporal[8];
        faces[face, 7] = temporal[5];
        faces[face, 8] = temporal[2];
    }
    public void MoveToLeft(int face)
    {
        char[] temporal = new char[9];
        for(int i = 0; i < 9; i++)
            temporal[i] = faces[face,i];
        faces[face, 0] = temporal[2];
        faces[face, 1] = temporal[5];
        faces[face, 2] = temporal[8];
        faces[face, 3] = temporal[1];
        faces[face, 4] = temporal[4];
        faces[face, 5] = temporal[7];
        faces[face, 6] = temporal[0];
        faces[face, 7] = temporal[3];
        faces[face, 8] = temporal[6];
    }
    /*U de Up para movimientos de la cara superior*/
    public void MoveU(char direction)
    {
        if(direction == 'L')
        {
            MoveToLeft(0);
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++) 
                temp[i] = faces[2, i]; // Frontal superior

            for (int i = 0; i < 3; i++)
            {
                faces[2, i] = faces[4, i]; // Derecha -> Frontal
                faces[4, i] = faces[3, i]; // Trasera -> Derecha
                faces[3, i] = faces[5, i]; // Izquierda -> Trasera
                faces[5, i] = temp[i];     // Frontal -> Izquierda
            }
        }
        else if(direction == 'R')
        {
            MoveToRight(0);
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++) 
                temp[i] = faces[2, i]; // Frontal superior

            for (int i = 0; i < 3; i++)
            {
                faces[2, i] = faces[5, i]; // Derecha -> Frontal
                faces[5, i] = faces[3, i]; // Trasera -> Derecha
                faces[3, i] = faces[4, i]; // Izquierda -> Trasera
                faces[4, i] = temp[i];     // Frontal -> Izquierda
            }    
        }
        else
            Console.WriteLine("Opción irreconosible");
    }
    /*D de Down para movimientos de la cara inferior*/
    public void MoveD(char direction)
    {
        if(direction == 'L')
        {
            MoveToLeft(1);
            char[] temporal = new char[12];
            /*Tomando cara Frontal 'F'*/
            temporal[0] = faces[2, 6];
            temporal[1] = faces[2, 7];
            temporal[2] = faces[2, 8];
            /*Tomando cara Trasera 'B'*/
            temporal[3] = faces[3, 6];
            temporal[4] = faces[3, 7];
            temporal[5] = faces[3, 8];
            /*Tomando cara Izquierda 'L'*/
            temporal[6] = faces[4, 6];
            temporal[7] = faces[4, 7];
            temporal[8] = faces[4, 8];
            /*Tomando cara Derecha 'R'*/
            temporal[9] = faces[5, 6];
            temporal[10] = faces[5, 7];
            temporal[11] = faces[5, 8];

            faces[2,6] = temporal[9];
            faces[2,7] = temporal[10];
            faces[2,8] = temporal[11];
            
            faces[4,6] = temporal[0];
            faces[4,7] = temporal[1];
            faces[4,8] = temporal[2];
            
            faces[3,6] = temporal[6];
            faces[3,7] = temporal[7];
            faces[3,8] = temporal[8];
            
            faces[5,6] = temporal[3];
            faces[5,7] = temporal[4];
            faces[5,8] = temporal[5];
        }
        else if(direction == 'R')
        {
            MoveToRight(1);
            char[] temporal = new char[12];
            /*Tomando cara Frontal 'F'*/
            temporal[0] = faces[2, 6];
            temporal[1] = faces[2, 7];
            temporal[2] = faces[2, 8];
            /*Tomando cara Trasera 'B'*/
            temporal[3] = faces[3, 6];
            temporal[4] = faces[3, 7];
            temporal[5] = faces[3, 8];
            /*Tomando cara Izquierda 'L'*/
            temporal[6] = faces[4, 6];
            temporal[7] = faces[4, 7];
            temporal[8] = faces[4, 8];
            /*Tomando cara Derecha 'R'*/
            temporal[9] = faces[5, 6];
            temporal[10] = faces[5, 7];
            temporal[11] = faces[5, 8];

            faces[2,6] = temporal[6];
            faces[2,7] = temporal[7];
            faces[2,8] = temporal[8];

            faces[4,6] = temporal[3];
            faces[4,7] = temporal[4];
            faces[4,8] = temporal[5];

            faces[3,6] = temporal[9];
            faces[3,7] = temporal[10];
            faces[3,8] = temporal[11];

            faces[5,6] = temporal[0];
            faces[5,7] = temporal[1];
            faces[5,8] = temporal[2];
        }
        else
            Console.WriteLine("Opción irreconosible");
    }
    /*L de Left para movimientos de la cara izquierda*/
    public void MoveL(char direction)
    {
        if(direction == 'L')
        {
            MoveToLeft(4);
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++) 
                temp[i] = faces[0, i * 3]; // Superior izquierda

            for (int i = 0; i < 3; i++)
            {
                faces[0, i * 3] = faces[2, i * 3];     // Frontal -> Superior
                faces[2, i * 3] = faces[1, i * 3];     // Inferior -> Frontal
                faces[1, i * 3] = faces[3, 8 - i * 3]; // Trasera -> Inferior
                faces[3, 8 - i * 3] = temp[i];         // Superior -> Trasera
            }
        }
        else if(direction == 'R')
        {
            MoveToRight(4);
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++) 
                temp[i] = faces[0, i * 3]; // Frontal inferior

            for (int i = 0; i < 3; i++)
            {
                faces[0, i * 3] = faces[3, 8 - i * 3]; // Trasera -> Superior
                faces[3, 8 - i * 3] = faces[1, i * 3]; // Inferior -> Trasera
                faces[1, i * 3] = faces[2, i * 3];     // Frontal -> Inferior
                faces[2, i * 3] = temp[i];             // Superior -> Frontal
            }    
        }
        else
            Console.WriteLine("Opción irreconosible");
    }

    /*R de Right para movimientos de la cara derecha*/
    public void MoveR(char direction)
    {
        if(direction == 'L')
        {
            MoveToLeft(5);
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++) 
                temp[i] = faces[0, 2 + i * 3]; // Superior derecha

            for (int i = 0; i < 3; i++)
            {
                faces[0, 2 + i * 3] = faces[3, 6 - i * 3]; // Trasera -> Superior
                faces[3, 6 - i * 3] = faces[1, 2 + i * 3]; // Inferior -> Trasera
                faces[1, 2 + i * 3] = faces[2, 2 + i * 3]; // Frontal -> Inferior
                faces[2, 2 + i * 3] = temp[i];             // Superior -> Frontal
            }
        }
        else if(direction == 'R')
        {
            MoveToRight(5);
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++) 
                temp[i] = faces[0, 2 + i * 3]; // Superior derecha

            for (int i = 0; i < 3; i++)
            {
                faces[0, 2 + i * 3] = faces[2, 2 + i * 3]; // Frontal -> Superior
                faces[2, 2 + i * 3] = faces[1, 2 + i * 3]; // Inferior -> Frontal
                faces[1, 2 + i * 3] = faces[3, 6 - i * 3]; // Trasera -> Inferior
                faces[3, 6 - i * 3] = temp[i];             // Superior -> Trasera
            }    
        }
        else
            Console.WriteLine("Opción irreconosible");
    }

    /*F de Front para movimientos de la cara del frente*/
    public void MoveF(char direction)
    {
        if(direction == 'L')
        {
            MoveToLeft(2);
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++) 
                temp[i] = faces[0, 6 + i]; // Superior inferior

            faces[0, 6] = faces[5, 0];
            faces[0, 7] = faces[5, 3];
            faces[0, 8] = faces[5, 6];
            faces[5, 0] = faces[1, 2];
            faces[5, 3] = faces[1, 1];
            faces[5, 6] = faces[1, 0];
            faces[1, 0] = faces[4, 8];
            faces[1, 1] = faces[4, 5];
            faces[1, 2] = faces[4, 2];
            faces[4, 8] = temp[0];
            faces[4, 5] = temp[1];
            faces[4, 2] = temp[2];
        }
        else if(direction == 'R')
        {
            MoveToRight(2);
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++) 
                temp[i] = faces[0, 6 + i]; // Superior inferior

            faces[0, 6] = faces[4, 8];
            faces[0, 7] = faces[4, 5];
            faces[0, 8] = faces[4, 2];
            faces[4, 2] = faces[1, 0];
            faces[4, 5] = faces[1, 1];
            faces[4, 8] = faces[1, 2];
            faces[1, 0] = faces[5, 6];
            faces[1, 1] = faces[5, 3];
            faces[1, 2] = faces[5, 0];
            faces[5, 0] = temp[0];
            faces[5, 3] = temp[1];
            faces[5, 6] = temp[2];  
        }
        else
            Console.WriteLine("Opción irreconosible");
    }

    /*B de Back para movimientos de la cara de atras*/
    public void MoveB(char direction)
    {
        if(direction == 'L')
        {
            MoveToLeft(3);
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++) 
                temp[i] = faces[0, i]; // Superior superior

            faces[0, 0] = faces[4, 6];
            faces[0, 1] = faces[4, 3];
            faces[0, 2] = faces[4, 0];
            faces[4, 0] = faces[1, 6];
            faces[4, 3] = faces[1, 7];
            faces[4, 6] = faces[1, 8];
            faces[1, 6] = faces[5, 8];
            faces[1, 7] = faces[5, 5];
            faces[1, 8] = faces[5, 2];
            faces[5, 2] = temp[2];
            faces[5, 5] = temp[1];
            faces[5, 8] = temp[0];  
        }
        else if(direction == 'R')
        {
            MoveToRight(3);
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++) 
                temp[i] = faces[0, i]; // Superior superior

            faces[0, 0] = faces[5, 2];
            faces[0, 1] = faces[5, 5];
            faces[0, 2] = faces[5, 8];
            faces[5, 2] = faces[1, 8];
            faces[5, 5] = faces[1, 7];
            faces[5, 8] = faces[1, 6];
            faces[1, 8] = faces[4, 0];
            faces[1, 7] = faces[4, 3];
            faces[1, 6] = faces[4, 6];
            faces[4, 0] = temp[2];
            faces[4, 3] = temp[1];
            faces[4, 6] = temp[0];  
        }
        else
            Console.WriteLine("Opción irreconosible");
    }

    public void MoveCenterToUp()
    {
        char[] temporal = new char[12];
        temporal[0] = faces[0,1];
        temporal[1] = faces[0,4];
        temporal[2] = faces[0,7];
        temporal[3] = faces[2,1];
        temporal[4] = faces[2,4];
        temporal[5] = faces[2,7];
        temporal[6] = faces[1,1];
        temporal[7] = faces[1,4];
        temporal[8] = faces[1,7];
        temporal[9] = faces[3,1];
        temporal[10] = faces[3,4];
        temporal[11] = faces[3,7];
        /*Aplicar cambios*/
        faces[0,1] = temporal[3];
        faces[0,4] = temporal[4];
        faces[0,7] = temporal[5];
        faces[2,1] = temporal[6];
        faces[2,4] = temporal[7];
        faces[2,7] = temporal[8];
        faces[1,1] = temporal[9];
        faces[1,4] = temporal[10];
        faces[1,7] = temporal[11];
        faces[3,1] = temporal[0];
        faces[3,4] = temporal[1];
        faces[3,7] = temporal[2];
    }
    public void MoveCenterToDown()
    {
        char[] temporal = new char[12];
        temporal[0] = faces[0,1];
        temporal[1] = faces[0,4];
        temporal[2] = faces[0,7];
        temporal[3] = faces[2,1];
        temporal[4] = faces[2,4];
        temporal[5] = faces[2,7];
        temporal[6] = faces[1,1];
        temporal[7] = faces[1,4];
        temporal[8] = faces[1,7];
        temporal[9] = faces[3,1];
        temporal[10] = faces[3,4];
        temporal[11] = faces[3,7];
        /*Aplicar cambios*/
        faces[0,1] = temporal[9];
        faces[0,4] = temporal[10];
        faces[0,7] = temporal[11];
        faces[2,1] = temporal[0];
        faces[2,4] = temporal[1];
        faces[2,7] = temporal[2];
        faces[1,1] = temporal[3];
        faces[1,4] = temporal[4];
        faces[1,7] = temporal[5];
        faces[3,1] = temporal[6];
        faces[3,4] = temporal[7];
        faces[3,7] = temporal[8];
    }
    public void MoveCenterToLeft()
    {
        char[] temporal = new char[12];
        temporal[0] = faces[4,3];
        temporal[1] = faces[4,4];
        temporal[2] = faces[4,5];
        temporal[3] = faces[2,3];
        temporal[4] = faces[2,4];
        temporal[5] = faces[2,5];
        temporal[6] = faces[5,3];
        temporal[7] = faces[5,4];
        temporal[8] = faces[5,5];
        temporal[9] = faces[3,3];
        temporal[10] = faces[3,4];
        temporal[11] = faces[3,5];

        /*Aplicar cambios*/
        faces[4,3] = temporal[3];
        faces[4,4] = temporal[4];
        faces[4,5] = temporal[5];
        faces[2,3] = temporal[6];
        faces[2,4] = temporal[7];
        faces[2,5] = temporal[8];
        faces[5,3] = temporal[9];
        faces[5,4] = temporal[10];
        faces[5,5] = temporal[11];
        faces[3,3] = temporal[0];
        faces[3,4] = temporal[1];
        faces[3,5] = temporal[2];
    }
    public void MoveCenterToRight()
    {
        char[] temporal = new char[12];
        temporal[0] = faces[4,3];
        temporal[1] = faces[4,4];
        temporal[2] = faces[4,5];
        temporal[3] = faces[2,3];
        temporal[4] = faces[2,4];
        temporal[5] = faces[2,5];
        temporal[6] = faces[5,3];
        temporal[7] = faces[5,4];
        temporal[8] = faces[5,5];
        temporal[9] = faces[3,3];
        temporal[10] = faces[3,4];
        temporal[11] = faces[3,5];

        /*Aplicar cambios*/
        faces[4,3] = temporal[9];
        faces[4,4] = temporal[10];
        faces[4,5] = temporal[11];
        faces[2,3] = temporal[0];
        faces[2,4] = temporal[1];
        faces[2,5] = temporal[2];
        faces[5,3] = temporal[3];
        faces[5,4] = temporal[4];
        faces[5,5] = temporal[5];
        faces[3,3] = temporal[6];
        faces[3,4] = temporal[7];
        faces[3,5] = temporal[8];
    }

    public void MoveCenterToUpLR()
    {
        char[] temporal = new char[12];
        /*Tomando el centro lateral de la cara 'U'*/
        temporal[0] = faces[0,3];
        temporal[1] = faces[0,4];
        temporal[2] = faces[0,5];
        /*Tomando el centro de la cara 'L'*/
        temporal[3] = faces[4,1];
        temporal[4] = faces[4,4];
        temporal[5] = faces[4,7];
        /*Tomando el centro lateral de la cara 'D'*/
        temporal[6] = faces[1,3];
        temporal[7] = faces[1,4];
        temporal[8] = faces[1,5];
        /*Tomando el centro de la cara 'R'*/
        temporal[9] = faces[5,7];
        temporal[10] = faces[5,4];
        temporal[11] = faces[5,1];

        faces[0,3] = temporal[5];
        faces[0,4] = temporal[4];
        faces[0,5] = temporal[3];

        faces[5,1] = temporal[0];
        faces[5,4] = temporal[1];
        faces[5,7] = temporal[2];

        faces[1,5] = temporal[11];
        faces[1,4] = temporal[10];
        faces[1,3] = temporal[9]; 

        faces[4,1] = temporal[6];
        faces[4,4] = temporal[7];
        faces[4,7] = temporal[8];
    }
    public void MoveCenterToUpRL()
    {
        char[] temporal = new char[12];
        /*Tomando el centro lateral de la cara 'U'*/
        temporal[0] = faces[0,3];
        temporal[1] = faces[0,4];
        temporal[2] = faces[0,5];
        /*Tomando el centro de la cara 'L'*/
        temporal[3] = faces[4,1];
        temporal[4] = faces[4,4];
        temporal[5] = faces[4,7];
        /*Tomando el centro lateral de la cara 'D'*/
        temporal[6] = faces[1,3];
        temporal[7] = faces[1,4];
        temporal[8] = faces[1,5];
        /*Tomando el centro de la cara 'R'*/
        temporal[9] = faces[5,7];
        temporal[10] = faces[5,4];
        temporal[11] = faces[5,1];

        faces[0,3] = temporal[11];
        faces[0,4] = temporal[10];
        faces[0,5] = temporal[9];

        faces[5,1] = temporal[6];
        faces[5,4] = temporal[7];
        faces[5,7] = temporal[8];

        faces[1,5] = temporal[5];
        faces[1,4] = temporal[4];
        faces[1,3] = temporal[3]; 

        faces[4,1] = temporal[0];
        faces[4,4] = temporal[1];
        faces[4,7] = temporal[2];
    }
}