



namespace RAZRprl03
{
    class Program
    {
        static int[,] labirynth1 = new int[,]
{
{1, 1, 1, 1, 1, 1, 1 },
{1, 0, 0, 0, 0, 0, 1 },
{1, 0, 1, 1, 1, 0, 1 },
{2, 0, 0, 0, 1, 0, 2 },
{1, 1, 0, 0, 1, 1, 1 },
{1, 1, 1, 0, 1, 1, 1 },
{1, 1, 1, 2, 1, 1, 1 }
};
        public static void Main()
        {
            int count = CountNumberExit(labirynth1);
            Console.WriteLine(count);
            Labyrynt(3,1, count);
        }
        static int CountNumberExit(int[,] scheme)
        {
            int count = 0;
            for (int i = 0; i < scheme.GetLength(0); i++)
            {
                for (int j = 0; j < scheme.GetLength(1); j++)
                {
                    if (scheme[i, j] == 2) count++;
                }
            }
            return count;
        }
        static void Labyrynt(int x, int y, int count)
        {
            Console.ReadLine();
            PrintLabyrynt(x, y);

            if (labirynth1[x + 1, y] == 2) { labirynth1[x + 1, y] = -1; count--; }
            if (labirynth1[x, y + 1] == 2) { labirynth1[x, y + 1] = -1; count--; }
            if (labirynth1[x - 1, y] == 2) { labirynth1[x - 1, y] = -1; count--; }
            if (labirynth1[x, y - 1] == 2) { labirynth1[x, y - 1] = -1; count--; }

            if (count > 0)
            {
                if (labirynth1[x, y + 1] == 0) { labirynth1[x, y + 1] = -1; Labyrynt(x, y + 1, count); }
                if (labirynth1[x + 1, y] == 0) { labirynth1[x + 1, y] = -1; Labyrynt(x + 1, y, count); }
                if (labirynth1[x, y - 1] == 0) { labirynth1[x, y - 1] = -1; Labyrynt(x, y - 1, count); }
                if (labirynth1[x - 1, y] == 0) { labirynth1[x - 1, y] = -1; Labyrynt(x - 1, y, count); }
            }
            else
            {
                Console.WriteLine("All EXIT search. ");
            }
            
        }
        static void PrintLabyrynt(int x, int y)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < labirynth1.GetLength(0); i++)
            {
                Console.Write($"\t\t\t\t\t");
                for (int j = 0; j < labirynth1.GetLength(1); j++)
                {
                    if (i == x && j == y) { Console.Write("M" + "  "); }
                    else if (labirynth1[i, j] == 0) { Console.Write(" " + "  "); }
                    else if (labirynth1[i, j] == -1) { Console.Write("." + "  "); }
                    else if (labirynth1[i, j] == 2) { Console.Write("E" + "  "); }
                    else Console.Write("=" + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}