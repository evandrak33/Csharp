using System.Text;

namespace CurrencyConverter
{
    //reads the input of the user
    //the user gives amount in euros
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal RATE = 1.07m;

            Console.WriteLine("Παρακαλώ εισάγετε το ποσό σε Ευρώ");

            if (!decimal.TryParse(Console.ReadLine(), out decimal inputEuros))
            {
                Console.WriteLine("Error in input");
                return;
            }

            // eu to dollar conversion happens here
            
            decimal converted = inputEuros * RATE;

            //rounding off the cents, to avoid errors
            
            int totalCents = (int)Math.Round(converted * 100, MidpointRounding.AwayFromZero); // Default MidpointRounding.ToEven

            int dollars = totalCents / 100;
            int cents = totalCents % 100;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"\u20AC {inputEuros:F2} αντιστοιχούν σε \u0024 {dollars} και {cents} cents");
        }
    }
}
