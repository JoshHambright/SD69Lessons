using _06_StreamingContent_Repository;
using _06_StreamingContent_Repository.Content;
using _09_StreamingContent_UIRefactor.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor
{
    public class ProgramUI
    {
        private StreamingContent_Repo _repo = new StreamingContent_Repo();
        private IConsole _console;
        // Dependency Injection - an I_console object must be passed in when this is created
        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        // Everything this class does (or atleast some of what it does) DEPENDS on an I_console object
        public void SayHello()
        {
            _console.WriteLine("What is your name?");
            string name = _console.ReadLine();
            _console.WriteLine($"Hey, {name}, how are you doing?");
            string reply = _console.ReadLine();
            _console.WriteLine(reply);
            _console.ReadKey();
        }



        public void Run()
        {
            SeedContent();
            Menu();
        }

        private void SeedContent()
        {
            Movie futureWar = new Movie(
                "Future War",
                "a war in the future",
                10.0,
                Genre.SciFi,
                MaturityRating.PG_13,
                90.0
                );

            Movie theRoom = new Movie(
                "The Room",
                "Everyone betrays Johnny and he's fed up with this world",
                10.0,
                Genre.Documentary,
                MaturityRating.R,
                99.0
                );
            Show redDwarf = new Show();
            redDwarf.Title = "Red Dwarf";
            redDwarf.MaturityRating = MaturityRating.PG;
            redDwarf.Description = "A human, a robot, a hologram and a cat try to survive 3 million years into deep space.";
            redDwarf.Genre = Genre.SciFi;
            List<Episode> episodes = new List<Episode>();
            episodes.Add(new Episode("The End", 45, 1));
            episodes.Add(new Episode("Psirens", 45, 6));
            Episode episode = new Episode();
            episode.Title = "Tikka to Ride";
            episodes.Add(episode);
            redDwarf.Episodes = episodes;

            Episode pilot = new Episode();
            
            Episode ep2 = new Episode();
            Show theOffice = new Show();
            theOffice.Title = "The Office";

            theOffice.Episodes.Add(ep2);
            theOffice.Episodes.Add(pilot);
            _repo.AddContentToDirectory(futureWar);
            _repo.AddContentToDirectory(theRoom);
            _repo.AddContentToDirectory(theOffice);
            _repo.AddContentToDirectory(redDwarf);


        }

        private void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                _console.WriteLine("----------------------------------------------------");
                _console.WriteLine("Enter the number of the option you'd like to select:");
                _console.WriteLine("1. Show all streaming content");
                _console.WriteLine("2. Find streaming content by title");
                _console.WriteLine("3. Add new streaming content");
                _console.WriteLine("4. Update existing streaming content");
                _console.WriteLine("5. Remove streaming content");
                _console.WriteLine("6. Exit");
                _console.WriteLine("----------------------------------------------------");

                string input = _console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Show all content
                        ShowAllContent();
                        break;
                    case "2":
                        //get content by title
                        //ShowContentByTitle();
                        break;
                    case "3":
                        //Create new streaming content
                        //CreateNewContent();
                        break;
                    case "4":
                        // Update existing content
                        //UpdateContent();
                        break;
                    case "5":
                        //Remove streaming content
                        //DeleteContent();
                        break;
                    case "6":
                        //Exit app
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please choose a valid option. (Hint its a number)");
                        _console.ReadKey();
                        break;
                }

            }
        }

        public void ShowAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _repo.GetContents();

            foreach (StreamingContent content in listOfContent)
            {
                /*Console.WriteLine($"Title: { content.Title}");
                Console.WriteLine($"Description: {content.Description}");
                Console.WriteLine($"Star Rating: {content.StarRating}");
                Console.WriteLine($"Genre: {content.Genre}");
                Console.WriteLine($"Maturity Rating: {content.MaturityRating}");
                Console.WriteLine($"Family Friendly: {content.IsFamilyFriendly}");
                */
                DisplayContent(content);


            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        private void DisplayContent(StreamingContent content)
        {
            if (content.GetType().Name == "Movie")
            {
                _console.WriteLine("==========Movie:===========");
                Movie movie = (Movie)content;
                _console.WriteLine($"Run Time: {movie.RunTime}");
            }
            if (content.GetType().Name == "Show")
            {
                _console.WriteLine("==========Show:===========");
                Show show = (Show)content;
                _console.WriteLine($"Episodes: {show.EpisodeCount}");
            }
            _console.WriteLine($"Title { content.Title}");
            _console.WriteLine($"Description: {content.Description}");
            _console.WriteLine($"Star Rating: {content.StarRating}");
            _console.WriteLine($"Genre: {content.Genre}");
            _console.WriteLine($"Maturity Rating: {content.MaturityRating}");
            _console.WriteLine($"Family Friendly: {content.IsFamilyFriendly}");
        }
    }
}
