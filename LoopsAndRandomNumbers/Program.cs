using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutjalt sisestada PIN koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN on 1234, siis konsool kuvab "Tere tuelmast!"
            //kui sisestatud PIN on midagi muud, siis konsool kuvab "Vale PIN, proovi uuesti."
            //kasutajal on 3 katset. i < 3

            int i = 0;

            while (i < 3)
            {

                Console.WriteLine("Sisesta PIN");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemas!");
                    break;
                }
                else
                {
                    //i = i ++ 1;
                    i++;
                    Console.WriteLine($"Vale PIN. {3-i} katset on jäänud.");
                }

               
            }
            Console.WriteLine("Kena päeva!");


        }
    }
}
