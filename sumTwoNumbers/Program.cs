namespace sumTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // first solution
            //Console.Write("Enter a first number: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Enter a second number: ");
            //int b = int.Parse(Console.ReadLine());

            //int sum = a + b;
            int sum = Sum();

            if (sum == 0)
            {
                Console.WriteLine("Wrong value");
            }
            else
            {
                Console.WriteLine($"The sum is: " + sum);
            }


        }

        static private int Sum  ()
        {
            //try
            //{
            //    Console.Write("Enter a first number: ");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.Write("Enter a second number: ");
            //    int b = int.Parse(Console.ReadLine());
            //    return a + b;

            //}
            //catch {
            //    return 0;
            //}

            int a, b;

            while (true) {
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
                if(int.TryParse(_b, out b))
                    break;
                else
                    Console.WriteLine("Invalid value. Please Enter a number.");

            }
            return a + b;
            
        }
    }
}
