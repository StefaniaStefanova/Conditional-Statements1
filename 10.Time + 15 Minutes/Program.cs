namespace _10.Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            var sum = ((hour * 60) + minute + 15);
            var resulthour = sum / 60;
            if (resulthour >= 24)
            {
                resulthour -= 24;
            }
            var resultmin = sum % 60;

            Console.WriteLine("{0}:{1:00}", resulthour, resultmin);
        }

    }
}
