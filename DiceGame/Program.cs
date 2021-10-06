using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb 2 mängijat - arvuti ja kasutaja;
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem on võitja;
            //*täringuid vistakse 3 korda
            //programm kuulutab võitjat

            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 7);
            int userRandom = rnd.Next(1, 7);
            int cpuScore = 0;
            int userScore = 0;
            for (int i = 0; i < 3; i++)
            {
                cpuRandom = rnd.Next(1, 7);
                userRandom = rnd.Next(1, 7);
                
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");
                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud!");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }

            if (userScore>cpuScore)
            {
                Console.WriteLine("Kogu mängu võitis Kasutaja!");
            }
            else
            {
                Console.WriteLine("Kogu mängu võitis Arvuti!");
            }
        }
    }
}