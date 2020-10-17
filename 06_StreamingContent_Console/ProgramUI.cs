using _06_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContent_Repo _repo = new StreamingContent_Repo();

        public void Run()
        {
            SeedContent();
            Menu();
        }

        private void SeedContent()
        {
            StreamingContent futureWar = new StreamingContent(
                "Future War",
                "a war in the future",
                10.0,
                Genre.SciFi,
                MaturityRating.PG_13
                );

            StreamingContent theRoom = new StreamingContent(
                "The Room",
                "Everyone betrays Johnny and he's fed up with this world",
                10.0,
                Genre.Documentary,
                MaturityRating.R
                );
            _repo.AddContentToDirectory(futureWar);
            _repo.AddContentToDirectory(theRoom);


        }

        private void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Enter the number of the option you'd like to select:");
                Console.WriteLine("1. Show all streaming content");
                Console.WriteLine("2. Find streaming content by title");
                Console.WriteLine("3. Add new streaming content");
                Console.WriteLine("4. Update existing streaming content");
                Console.WriteLine("5. Remove streaming content");
                Console.WriteLine("6. Exit");
                Console.WriteLine("----------------------------------------------------");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Show all content
                        ShowAllContent();
                        break;
                    case "2":
                        //get content by title
                        ShowContentByTitle();
                        break;
                    case "3":
                        //Create new streaming content
                        CreateNewContent();
                        break;
                    case "4":
                        // Update existing content
                        UpdateContent();
                        break;
                    case "5":
                        //Remove streaming content
                        DeleteContent();
                        break;
                    case "6":
                        //Exit app
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option. (Hint its a number)");
                        Console.ReadKey();
                        break;
                }

            }
        }

        private void ShowAllContent()
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
                Console.WriteLine();

            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }

        private void CreateNewContent()
        {
            Console.Clear();

            StreamingContent newContent = new StreamingContent();
            Console.WriteLine("--Creating new Streaming Content Entry--");

            Console.WriteLine("Enter Title:");
            newContent.Title = Console.ReadLine();

            Console.WriteLine("Enter Description:");
            newContent.Description = Console.ReadLine();

            Console.WriteLine("Enter Star Rating(1.0-10.0):");
            newContent.StarRating = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number for Genre:");
            Console.WriteLine("1. Horror");
            Console.WriteLine("2. RomCom");
            Console.WriteLine("3. Sci-Fi");
            Console.WriteLine("4. Action");
            Console.WriteLine("5. Documentary");
            Console.WriteLine("6. Musical");
            Console.WriteLine("7. Drama");
            Console.WriteLine("8. Mystery");
            /*string genreInput = Console.ReadLine();
            int genreAsInt = int.Parse(genreInput);
            newContent.Genre = (Genre)genreAsInt; */
            newContent.Genre = (Genre)int.Parse(Console.ReadLine());


            bool stopRunning = false;
            while (!stopRunning)
            {
                Console.WriteLine("Enter number for Content Rating:");
                Console.WriteLine("1. G");
                Console.WriteLine("2. PG");
                Console.WriteLine("3. PG-13");
                Console.WriteLine("4. R");
                Console.WriteLine("5. NC-17");
                //newContent.MaturityRating = (MaturityRating)int.Parse(Console.ReadLine());
                string maturityRating = Console.ReadLine();
                switch (maturityRating)
                {
                    case "1":
                        newContent.MaturityRating = MaturityRating.G;
                        stopRunning = true;
                        break;
                    case "2":
                        newContent.MaturityRating = MaturityRating.PG;
                        stopRunning = true;
                        break;
                    case "3":
                        newContent.MaturityRating = MaturityRating.PG_13;
                        stopRunning = true;
                        break;
                    case "4":
                        newContent.MaturityRating = MaturityRating.R;
                        stopRunning = true;
                        break;
                    case "5":
                        newContent.MaturityRating = MaturityRating.NC_17;
                        stopRunning = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input.");
                        break;


                }
            }
            bool wasAdded = _repo.AddContentToDirectory(newContent);
            if (wasAdded == true)
            {
                Console.WriteLine("Your Content was successfully added.");
                Console.WriteLine("Press any key to return to menu.");

            }
            else
            {
                Console.WriteLine("Opps. Something went wrong. Your Content was not added. Please try again");
                Console.WriteLine("Press any key to return to menu.");

            }
            Console.ReadKey();

        }


        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.WriteLine("Enter the title of the content you'd like to see.");
            string title = Console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            if (content != null)
            {
                DisplayContent(content);
                Console.WriteLine("Press any key to continue.");
            }
            else
            {
                Console.WriteLine("Title not found. Press and key to continue.");

            }
            Console.ReadKey();

        }

        private void UpdateContent()
        {
            Console.Clear();

            Console.WriteLine("------Updating Conent------");
            Console.WriteLine("Currently Available Titles:");
            //List<StreamingContent> listOfContent = _repo.GetContents(); //Display all titles in the repo
            //foreach (StreamingContent content in listOfContent)
            //{
            //    Console.WriteLine(content.Title);
            //}
            DisplayAllTitles();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Please enter the title you would like to delete:");
            string titleToUpdate = Console.ReadLine();
            StreamingContent contentToUpdate = _repo.GetContentByTitle(titleToUpdate);
            if (contentToUpdate == null)
            {
                Console.WriteLine("Content not found, press any key to continue...");
                Console.ReadKey();
                return;
            }
            Console.Clear();
            Console.WriteLine("------Updating Conent------");
            DisplayContent(contentToUpdate);
            Console.WriteLine("---------------------------");

            StreamingContent newContent = new StreamingContent();

            Console.WriteLine("Enter Title:");
            newContent.Title = Console.ReadLine();

            Console.WriteLine("Enter Description:");
            newContent.Description = Console.ReadLine();

            Console.WriteLine("Enter Star Rating(1.0-10.0):");
            newContent.StarRating = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ente number for Genre:");
            Console.WriteLine("1. Horror");
            Console.WriteLine("2. RomCom");
            Console.WriteLine("3. Sci-Fi");
            Console.WriteLine("4. Action");
            Console.WriteLine("5. Documentary");
            Console.WriteLine("6. Musical");
            Console.WriteLine("7. Drama");
            Console.WriteLine("8. Mystery");
            /*string genreInput = Console.ReadLine();
            int genreAsInt = int.Parse(genreInput);
            newContent.Genre = (Genre)genreAsInt; */
            newContent.Genre = (Genre)int.Parse(Console.ReadLine());

            bool stopRunning = false;
            while (!stopRunning) //Maturity Rating Loop
            {
                Console.WriteLine("Enter number for Content Rating:");
                Console.WriteLine("1. G");
                Console.WriteLine("2. PG");
                Console.WriteLine("3. PG-13");
                Console.WriteLine("4. R");
                Console.WriteLine("5. NC-17");
                //newContent.MaturityRating = (MaturityRating)int.Parse(Console.ReadLine());
                string maturityRating = Console.ReadLine();
                switch (maturityRating)
                {
                    case "1":
                        newContent.MaturityRating = MaturityRating.G;
                        stopRunning = true;
                        break;
                    case "2":
                        newContent.MaturityRating = MaturityRating.PG;
                        stopRunning = true;
                        break;
                    case "3":
                        newContent.MaturityRating = MaturityRating.PG_13;
                        stopRunning = true;
                        break;
                    case "4":
                        newContent.MaturityRating = MaturityRating.R;
                        stopRunning = true;
                        break;
                    case "5":
                        newContent.MaturityRating = MaturityRating.NC_17;
                        stopRunning = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input.");
                        break;


                }
            }                //Maturity Rating Loop

            Console.Clear();
            Console.WriteLine("------Replacing------");
            DisplayContent(contentToUpdate);
            Console.WriteLine("-----------With------------");
            DisplayContent(newContent);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Continue? (Type 'yes' or 'no')");
            string continueUpdate = Console.ReadLine();

            if (continueUpdate.ToLower() == "yes" || continueUpdate.ToLower() == "y")
            {
                
                bool wasAdded = _repo.UpdateExistingContent(contentToUpdate.Title,newContent);
                if (wasAdded == true)
                {
                    Console.WriteLine("Your Content was successfully updated.");
                    Console.WriteLine("Press any key to return to menu.");

                }
                else
                {
                    Console.WriteLine("Opps. Something went wrong. Your Content was not added. Please try again");
                    Console.WriteLine("Press any key to return to menu.");

                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Update canceled. Press any key to return to Main Menu");
                Console.ReadKey();
            }





        }

        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title { content.Title}");
            Console.WriteLine($"Description: {content.Description}");
            Console.WriteLine($"Star Rating: {content.StarRating}");
            Console.WriteLine($"Genre: {content.Genre}");
            Console.WriteLine($"Maturity Rating: {content.MaturityRating}");
            Console.WriteLine($"Family Friendly: {content.IsFamilyFriendly}");
        }
        private void DisplayAllTitles()
        {
            List<StreamingContent> listOfContent = _repo.GetContents(); //Display all titles in the repo
            foreach (StreamingContent content in listOfContent)
            {
                Console.WriteLine(content.Title);
            }
        }

        private void DeleteContent()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("------Deleting Conent------");
            Console.ResetColor();
            Console.WriteLine("Currently Available Titles:");
            List<StreamingContent> listOfContent = _repo.GetContents(); //Display all titles in the repo
            foreach (StreamingContent content in listOfContent)
            {
                Console.WriteLine(content.Title);
            }
            Console.WriteLine("---------------------------");

            Console.WriteLine("Please enter the title you would like to delete:");
            string titleToDelete = Console.ReadLine();
            StreamingContent contentToDelete = _repo.GetContentByTitle(titleToDelete);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("------Deleting Conent------");
            Console.ResetColor();
            DisplayContent(contentToDelete);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Continue? (Type 'yes' or 'no')");
            string continueUpdate = Console.ReadLine();

            if (continueUpdate.ToLower() == "yes" || continueUpdate.ToLower() == "y")
            {

                bool wasDeleted = _repo.DeleteExistingContent(contentToDelete); //Delete repo
                if (wasDeleted == true)
                {
                    Console.WriteLine("Your Content was successfully updated.");
                    Console.WriteLine("Press any key to return to menu.");

                }
                else
                {
                    Console.WriteLine("Opps. Something went wrong. Your Content was not added. Please try again");
                    Console.WriteLine("Press any key to return to menu.");

                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Deletion canceled. Press any key to return to Main Menu");
                Console.ReadKey();
            }

         }

    }
}

