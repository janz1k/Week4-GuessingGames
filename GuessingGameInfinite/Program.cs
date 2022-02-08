using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis on ta mängu võitnud
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühte korda

            Console.WriteLine("Arvuti genereeris numbri vahemikus 1-10, kui ära arvad oled võitja.");
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 0; //i - iteration

            while (loopActive) //while-loop

            {                             
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == myRandomNumber)
                {
                    Console.WriteLine("Arvasite õigesti ära, võitsite mängu!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Arvasid valesti, proovi uuesti.");
                }
            }

            

            

        }
    }
}
