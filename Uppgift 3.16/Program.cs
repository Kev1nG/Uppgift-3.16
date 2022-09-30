using System;
namespace Uppgift_3._16
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur lång låt är den låten du vill spela? (min 2m 45sek och max 4m 20sek)");
            int längdm = int.Parse(Console.ReadLine());
            int sek = int.Parse(Console.ReadLine());
            int m = längdm * 60;
            int tot = m + sek;

            if (tot <= 165 || tot >= 265) 
            {
                Console.WriteLine("Denna låt får inte spelas på radiostaionen");
            }
            else
            {
                Console.WriteLine("Denna låt får du tyvärr inte spelas");
            }
        }
    }
}