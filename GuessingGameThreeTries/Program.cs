using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mäng võitnud;
            //kasutajal on 3 katset, kui kasutaja ei ole suutnud 3 katsega numbrit ära arvata
            //siis mängu võidab arvuti;
            //programm genereerib juhusliku numbri ühe korra;

            int i = 0;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (i < 3)
            {
                Console.WriteLine("Sisesta number.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Sisestasite õige numbri, olete võitnud!");
                    break;

                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number. Olete {i}/3 korda proovinud.");
                }

            }






        }
    }
}
