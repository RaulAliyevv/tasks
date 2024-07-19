using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                if (i < 65)
                {
                    Console.WriteLine($"{i}: Kəsildin");
                }
                else if (i >= 65 && i < 85)
                {
                    Console.WriteLine($"{i}: Adi Diplom");
                }
                else if (i >= 85 && i < 95)
                {
                    Console.WriteLine($"{i}: Şərəf Diplomu");
                }
                else
                {
                    Console.WriteLine($"{i}: Yüksək Şərəf");
                }
            }
        }
    }
}
