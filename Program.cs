namespace Matrici6
{
    internal class Program
    {
        static int[,] stampa(int[,] matrice)
        {
            int a = 100, b = 10;

            for ( int i = 0; i < matrice.GetLength(0); i++)
            {
                for(int j = 0;  j < matrice.GetLength(1); j++)
                {
                    matrice[i, j] = a;
                    a = b - i;
                    Console.Write(matrice[i, j] + "\t");
                }
                Console.WriteLine();
                b = 10;
                a = a - b;
            }
            return matrice;
        }
        static void Main(string[] args)
        {
            int[,] M = new int[10, 10];

            stampa(M);
        }
    }
}
