namespace SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double sum = 0;
            string result = "";

            for (int i = 1; i <= 10; i++)
            {
                if (i < 10)
                {
                    sum += Math.Pow(i, 3);
                    result += $"{i}³ + "; 
                }
                else
                {
                    sum += Math.Pow(i, 3);
                    result += $"{i}³ = {sum} ";
                }
            }

            Console.WriteLine(result);
        }
    }
}
