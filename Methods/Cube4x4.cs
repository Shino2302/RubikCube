using System.Runtime.CompilerServices;

namespace CubeRubikInArrays.Cube4x4;

public class Cube4x4
{
    private char[,] faces;

    public Cube4x4()
    {
        faces = new char[6, 16] 
        {
            {'W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W'},
            {'Y','Y','Y','Y','Y','Y','Y','Y','Y','Y','Y','Y','Y','Y','Y','Y'},
            {'R','R','R','R','R','R','R','R','R','R','R','R','R','R','R','R'},
            {'O','O','O','O','O','O','O','O','O','O','O','O','O','O','O','O'},
            {'G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G'},
            {'B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B'}
        };
    }
    public void Display()
    {
        Console.WriteLine("         {0} {1} {2} {3}", faces[0,0], faces[0,1], faces[0,2], faces[0,3]);
        Console.WriteLine("         {0} {1} {2} {3}", faces[0,4], faces[0,5], faces[0,6], faces[0,7]);
        Console.WriteLine("         {0} {1} {2} {3}", faces[0,8], faces[0,9], faces[0,10], faces[0,11]);
        Console.WriteLine("         {0} {1} {2} {3}", faces[0,12], faces[0,13], faces[0,14], faces[0,15]);

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("{0} {1} {2} {3}  {4} {5} {6} {7}  {8} {9} {10} {11}  {12} {13} {14} {15}",
                faces[4, i * 4], faces[4, i * 4 + 1], faces[4, i * 4 + 2], faces[4, i * 4 + 3],// Izquierda
                faces[2, i * 4], faces[2, i * 4 + 1], faces[2, i * 4 + 2], faces[2, i * 4 + 3],// Frontal
                faces[5, i * 4], faces[5, i * 4 + 1], faces[5, i * 4 + 2], faces[5, i * 4 + 3],// Derecha
                faces[3, i * 4], faces[3, i * 4 + 1], faces[3, i * 4 + 2], faces[3, i * 4 + 3]  // Trasera
            );
        }

        Console.WriteLine("         {0} {1} {2} {3}", faces[1,0], faces[1,1], faces[1,2], faces[1,3]);
        Console.WriteLine("         {0} {1} {2} {3}", faces[1,4], faces[1,5], faces[1,6], faces[1,7]);
        Console.WriteLine("         {0} {1} {2} {3}", faces[1,8], faces[1,9], faces[1,10], faces[1,11]);
        Console.WriteLine("         {0} {1} {2} {3}", faces[1,12], faces[1,13], faces[1,14], faces[1,15]);
    }
    /*Method 1*/
    public void MoveToRight(int face) 
    {
        char[] temporal = new char[16];
        for(int i = 0; i < temporal.Length; i++)
            temporal[i] = faces[face, i];
        faces[face, 0] = temporal[12];
        faces[face, 1] = temporal[8];
        faces[face, 2] = temporal[4];
        faces[face, 3] = temporal[0];
        faces[face, 4] = temporal[13];
        faces[face, 5] = temporal[9];
        faces[face, 6] = temporal[6];
        faces[face, 7] = temporal[1];
        faces[face, 8] = temporal[14];
        faces[face, 9] = temporal[10];
        faces[face, 10] = temporal[6];
        faces[face, 11] = temporal[2];
        faces[face, 12] = temporal[15];
        faces[face, 13] = temporal[11];
        faces[face, 14] = temporal[7];
        faces[face, 15] = temporal[3];
    }
    /*Method 2*/
    public void MoveToLeft(int face) 
    {
        char[] temporal = new char[16];
        for(int i = 0; i < temporal.Length; i++)
            temporal[i] = faces[face, i];
        faces[face, 0] = temporal[3];
        faces[face, 1] = temporal[7];
        faces[face, 2] = temporal[11];
        faces[face, 3] = temporal[15];
        faces[face, 4] = temporal[1];
        faces[face, 5] = temporal[6];
        faces[face, 6] = temporal[10];
        faces[face, 7] = temporal[14];
        faces[face, 8] = temporal[2];
        faces[face, 9] = temporal[5];
        faces[face, 10] = temporal[9];
        faces[face, 11] = temporal[13];
        faces[face, 12] = temporal[0];
        faces[face, 13] = temporal[4];
        faces[face, 14] = temporal[8];
        faces[face, 15] = temporal[12];
    }
    /*Method 3*/
    public void MoveU(char direction)
    {
        if(direction == 'L')
        {
            MoveToLeft(0);
            char[] temporal = new char[16];
            
            /*Frontal superior*/
            temporal[0] = faces[2, 0];
            temporal[1] = faces[2, 1];
            temporal[2] = faces[2, 2];
            temporal[3] = faces[2, 3];
            /*Cara Trasera Superior*/
            temporal[4] = faces[3, 0];
            temporal[5] = faces[3, 1];
            temporal[6] = faces[3, 2];
            temporal[7] = faces[3, 3];
            /*Cara Izquierda Superior*/
            temporal[8] = faces[4, 0];
            temporal[9] = faces[4, 1];
            temporal[10] = faces[4, 2];
            temporal[11] = faces[4, 3];
            /*Cara Derecha Superior*/
            temporal[12] = faces[5, 0];
            temporal[13] = faces[5, 1];
            temporal[14] = faces[5, 2];
            temporal[15] = faces[5, 3];
            
            /*Cuando movemos la cara superior o "U'"
              a la izquierda todas las caras del cubo
              se mueven hacia la derecha*/
            
            faces[4, 0] = temporal[4];
            faces[4, 1] = temporal[5];
            faces[4, 2] = temporal[6];
            faces[4, 3] = temporal[7];

            faces[2, 0] = temporal[8];
            faces[2, 1] = temporal[9];
            faces[2, 2] = temporal[10];
            faces[2, 3] = temporal[11];

            faces[5, 0] = temporal[0];
            faces[5, 1] = temporal[1];
            faces[5, 2] = temporal[2];
            faces[5, 3] = temporal[3];

            faces[3, 0] = temporal[12];
            faces[3, 1] = temporal[13];
            faces[3, 2] = temporal[14];
            faces[3, 3] = temporal[15];
        }
        else if(direction == 'R')
        {
            MoveToLeft(0);
            char[] temporal = new char[16];
            
            /*Frontal superior*/
            temporal[0] = faces[2, 0];
            temporal[1] = faces[2, 1];
            temporal[2] = faces[2, 2];
            temporal[3] = faces[2, 3];
            /*Cara Trasera Superior*/
            temporal[4] = faces[3, 0];
            temporal[5] = faces[3, 1];
            temporal[6] = faces[3, 2];
            temporal[7] = faces[3, 3];
            /*Cara Izquierda Superior*/
            temporal[8] = faces[4, 0];
            temporal[9] = faces[4, 1];
            temporal[10] = faces[4, 2];
            temporal[11] = faces[4, 3];
            /*Cara Derecha Superior*/
            temporal[12] = faces[5, 0];
            temporal[13] = faces[5, 1];
            temporal[14] = faces[5, 2];
            temporal[15] = faces[5, 3];
            
            /*Cuando movemos la cara superior o "U"
              a la derecha todas las caras del cubo
              se mueven hacia la izquierda*/
            
            faces[4, 0] = temporal[0];
            faces[4, 1] = temporal[1];
            faces[4, 2] = temporal[2];
            faces[4, 3] = temporal[3];

            faces[2, 0] = temporal[12];
            faces[2, 1] = temporal[13];
            faces[2, 2] = temporal[14];
            faces[2, 3] = temporal[15];

            faces[5, 0] = temporal[4];
            faces[5, 1] = temporal[5];
            faces[5, 2] = temporal[6];
            faces[5, 3] = temporal[7];

            faces[3, 0] = temporal[8];
            faces[3, 1] = temporal[9];
            faces[3, 2] = temporal[10];
            faces[3, 3] = temporal[11];
        }
        else
            Console.WriteLine("Error, opción no valida");
    }
    /*Method 4*/
    public void MoveD(int direction)
    {
        if(direction == 'L')
        {
            char[] temporal = new char[16];

            temporal[0] = faces[2, 12];
            temporal[1] = faces[2, 13];
            temporal[2] = faces[2, 14];
            temporal[3] = faces[2, 15];

            temporal[4] = faces[3, 12];
            temporal[5] = faces[3, 13];
            temporal[6] = faces[3, 14];
            temporal[7] = faces[3, 15];

            temporal[8] = faces[4, 12];
            temporal[9] = faces[4, 13];
            temporal[10] = faces[4, 14];
            temporal[11] = faces[4, 15];

            temporal[12] = faces[5, 12];
            temporal[13] = faces[5, 13];
            temporal[14] = faces[5, 14];
            temporal[15] = faces[5, 15];

            faces[4, 12] = temporal[0];
            faces[4, 13] = temporal[1];
            faces[4, 14] = temporal[2];
            faces[4, 15] = temporal[3];

            faces[3, 12] = temporal[8];
            faces[3, 13] = temporal[9];
            faces[3, 14] = temporal[10];
            faces[3, 15] = temporal[11];

            faces[5, 12] = temporal[4];
            faces[5, 13] = temporal[5];
            faces[5, 14] = temporal[6];
            faces[5, 15] = temporal[7];

            faces[2, 12] = temporal[12];
            faces[2, 13] = temporal[13];
            faces[2, 14] = temporal[14];
            faces[2, 15] = temporal[15];
        }
        else if(direction == 'R')
        {
            char[] temporal = new char[16];

            temporal[0] = faces[2, 12];
            temporal[1] = faces[2, 13];
            temporal[2] = faces[2, 14];
            temporal[3] = faces[2, 15];

            temporal[4] = faces[3, 12];
            temporal[5] = faces[3, 13];
            temporal[6] = faces[3, 14];
            temporal[7] = faces[3, 15];

            temporal[8] = faces[4, 12];
            temporal[9] = faces[4, 13];
            temporal[10] = faces[4, 14];
            temporal[11] = faces[4, 15];

            temporal[12] = faces[5, 12];
            temporal[13] = faces[5, 13];
            temporal[14] = faces[5, 14];
            temporal[15] = faces[5, 15];

            faces[4, 12] = temporal[4];
            faces[4, 13] = temporal[5];
            faces[4, 14] = temporal[6];
            faces[4, 15] = temporal[7];

            faces[3, 12] = temporal[12];
            faces[3, 13] = temporal[13];
            faces[3, 14] = temporal[14];
            faces[3, 15] = temporal[15];

            faces[5, 12] = temporal[0];
            faces[5, 13] = temporal[1];
            faces[5, 14] = temporal[2];
            faces[5, 15] = temporal[3];

            faces[2, 12] = temporal[8];
            faces[2, 13] = temporal[9];
            faces[2, 14] = temporal[10];
            faces[2, 15] = temporal[11];
        }
        else
            Console.WriteLine("Error, opción no valida");
    }
    /*Method 5*/
    public void MoveF(char direction)
    {
        char[] temporal = new char[16];
        /*Mapeando cara Superior "U" */
        temporal[0] = faces[0,12];
        temporal[1] = faces[0,13];
        temporal[2] = faces[0,14];
        temporal[3] = faces[0,15];
        /*Mapeando cara Izquierda "L" */
        temporal[4] = faces[4,3];
        temporal[5] = faces[4,7];
        temporal[6] = faces[4,11];
        temporal[7] = faces[4,15];
        /*Mapeando cara Inferior "D" */
        temporal[8] = faces[1,0];
        temporal[9] = faces[1,1];
        temporal[10] = faces[1,2];
        temporal[11] = faces[1,3];
        /*Mapeando cara Derecha "R" */
        temporal[12] = faces[5,0];
        temporal[13] = faces[5,4];
        temporal[14] = faces[5,8];
        temporal[15] = faces[5,12];

        if(direction == 'L')
        {
            MoveToLeft(2);

            faces[0, 12] = temporal[12];
            faces[0, 13] = temporal[13];
            faces[0, 14] = temporal[14];
            faces[0, 15] = temporal[15];

            faces[4, 3] = temporal[3];
            faces[4, 7] = temporal[2];
            faces[4, 11] = temporal[1];
            faces[4, 15] = temporal[0];

            faces[1, 0] = temporal[4];
            faces[1, 1] = temporal[5];
            faces[1, 2] = temporal[6];
            faces[1, 3] = temporal[7];

            faces[5, 0] = temporal[11];
            faces[5, 4] = temporal[10];
            faces[5, 8] = temporal[9];
            faces[5, 12] = temporal[8];
        }
        else if(direction == 'R')
        {
             MoveToRight(2);

            faces[0, 12] = temporal[7];
            faces[0, 13] = temporal[6];
            faces[0, 14] = temporal[5];
            faces[0, 15] = temporal[4];

            faces[4, 3] = temporal[8];
            faces[4, 7] = temporal[9];
            faces[4, 11] = temporal[10];
            faces[4, 15] = temporal[11];

            faces[1, 0] = temporal[15];
            faces[1, 1] = temporal[14];
            faces[1, 2] = temporal[13];
            faces[1, 3] = temporal[12];

            faces[5, 0] = temporal[0];
            faces[5, 4] = temporal[1];
            faces[5, 8] = temporal[2];
            faces[5, 12] = temporal[3];
        }
        else 
            Console.WriteLine("Error, opción no valida");
    }
    /*Method 6*/
    public void MoveB(char direction)
    {
        char[] temporal = new char[16];
        /*Mapeando Cara Superior "U" desde la
        perspectiva de la cara trasera "B" */
        temporal[0] = faces[0,0];
        temporal[1] = faces[0,1];
        temporal[2] = faces[0,2];
        temporal[3] = faces[0,3];
        /*Mapeando la Cara Izquierda de la "B"*/
        temporal[4] = faces[5,3];
        temporal[5] = faces[5,7];
        temporal[6] = faces[5,11];
        temporal[7] = faces[5,15];
        /*Mapeando Cara Inferior "D"*/
        temporal[8] = faces[1,12];
        temporal[9] = faces[1,13];
        temporal[10] = faces[1,14];
        temporal[11] = faces[1,15];
        /*Mapeando la Cara Derecha de la "B"*/
        temporal[12] = faces[4,0];
        temporal[13] = faces[4,4];
        temporal[14] = faces[4,8];
        temporal[15] = faces[4,12];

        if(direction == 'L')
        {
            MoveToLeft(3);
            faces[0, 0] = temporal[15];
            faces[0, 1] = temporal[14];
            faces[0, 2] = temporal[13];
            faces[0, 3] = temporal[12];

            faces[5, 3] = temporal[0];
            faces[5, 7] = temporal[1];
            faces[5, 11] = temporal[2];
            faces[5, 15] = temporal[3];

            faces[1, 12] = temporal[4];
            faces[1, 13] = temporal[5];
            faces[1, 14] = temporal[6];
            faces[1, 15] = temporal[7];

            faces[4, 0] = temporal[11];
            faces[4, 4] = temporal[10];
            faces[4, 8] = temporal[9];
            faces[4, 12] = temporal[8];

        }
        else if(direction == 'R')
        {
            MoveToRight(3);
            faces[0, 0] = temporal[4];
            faces[0, 1] = temporal[5];
            faces[0, 2] = temporal[6];
            faces[0, 3] = temporal[7];

            faces[5, 3] = temporal[11];
            faces[5, 7] = temporal[10];
            faces[5, 11] = temporal[9];
            faces[5, 15] = temporal[8];

            faces[1, 12] = temporal[15];
            faces[1, 13] = temporal[14];
            faces[1, 14] = temporal[13];
            faces[1, 15] = temporal[12];

            faces[4, 0] = temporal[3];
            faces[4, 4] = temporal[2];
            faces[4, 8] = temporal[1];
            faces[4, 12] = temporal[0];

        }
        else
            Console.WriteLine("Error, opción no valida");
    }
    /*Method 7*/
    public void MoveL(char direction)
    {
        char[] temporal = new char[16];
        /*Mapeo de "U" */
        temporal[0] = faces[0,0];
        temporal[1] = faces[0,4];
        temporal[2] = faces[0,8];
        temporal[3] = faces[0,12];
        /*Mapeo de "B" */
        temporal[4] = faces[1,0];
        temporal[5] = faces[1,4];
        temporal[6] = faces[1,8];
        temporal[7] = faces[1,12];
        /*Mapedo de "L" */
        temporal[8] = faces[3,3];
        temporal[9] = faces[3,7];
        temporal[10] = faces[3,11];
        temporal[11] = faces[3,15];
        /*Mapeo de "R" */
        temporal[12] = faces[2, 0];
        temporal[13] = faces[2, 4];
        temporal[14] = faces[2, 8];
        temporal[15] = faces[2, 12];

        if(direction == 'L')
        {
            MoveToLeft(4);
            faces[0,0] = temporal[12];
            faces[0,4] = temporal[13];
            faces[0,8] = temporal[14];
            faces[0,12] = temporal[15];

            faces[2,0] = temporal[4];
            faces[2,4] = temporal[5];
            faces[2,8] = temporal[6];
            faces[2,12] = temporal[7];

            faces[1,0] = temporal[8];
            faces[1,4] = temporal[9];
            faces[1,8] = temporal[10];
            faces[1,12] = temporal[11];

            faces[3, 3] = temporal[3];
            faces[3, 7] = temporal[2];
            faces[3, 11] = temporal[1];
            faces[3, 15] = temporal[0];
        }
        else if(direction == 'R')
        {
            MoveToRight(4);
            faces[0,0] = temporal[11];
            faces[0,4] = temporal[10];
            faces[0,8] = temporal[9];
            faces[0,12] = temporal[8];

            faces[2,0] = temporal[0];
            faces[2,4] = temporal[1];
            faces[2,8] = temporal[2];
            faces[2,12] = temporal[3];

            faces[1,0] = temporal[12];
            faces[1,4] = temporal[13];
            faces[1,8] = temporal[14];
            faces[1,12] = temporal[15];

            faces[3, 3] = temporal[7];
            faces[3, 7] = temporal[6];
            faces[3, 11] = temporal[5];
            faces[3, 15] = temporal[4];
        }
        else
            Console.WriteLine("Error, opción no valida");
    }
    /*Method 8*/
    public void MoveR(char direction)
    {
        char[] temporal = new char[16];
        /*Mapeo de cara Superior*/
        temporal[0] = faces[0, 15];
        temporal[1] = faces[0, 11];
        temporal[2] = faces[0, 7];
        temporal[3] = faces[0, 3];
        /*Mapeo de cara Izquierda*/
        temporal[4] = faces[2, 3];
        temporal[5] = faces[2, 7];
        temporal[6] = faces[2, 11];
        temporal[7] = faces[2, 15];
        /*Maped de cara Inferior*/
        temporal[8] = faces[1, 3];
        temporal[9] = faces[1, 7];
        temporal[10] = faces[1, 11];
        temporal[11] = faces[1, 15];
        /*Mapedo de cara Derecha*/
        temporal[12] = faces[3, 0];
        temporal[13] = faces[3, 4];
        temporal[14] = faces[3, 8];
        temporal[15] = faces[3, 12];

        if(direction == 'L')
        {
            MoveToLeft(5);
            faces[0, 15] = temporal[12];
            faces[0, 11] = temporal[13];
            faces[0, 7] = temporal[14];
            faces[0, 3] = temporal[15];
            
            faces[2, 3] = temporal[3];
            faces[2, 7] = temporal[2];
            faces[2, 11] = temporal[1];
            faces[2, 15] = temporal[0];

            faces[1, 3] = temporal[4];
            faces[1, 7] = temporal[5];
            faces[1, 11] = temporal[6];
            faces[1, 15] = temporal[7];

            faces[3, 0] = temporal[11];
            faces[3, 4] = temporal[10];
            faces[3, 8] = temporal[9];
            faces[3, 12] = temporal[8];
        }
        else if(direction == 'R')
        {
            MoveToRight(5);
            faces[0, 15] = temporal[7];
            faces[0, 11] = temporal[6];
            faces[0, 7] = temporal[5];
            faces[0, 3] = temporal[4];
            
            faces[2, 3] = temporal[8];
            faces[2, 7] = temporal[9];
            faces[2, 11] = temporal[10];
            faces[2, 15] = temporal[11];

            faces[1, 3] = temporal[15];
            faces[1, 7] = temporal[14];
            faces[1, 11] = temporal[13];
            faces[1, 15] = temporal[12];

            faces[3, 0] = temporal[0];
            faces[3, 4] = temporal[1];
            faces[3, 8] = temporal[2];
            faces[3, 12] = temporal[3];
        }
        else
            Console.WriteLine("Error, opción no valida");
    }
    /*Method 9*/
    public void MoveCenterLeftToUp()
    {
        char[] temporal = new char[16];
        /*Cara Superior*/
        temporal[0] = faces[0, 1];
        temporal[1] = faces[0, 5];
        temporal[2] = faces[0, 9];
        temporal[3] = faces[0, 13];
        /*Cara Frontal*/
        temporal[4] = faces[2, 1];
        temporal[5] = faces[2, 5];
        temporal[6] = faces[2, 9];
        temporal[7] = faces[2, 13];
        /*Cara Inferior*/
        temporal[8] = faces[1, 1];
        temporal[9] = faces[1, 5];
        temporal[10] = faces[1, 9];
        temporal[11] = faces[1, 13];
        /*Cara Posterior*/
        temporal[12] = faces[3, 2];
        temporal[13] = faces[3, 6];
        temporal[14] = faces[3, 10];
        temporal[15] = faces[3, 14];

        faces[0, 1] = temporal[4];
        faces[0, 5] = temporal[5];
        faces[0, 9] = temporal[6];
        faces[0, 13] = temporal[7];

        faces[2, 1] = temporal[8];
        faces[2, 5] = temporal[9];
        faces[2, 9] = temporal[10];
        faces[2, 13] = temporal[11];
        
        faces[1, 1] = temporal[15];
        faces[1, 5] = temporal[14];
        faces[1, 9] = temporal[13];
        faces[1, 13] = temporal[12];

        faces[3, 2] = temporal[3];
        faces[3, 6] = temporal[2];
        faces[3, 10] = temporal[1];
        faces[3, 14] = temporal[0];
    }
    /*Method 10*/
    public void MoveCenterLeftToDown()
    {
        char[] temporal = new char[16];
        /*Cara Superior*/
        temporal[0] = faces[0, 1];
        temporal[1] = faces[0, 5];
        temporal[2] = faces[0, 9];
        temporal[3] = faces[0, 13];
        /*Cara Frontal*/
        temporal[4] = faces[2, 1];
        temporal[5] = faces[2, 5];
        temporal[6] = faces[2, 9];
        temporal[7] = faces[2, 13];
        /*Cara Inferior*/
        temporal[8] = faces[1, 1];
        temporal[9] = faces[1, 5];
        temporal[10] = faces[1, 9];
        temporal[11] = faces[1, 13];
        /*Cara Posterior*/
        temporal[12] = faces[3, 2];
        temporal[13] = faces[3, 6];
        temporal[14] = faces[3, 10];
        temporal[15] = faces[3, 14];

        faces[0, 1] = temporal[15];
        faces[0, 5] = temporal[14];
        faces[0, 9] = temporal[13];
        faces[0, 13] = temporal[12];

        faces[2, 1] = temporal[0];
        faces[2, 5] = temporal[1];
        faces[2, 9] = temporal[2];
        faces[2, 13] = temporal[3];
        
        faces[1, 1] = temporal[4];
        faces[1, 5] = temporal[5];
        faces[1, 9] = temporal[6];
        faces[1, 13] = temporal[7];

        faces[3, 2] = temporal[11];
        faces[3, 6] = temporal[10];
        faces[3, 10] = temporal[9];
        faces[3, 14] = temporal[8];
    }
    /*Method 11*/
    public void MoveCenterRightToUp()
    {
        char[] temporal = new char[16];
        /*Cara Superior*/
        temporal[0] = faces[0, 2];
        temporal[1] = faces[0, 6];
        temporal[2] = faces[0, 10];
        temporal[3] = faces[0, 14];
        /*Cara Frontal*/
        temporal[4] = faces[2, 2];
        temporal[5] = faces[2, 6];
        temporal[6] = faces[2, 10];
        temporal[7] = faces[2, 14];
        /*Cara Inferior*/
        temporal[8] = faces[1, 2];
        temporal[9] = faces[1, 6];
        temporal[10] = faces[1, 10];
        temporal[11] = faces[1, 14];
        /*Cara Posterior*/
        temporal[12] = faces[3, 1];
        temporal[13] = faces[3, 5];
        temporal[14] = faces[3, 9];
        temporal[15] = faces[3, 13];

        faces[0, 2] = temporal[4];
        faces[0, 6] = temporal[5];
        faces[0, 10] = temporal[6];
        faces[0, 14] = temporal[7];

        faces[2, 2] = temporal[8];
        faces[2, 6] = temporal[9];
        faces[2, 10] = temporal[10];
        faces[2, 14] = temporal[11];
        
        faces[1, 2] = temporal[15];
        faces[1, 6] = temporal[14];
        faces[1, 10] = temporal[13];
        faces[1, 14] = temporal[12];

        faces[3, 1] = temporal[3];
        faces[3, 5] = temporal[2];
        faces[3, 9] = temporal[1];
        faces[3, 13] = temporal[0];
    }
    /*Method 12*/
    public void MoveCenterRightToDown()
    {
        char[] temporal = new char[16];
        /*Cara Superior*/
        temporal[0] = faces[0, 2];
        temporal[1] = faces[0, 6];
        temporal[2] = faces[0, 10];
        temporal[3] = faces[0, 14];
        /*Cara Frontal*/
        temporal[4] = faces[2, 2];
        temporal[5] = faces[2, 6];
        temporal[6] = faces[2, 10];
        temporal[7] = faces[2, 14];
        /*Cara Inferior*/
        temporal[8] = faces[1, 2];
        temporal[9] = faces[1, 6];
        temporal[10] = faces[1, 10];
        temporal[11] = faces[1, 14];
        /*Cara Posterior*/
        temporal[12] = faces[3, 1];
        temporal[13] = faces[3, 5];
        temporal[14] = faces[3, 9];
        temporal[15] = faces[3, 13];

        faces[0, 1] = temporal[15];
        faces[0, 5] = temporal[14];
        faces[0, 9] = temporal[13];
        faces[0, 13] = temporal[12];

        faces[2, 1] = temporal[0];
        faces[2, 5] = temporal[1];
        faces[2, 9] = temporal[2];
        faces[2, 13] = temporal[3];
        
        faces[1, 1] = temporal[4];
        faces[1, 5] = temporal[5];
        faces[1, 9] = temporal[6];
        faces[1, 13] = temporal[7];

        faces[3, 2] = temporal[11];
        faces[3, 6] = temporal[10];
        faces[3, 10] = temporal[9];
        faces[3, 14] = temporal[8];
    }
    /*Method 13*/
    public void MoveCenterUpToRight()
    {
        char[] temporal = new char[16];
        temporal[0] = faces[2, 4];
        temporal[1] = faces[2, 5];
        temporal[2] = faces[2, 6];
        temporal[3] = faces[2, 7];

        temporal[4] = faces[5, 4];
        temporal[5] = faces[5, 5];
        temporal[6] = faces[5, 6];
        temporal[7] = faces[5, 7];

        temporal[8] = faces[3, 4];
        temporal[9] = faces[3, 5];
        temporal[10] = faces[3, 6];
        temporal[11] = faces[3, 7];

        temporal[12] = faces[4, 4];
        temporal[13] = faces[4, 5];
        temporal[14] = faces[4, 6];
        temporal[15] = faces[4, 7];

        faces[2, 4] = temporal[12];
        faces[2, 5] = temporal[13];
        faces[2, 6] = temporal[14];
        faces[2, 7] = temporal[15];

        faces[5, 4] = temporal[0];
        faces[5, 5] = temporal[1];
        faces[5, 6] = temporal[2];
        faces[5, 7] = temporal[3];

        faces[3, 4] = temporal[4];
        faces[3, 5] = temporal[5];
        faces[3, 6] = temporal[6];
        faces[3, 7] = temporal[7];

        faces[4, 4] = temporal[8];
        faces[4, 5] = temporal[9];
        faces[4, 6] = temporal[10];
        faces[4, 7] = temporal[11];
    }
    /*Method 14*/
    public void MoveCenterUpToLeft()
    {
        char[] temporal = new char[16];
        temporal[0] = faces[2, 4];
        temporal[1] = faces[2, 5];
        temporal[2] = faces[2, 6];
        temporal[3] = faces[2, 7];

        temporal[4] = faces[5, 4];
        temporal[5] = faces[5, 5];
        temporal[6] = faces[5, 6];
        temporal[7] = faces[5, 7];

        temporal[8] = faces[3, 4];
        temporal[9] = faces[3, 5];
        temporal[10] = faces[3, 6];
        temporal[11] = faces[3, 7];

        temporal[12] = faces[4, 4];
        temporal[13] = faces[4, 5];
        temporal[14] = faces[4, 6];
        temporal[15] = faces[4, 7];

        faces[2, 4] = temporal[4];
        faces[2, 5] = temporal[5];
        faces[2, 6] = temporal[6];
        faces[2, 7] = temporal[7];

        faces[5, 4] = temporal[8];
        faces[5, 5] = temporal[9];
        faces[5, 6] = temporal[10];
        faces[5, 7] = temporal[11];

        faces[3, 4] = temporal[12];
        faces[3, 5] = temporal[13];
        faces[3, 6] = temporal[14];
        faces[3, 7] = temporal[15];

        faces[4, 4] = temporal[0];
        faces[4, 5] = temporal[1];
        faces[4, 6] = temporal[2];
        faces[4, 7] = temporal[3];
    }
    /*Method 15*/
    public void MoveCenterDownToLeft()
    {
        char[] temporal = new char[16];
        temporal[0] = faces[2, 8];
        temporal[1] = faces[2, 9];
        temporal[2] = faces[2, 10];
        temporal[3] = faces[2, 11];

        temporal[4] = faces[5, 8];
        temporal[5] = faces[5, 9];
        temporal[6] = faces[5, 10];
        temporal[7] = faces[5, 11];

        temporal[8] = faces[3, 8];
        temporal[9] = faces[3, 9];
        temporal[10] = faces[3, 10];
        temporal[11] = faces[3, 11];

        temporal[12] = faces[4, 8];
        temporal[13] = faces[4, 9];
        temporal[14] = faces[4, 10];
        temporal[15] = faces[4, 11];

        faces[2, 8] = temporal[4];
        faces[2, 9] = temporal[5];
        faces[2, 10] = temporal[6];
        faces[2, 11] = temporal[7];

        faces[5, 8] = temporal[8];
        faces[5, 9] = temporal[9];
        faces[5, 10] = temporal[10];
        faces[5, 11] = temporal[11];

        faces[3, 8] = temporal[12];
        faces[3, 9] = temporal[13];
        faces[3, 10] = temporal[14];
        faces[3, 11] = temporal[15];

        faces[4, 8] = temporal[0];
        faces[4, 9] = temporal[1];
        faces[4, 10] = temporal[2];
        faces[4, 11] = temporal[3];
    }
    /*Method 16*/
    public void MoveCenterDownToRigth()
    {
        char[] temporal = new char[16];
        temporal[0] = faces[2, 8];
        temporal[1] = faces[2, 9];
        temporal[2] = faces[2, 10];
        temporal[3] = faces[2, 11];

        temporal[4] = faces[5, 8];
        temporal[5] = faces[5, 9];
        temporal[6] = faces[5, 10];
        temporal[7] = faces[5, 11];

        temporal[8] = faces[3, 8];
        temporal[9] = faces[3, 9];
        temporal[10] = faces[3, 10];
        temporal[11] = faces[3, 11];

        temporal[12] = faces[4, 8];
        temporal[13] = faces[4, 9];
        temporal[14] = faces[4, 10];
        temporal[15] = faces[4, 11];

        faces[2, 8] = temporal[12];
        faces[2, 9] = temporal[13];
        faces[2, 10] = temporal[14];
        faces[2, 11] = temporal[15];

        faces[5, 8] = temporal[0];
        faces[5, 9] = temporal[1];
        faces[5, 10] = temporal[2];
        faces[5, 11] = temporal[3];

        faces[3, 8] = temporal[4];
        faces[3, 9] = temporal[5];
        faces[3, 10] = temporal[6];
        faces[3, 11] = temporal[7];

        faces[4, 8] = temporal[8];
        faces[4, 9] = temporal[9];
        faces[4, 10] = temporal[10];
        faces[4, 11] = temporal[11];
    }
    /*Method 17*/
    public void MoveCenterLLeftToUp()
    {
        char[] temporal = new char[16];

        temporal[0] = faces[4,1];
        temporal[1] = faces[4,5];
        temporal[2] = faces[4,9];
        temporal[3] = faces[4,13];

        temporal[4] = faces[0,4];
        temporal[5] = faces[0,5];
        temporal[6] = faces[0,6];
        temporal[7] = faces[0,7];

        temporal[8] = faces[5,2];
        temporal[9] = faces[5,6];
        temporal[10] = faces[5,10];
        temporal[11] = faces[5,14];

        temporal[12] = faces[1,11];
        temporal[13] = faces[1,10];
        temporal[14] = faces[1,9];
        temporal[15] = faces[1,8];

        faces[0, 4] = temporal[3];
        faces[0, 5] = temporal[2];
        faces[0, 6] = temporal[1];
        faces[0, 7] = temporal[0];

        faces[5, 2] = temporal[4];
        faces[5, 6] = temporal[5];
        faces[5, 10] = temporal[6];
        faces[5, 14] = temporal[7];

        faces[1, 11] = temporal[8];
        faces[1, 10] = temporal[9];
        faces[1, 9] = temporal[10];
        faces[1, 8] = temporal[11];

        faces[4, 1] = temporal[15];
        faces[4, 5] = temporal[14];
        faces[4, 9] = temporal[13];
        faces[4, 13] = temporal[12];
    }
    /*Method 18*/
    public void MoveCenterLLeftToDown()
    {
        char[] temporal = new char[16];

        temporal[0] = faces[4,1];
        temporal[1] = faces[4,5];
        temporal[2] = faces[4,9];
        temporal[3] = faces[4,13];

        temporal[4] = faces[0,4];
        temporal[5] = faces[0,5];
        temporal[6] = faces[0,6];
        temporal[7] = faces[0,7];

        temporal[8] = faces[5,2];
        temporal[9] = faces[5,6];
        temporal[10] = faces[5,10];
        temporal[11] = faces[5,14];

        temporal[12] = faces[1,11];
        temporal[13] = faces[1,10];
        temporal[14] = faces[1,9];
        temporal[15] = faces[1,8];

        faces[0, 4] = temporal[8];
        faces[0, 5] = temporal[9];
        faces[0, 6] = temporal[10];
        faces[0, 7] = temporal[11];

        faces[5, 2] = temporal[12];
        faces[5, 6] = temporal[13];
        faces[5, 10] = temporal[14];
        faces[5, 14] = temporal[15];

        faces[1, 11] = temporal[3];
        faces[1, 10] = temporal[2];
        faces[1, 9] = temporal[1];
        faces[1, 8] = temporal[0];

        faces[4, 1] = temporal[7];
        faces[4, 5] = temporal[6];
        faces[4, 9] = temporal[5];
        faces[4, 13] = temporal[4];
    }
    public void MoveCenterRLeftToUp()
    {
        char[] temporal = new char[16];

        temporal[0] = faces[4, 2];
        temporal[1] = faces[4, 6];
        temporal[2] = faces[4, 10];
        temporal[3] = faces[4, 14];

        temporal[4] = faces[0, 8];
        temporal[5] = faces[0, 9];
        temporal[6] = faces[0, 10];
        temporal[7] = faces[0, 11];

        temporal[8] = faces[4, 2];
        temporal[9] = faces[4, 6];
        temporal[10] = faces[4, 10];
        temporal[11] = faces[4, 14];

        temporal[12] = faces[4, 2];
        temporal[13] = faces[4, 6];
        temporal[14] = faces[4, 10];
        temporal[15] = faces[4, 14];
    }
}
