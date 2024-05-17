namespace PB201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10; 
            PrintSumOfEvenNumbers(number);
        }
        static void PrintSumOfEvenNumbers(int n) 

        { int sum = 0;
            for (int i = 1; i <= n; i++) 
            { 
                if (i % 2 == 0) 
                { 
                    sum += i; }
            } 
            Console.WriteLine("sum number: " + sum); }
    }
}    
    
