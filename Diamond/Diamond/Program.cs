namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of Diamond :");
            int n =int.Parse(Console.ReadLine());
            string str = "";
            for (int i = 1; i < n * 2; i++)
            {
                if (i < n)
                {
                    str += new string(' ', n - i);
                    str += new string('*', i * 2 - 1) + "\n";
                }
                else 
                {
                    str += new string(' ', i-n);
                    str += new string('*', n*4-i*2-1) + "\n";
                }
            }
            Console.WriteLine(str);
        }
    }
}
