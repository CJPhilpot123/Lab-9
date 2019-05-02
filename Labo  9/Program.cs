using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo__9
{
    class Program
    {
        static void Main(string[] args)
        {
            int wave = 0;
            wave++;
            while (wave == 1)
            {


                List<string> ninja = new List<string> { "Naruto", "Sasuke", "Gaara", "Darui", "Killer Bee", "Sakura", "Tamari" };

                List<string> homes = new List<string> { "Hidden Leaf Village", "Uchiha Clan", "Hidden Sand Village", "Hidden Stone Village", "Hidden Stone Village", "Hidden Leaf Village", "Hidden Sand Village" };

                List<string> FavJutsu = new List<string> { "Rasengan", "Chidori", "Sand Tomb", "Black Lightning", "Rhyme", "Brute Stregth", "Wind Style: Cutting Wind" };

                Console.WriteLine("Welcome to the NinjaDex! Which Ninja would you like to know more about? (0-6)");

                try
                {
                    int first = int.Parse(Console.ReadLine());
                    Error.Catcher(first);
                    Console.WriteLine($"You choose: {ninja[first]} \nEnter (1) for their favorite jutsu \nOR \nEnter (2) for their home village");
                    int SecAns = int.Parse(Console.ReadLine());
                    if (SecAns == 1)
                    {
                        Console.WriteLine(FavJutsu[first]);
                        wave--;
                    }
                    if (SecAns == 2)
                    {
                        Console.WriteLine(homes[first]);
                        wave--;
                    }
                    

                }
                catch
                {
                    Console.WriteLine("Please answer correctly on the next prompt");
                    wave = 1;
                    break;

                }

               

            }
            Console.WriteLine("Would you like to search again? \n(Yes/No)");
            string repeat = Console.ReadLine();
            if (repeat == "Yes")
            {
                wave++;
            }
            if (repeat == "No")
            {
                Console.WriteLine("Hope You Have A Good Day!");
                wave = 0;
            }




        }


    }
}
