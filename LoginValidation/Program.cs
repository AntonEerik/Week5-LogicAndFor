using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti!";
            //kasutajal on 3 katset;
            
            
            int i = 3;
            while (i != 0)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();
                if (userName != "admin" || userPassword != "admin1234")
                {
                    i--;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovi uuesti! Sul on jäänud {i} katset.");
                }
                else
                {
                    Console.WriteLine("Tere Tulemast");
                    break;
                }
            }
        }
    }
}