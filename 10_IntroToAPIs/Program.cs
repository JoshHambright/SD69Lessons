using _10_IntroToAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs
{
    class Program
    {
        static void Main(string[] args)
        {
            //SwapiService swapiService = new SwapiService();
            //Person luke = swapiService.GetPersonAsynch(1).Result;

            //Console.WriteLine(luke.Name);
            //Console.WriteLine(luke.Hair_Color);

            //DadJokeService dadJokeService = new DadJokeService();
            //DadJoke joke = dadJokeService.GetDadJoke().Result;
            //Console.WriteLine(joke.Joke);

            TacoService tacoService = new TacoService();
            TacoRecipe taco = tacoService.GetTacoRecipeAsync().Result;
            bool keeprunning = true;
            while (keeprunning)
            {

                Console.Clear();
                Console.WriteLine(@"
████████  █████   ██████  ██████  ███████ 
   ██    ██   ██ ██      ██    ██ ██      
   ██    ███████ ██      ██    ██ ███████ 
   ██    ██   ██ ██      ██    ██      ██ 
   ██    ██   ██  ██████  ██████  ███████ 
");
                Console.WriteLine(taco.Seasoning.Name);
                Console.WriteLine(taco.Base_Layer.Name);
                Console.WriteLine(taco.Condiment.Name);
                Console.WriteLine(taco.Mixin.Name);
                Console.WriteLine(taco.Shell.Name);
                Console.WriteLine();
                Console.WriteLine("1>Show Seasoning");
                Console.WriteLine("2>Show Base Layer");
                Console.WriteLine("3>Show Condiment");
                Console.WriteLine("4>Show Mixin");
                Console.WriteLine("5>Show Shell");
                Console.WriteLine("6>Exit");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(taco.Seasoning.Recipe);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(taco.Base_Layer.Recipe);
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(taco.Condiment.Recipe);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();

                        Console.WriteLine(taco.Mixin.Recipe);
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine(taco.Shell.Recipe);
                        Console.ReadKey();
                        break;
                    
                    case "6":
                        keeprunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
