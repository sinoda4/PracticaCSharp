namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String firstName = String.Empty;
            String lastName = String.Empty;
            int age = 0;
            decimal salary = 0;
            char gender = char.MinValue;
            bool working = false;

            Console.Write("Please enter your name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your gender: ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working? (true or false) ");
            working = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("Hello {0} {1} you're {2} years old", firstName, lastName, age);
            Console.WriteLine("You earn {0}, you're {1} and you working status is {2}", salary, gender, working);
        }
    }
}
