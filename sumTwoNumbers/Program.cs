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
            Console.WriteLine("The sum is: " + sum);
        }

        static private int Sum  ()
        {
            Console.Write("Enter a first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a second number: ");
            int b = int.Parse(Console.ReadLine());
            return a + b;
        }
    }
}
