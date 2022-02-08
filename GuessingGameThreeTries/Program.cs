using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis on ta mängu võitnud
            //kasutajal on 3 katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti
            //*programm genereerib juhuslikku numbrit ühte korda
            Console.WriteLine("Arvuti genereeris numbri 1-10. Kui ära arvad vähemalt kolme korraga siis oled võitja, teisel juhul võidab arvuti");
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 11);

           
            int i = 0; //i - iteration

            while (i < 3) //while-loop

            {
                
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == myRandomNumber)
                {
                    Console.WriteLine("Arvasite õigesti ära, võitsite mängu!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale arvamus. {3- i} arvamust on veel jäänud");                   
                }
            } if (i == 3)
            {
                Console.WriteLine("Mäng on läbi ja võitis Arvuti.");
            }
            

        }
    }
}
