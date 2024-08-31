namespace CalculateAge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // first solution
            //Console.WriteLine("Please enter a date: ");
            //DateTime birtthDate =  Convert.ToDateTime(Console.ReadLine());
            //TimeSpan age = DateTime.Now - birtthDate;
            //int result = age.Days / 365;
            //Console.WriteLine(result);

            //second solution

            //Console.WriteLine("Please, enter a birth date: ");

            //DateTime birthDate = DateTime.Parse(Console.ReadLine());
            //DateTime today = DateTime.Now;

            //int age = today.Year- birthDate.Year;
            //Console.WriteLine(age);
            //if (birthDate > today.AddYears(-age))
            //    --age;

            //Console.WriteLine(age);
            //Console.WriteLine(today.AddYears(-age));

            // third solution

            Console.WriteLine("Please enter a birth date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            int day = (DateTime.Now - birthDate).Days;
            int age = (DateTime.Now - birthDate).Days/365;

            int howDays = day % 365;
            Console.WriteLine(age);
            Console.WriteLine(365 + (age * 1/4) - howDays);

        }
    }
}
