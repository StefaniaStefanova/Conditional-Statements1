namespace _08.Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firsttime = int.Parse(Console.ReadLine());
            int secondtime = int.Parse(Console.ReadLine());
            int thirdtime = int.Parse(Console.ReadLine());
            int total = firsttime + secondtime + thirdtime;
            int minutes = total / 60;
            int seconds = total % 60;
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }






        }
    }
}