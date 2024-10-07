namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void checkPrime(int n)
            {
                if (n < 2) 
                {
                    Console.WriteLine($"{n} is not a Prime number");
                    return;
                }
                for (int i = 2; i <= n / 2; i++)
                {
                    if(n%i == 0)
                    {
                        Console.WriteLine($"{n} is not a Prime number");
                        return;
                    }
                }
                Console.WriteLine($"{n} is a Prime number");
            }
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32( Console.ReadLine() );
            checkPrime(num);
        }
    }
}
