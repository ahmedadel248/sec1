namespace part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("welcome");
           Console.Write("what is your name :");
           string name = Console.ReadLine();
           Console.Write("what is your age :");
           int age = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine($"your name is {name}, you {age} years old");
        }
    }
}
