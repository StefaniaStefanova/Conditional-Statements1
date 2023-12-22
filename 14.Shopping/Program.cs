using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videokarta = int.Parse(Console.ReadLine());
            int procesor = int.Parse(Console.ReadLine());
            int rampamet = int.Parse(Console.ReadLine());

            double sumvideokarti = videokarta * 250;
            double priceprocesor = 0.35 * sumvideokarti;
            double procesorsum = procesor * priceprocesor;
            double rampametprice = 0.1 * sumvideokarti;
            double rampametsum = rampamet * rampametprice;

            double total = sumvideokarti + procesorsum + rampametsum;

            if (videokarta > procesor)
            {
                double discount = 0.15 * total;
                total -= discount;
            }

            if (total <= budget)
            {
                double remainingBudget = budget - total;
                Console.WriteLine($"You have {remainingBudget:F2} leva left!");
            }
            else
            {
                double neededAmount = total - budget;
                Console.WriteLine($"Not enough money! You need {neededAmount:F2} leva more!");
            }
        }
    }
}
