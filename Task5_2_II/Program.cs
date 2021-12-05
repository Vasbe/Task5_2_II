using System;

namespace Task_5_2_II
{
    class Program
    {
        static int Divider(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int countDivN = 2;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    countDivN++;
                }
            }
            return countDivN;
        }
        static void TaskA()
        {
            Console.WriteLine("Введите a:");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);

            Console.WriteLine("Введите b:");
            string S2 = Console.ReadLine();
            int b = int.Parse(S2);
            if (a > b)
            {
                Console.WriteLine("Введите а меньше чем b");
                return;
            }
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine("{0}: {1}", i, Divider(i));


            }
        }
        static void TaskB()
        {
            Console.WriteLine("Введите a:");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);

            Console.WriteLine("Введите b:");
            string S2 = Console.ReadLine();
            int b = int.Parse(S2);

            Console.WriteLine("Введите x:");
            string S3 = Console.ReadLine();
            int x = int.Parse(S3);

            if (a > b)
            {
                Console.WriteLine("Введите а меньше чем b");
                return;
            }

            for (int i = a; i <= b; i++)
            {
                if (Divider(i) == x)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void TaskC()
        {
            Console.WriteLine("Введите a:");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);

            Console.WriteLine("Введите b:");
            string S2 = Console.ReadLine();
            int b = int.Parse(S2);

            if (a > b)
            {
                Console.WriteLine("Введите а меньше чем b");
                return;
            }

            int maxDividerCount = 0;

            for (int i = a; i <= b; i++)
            {
                int dividerCount = Divider(i);
                if (dividerCount > maxDividerCount)
                {
                    maxDividerCount = dividerCount;
                }

            }
            for (int i = a; i <= b; i++)
            {
                if (Divider(i) == maxDividerCount)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void TaskD()
        {
            Console.WriteLine("Введите a:");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);

            int dividerCount = Divider(a);

            int i = a + 1;
            while (true)
            {
                if (Divider(i) == dividerCount)
                {
                    Console.WriteLine(i);
                    return;
                }
                i++;
            }
        }
        static void Main(string[] args)
        {
            TaskA();
            TaskB();
            TaskC();
            TaskD();
;
        }
    }
}
