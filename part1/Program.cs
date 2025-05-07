using System.Numerics;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to BR's Carpet Cleaning Service " +
                "\nCharges:\n$25 per small \n$35 per large \nSales tax rate is 6%" +
                "\nEstimates are valid for 30 days");   
            
            Console.Write("Enter the number of small carpets : ");
            int S = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of Large carpets : ");
            int L = Convert.ToInt32(Console.ReadLine());

            double Total = (L * 35 + S * 25);
            Total += (Total * 0.06);

            Console.WriteLine($"Total estimate:{Total}\r\nThis estimate is valid for 30 days");
        }
    }
}
