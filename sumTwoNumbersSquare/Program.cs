namespace sumTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sum = SumSquare();

            if (sum == 0)
                Console.WriteLine("Wrong value");
            else
                Console.WriteLine($"The sum is: " + sum);
        }

        static private double SumSquare()
        {
            int a, b;

            while (true)
            {
                Console.Write("Enter a first number: ");
                string _a = Console.ReadLine();
                if (int.TryParse(_a, out a))
                    break;
                else
                    Console.WriteLine("Invalid value. Please Enter a number.");
            }

            while (true)
            {
                Console.Write("Enter a second number: ");
                string _b = Console.ReadLine();
                if (int.TryParse(_b, out b))
                    break;
                else
                    Console.WriteLine("Invalid value. Please Enter a number.");

            }
            //return a*a + b*b;
            return Math.Pow(a,2) + Math.Pow(b,2);

        }
    }
}
