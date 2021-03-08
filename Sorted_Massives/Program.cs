using System;

namespace FirstTask
{
    class Program
    {
        #region Methods
        public static void Print(string text)
        {
            Console.Write(text);
        }

        public static void Forcycle(int[] massive, char MassiveName)
        {
            Print($"\nMassives '{MassiveName}': \n");

            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void SortedMassives(int[] Zmassive)
        {
            int tempA;

            for (int i = 0; i < Zmassive.Length - 1; i++)
            {
                for (int j = i + 1; j < Zmassive.Length; j++)
                {
                    if (Zmassive[i] > Zmassive[j])
                    {
                        tempA = Zmassive[i];
                        Zmassive[i] = Zmassive[j];
                        Zmassive[j] = tempA;
                    }
                }
            }

            Print("\nSorted Massives: ");
            for (int i = 0; i < Zmassive.Length; i++)
            {
                Print($"{Zmassive[i]} ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void Start()
        {
            Print("How many numbers do you want to enter for A[a]? : ");
            int firstMassiveCount = int.Parse(Console.ReadLine());
            int[] a = new int[firstMassiveCount];
            Forcycle(a, 'A');

            Print("How many numbers do you want to enter for B[b]? : ");
            int SecondMassiveCount = int.Parse(Console.ReadLine());
            int[] b = new int[SecondMassiveCount];
            Forcycle(b, 'B');

            var z = new int[a.Length + b.Length];
            a.CopyTo(z, 0);
            b.CopyTo(z, a.Length);

            SortedMassives(z);
        }
        #endregion
        static void Main(string[] args)
        {
            Start();
        }
    }
}
