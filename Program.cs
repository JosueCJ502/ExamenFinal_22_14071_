using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 2];

        //INTENTEMOS ASIGNAR VALORES A LOS ELEMENTOS DE LA MATRIZ

        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;
        matriz[2, 0] = 5;
        matriz[2, 1] = 6;

        //INTENTEMOS IMPRIMIR LOS VALORES DE LA MATRIZ

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Elemento de la posicion [{0},{1}] = {2}", i, j, matriz[i, j]); // aqui le cambie el , por el =, es igual como se inicio la matriz

            }
            Console.WriteLine(); // desde mi punto de Vista creo que el codigo nesecitaba un salto entre las matrices
        }
        Console.ReadLine();
    }
}