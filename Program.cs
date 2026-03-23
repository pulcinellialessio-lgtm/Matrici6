namespace Matrici6
{
    internal class Program
    {
        static int[,] riempimento(int[,] matrice)
        {
            int a = 100, b = 10, c = 0;

            for ( int i = 0; i < matrice.GetLength(0); i++)
            {
                for(int j = 0;  j < matrice.GetLength(1); j++)
                {
                    matrice[i, j] = a;
                    a = a - b;
                }
                c = c + 10;
                b--;
                a = 100 - c;
            }
            return matrice;
        }
        static void stampa(int[,] matrice)
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for(int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write("[" + matrice[i, j] + "]" + "\t");
                }
                Console.WriteLine();
            }
        }
        static int es2(int[,] matrice, int x, int y)
        {
            Random random = new Random();
            int a = 0;

            for(int i = 0; i < matrice.GetLength(0); i++)
            {
                for(int j = 0; j < matrice.GetLength(1); j++)
                {
                    int num = random.Next(0, 51);
                    matrice[i, j] = num;

                    if (matrice[i,j] > x || matrice[i,j] < y)
                    {
                        a++;
                    }
                }
            }

            return a;
        }
        static void Main(string[] args)
        {
            int[,] M = new int[10, 10];
            riempimento(M);
            stampa(M);

            Console.WriteLine("Dimmi un numero");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi un numero");
            int y = Convert.ToInt32(Console.ReadLine());

            int[,] M2 = new int[5, 5];
            Console.WriteLine("Ci sono " + es2(M2, x, y) + " numeri della matrice tra l'intervallo di x e y");
        }
    }
}
