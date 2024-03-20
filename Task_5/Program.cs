namespace Task_5
{
    internal class Program
    {
        public delegate double Anonymous(int a, int b, int c);

        static void Main(string[] args)
        {
            int x = 10; 
            int y = 20; 
            int z = 30;

            Anonymous averageOfThree = (int a, int b, int c) => (double)((a + b + c) / 3);

            Console.WriteLine($"Result: {averageOfThree(x, y, z):N}");

            Console.ReadKey();  
        }
    }
}