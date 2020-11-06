using _10_IntroToAPIs.Models;
using _10_IntroToAPIs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_IntroToAPIs
{
    class Program
    {
        static void Main(string[] args)
        {
            MySwapiService mySwapiService = new MySwapiService();
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a gender");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter a homeworld ID");
            int homeworld = Convert.ToInt32(Console.ReadLine());

            Character newCharacter = new Character()
            {
                Name = name,
                Gender = gender,
                Homeworld = homeworld
            };
            Console.Clear();
            Console.WriteLine("Saving new character...");
            int statusCode = (int) mySwapiService.PostCharacterAsync(newCharacter).Result;

            //mySwapiService.PostCharacterAsync(newCharacter).Wait();

            Console.Clear();
            if(statusCode == 200)
            {
            Console.WriteLine("\n\nNew Character Created!");

            }
            else
            {
                Console.WriteLine("\n\nError saving character." + statusCode);
            }

            Console.ReadKey();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter Character ID:");
                int id = Int32.Parse(Console.ReadLine());
                if (id == 0)
                {
                    break;
                }

                Console.WriteLine("\n\nLoading...");
                CharacterWithHomeworld character = mySwapiService.GetCharacterWithHomeworldAsync(id).Result;
                //Planet planet = mySwapiService.GetPlanetAsync(luke.Homeworld).Result;
                Console.WriteLine("\n\n");
                Console.WriteLine(character.Name);
                Console.WriteLine("\n\n");
                Console.WriteLine(character.Homeworld.Name);
                Console.ReadKey();
            }
            //SwapiService swapiService = new SwapiService();
            //Person luke = swapiService.GetPersonAsynch(1).Result;

            //Console.WriteLine(luke.Name);
            //Console.WriteLine(luke.Hair_Color);

            //DadJokeService dadJokeService = new DadJokeService();
            //DadJoke joke = dadJokeService.GetDadJoke().Result;
            //Console.WriteLine(joke.Joke);

            //            TacoService tacoService = new TacoService();
            //            TacoRecipe taco = tacoService.GetTacoRecipeAsync().Result;
            //            bool keeprunning = true;
            //            while (keeprunning)
            //            {

            //                Console.Clear();
            //                Console.WriteLine(@"
            //████████  █████   ██████  ██████  ███████ 
            //   ██    ██   ██ ██      ██    ██ ██      
            //   ██    ███████ ██      ██    ██ ███████ 
            //   ██    ██   ██ ██      ██    ██      ██ 
            //   ██    ██   ██  ██████  ██████  ███████ 
            //");
            //                Console.WriteLine(taco.Seasoning.Name);
            //                Console.WriteLine(taco.Base_Layer.Name);
            //                Console.WriteLine(taco.Condiment.Name);
            //                Console.WriteLine(taco.Mixin.Name);
            //                Console.WriteLine(taco.Shell.Name);
            //                Console.WriteLine();
            //                Console.WriteLine("1>Show Seasoning");
            //                Console.WriteLine("2>Show Base Layer");
            //                Console.WriteLine("3>Show Condiment");
            //                Console.WriteLine("4>Show Mixin");
            //                Console.WriteLine("5>Show Shell");
            //                Console.WriteLine("6>Exit");
            //                string menu = Console.ReadLine();
            //                switch (menu)
            //                {
            //                    case "1":
            //                        Console.Clear();
            //                        Console.WriteLine(taco.Seasoning.Recipe);
            //                        Console.ReadKey();
            //                        break;
            //                    case "2":
            //                        Console.Clear();
            //                        Console.WriteLine(taco.Base_Layer.Recipe);
            //                        Console.ReadKey();
            //                        break;
            //                    case "3":
            //                        Console.Clear();
            //                        Console.WriteLine(taco.Condiment.Recipe);
            //                        Console.ReadKey();
            //                        break;
            //                    case "4":
            //                        Console.Clear();

            //                        Console.WriteLine(taco.Mixin.Recipe);
            //                        Console.ReadKey();
            //                        break;
            //                    case "5":
            //                        Console.Clear();
            //                        Console.WriteLine(taco.Shell.Recipe);
            //                        Console.ReadKey();
            //                        break;

            //                    case "6":
            //                        keeprunning = false;
            //                        break;
            //                    default:
            //                        break;
            //                }
            //            }
        }
    }
}
