namespace Task_Day_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of small carpets:");
            int small = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of small carpets:");
            int large = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small room: $25\r\nPrice per large room: $35");
            double Cost = (small * 25) + (large * 35);
            Console.WriteLine($"Cost : {Cost}$");
            double Tax = Cost * 0.06;
            Console.WriteLine($"Tax : {Tax}$");
            double Total = Cost + Tax;
            Console.WriteLine($"Total estimate:{Total}$");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
