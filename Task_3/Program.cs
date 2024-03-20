namespace Task_3
{
    internal class Program
    {

        delegate int RandomDelegate();
        delegate double MainDelegate(RandomDelegate[] delegates);

        static void Main(string[] args)
        {
            int arrayLength = 3;
            RandomDelegate[] array = new RandomDelegate[arrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new Random().Next(0, 10);   
            }
            
            Console.WriteLine("Random numbers: ");
            MainDelegate average = (RandomDelegate[] delegates) =>
            {
                int sum = 0;
                for (int i = 0; i < delegates.Length; i++)
                {
                    int value = delegates[i].Invoke();
                    sum += value;
                    Console.Write(value + "; ");
                }

                return (double) sum / delegates.Length;
            };

            Console.WriteLine($"\nAverage is: {average(array):N}");

            Console.ReadKey();
        }

    }
}