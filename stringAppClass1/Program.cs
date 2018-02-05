using System;

namespace stringAppClass1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Give me a string to search in Alice's Adventures in Wonderland:");
           string searchInput = Console.ReadLine().ToLower();

            string aliceAdventures = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'".ToLower();


            aliceAdventures = aliceAdventures.Replace("'", "");
            aliceAdventures = aliceAdventures.Replace(",", "");
            aliceAdventures = aliceAdventures.Replace(":", "");
            aliceAdventures = aliceAdventures.Replace("?", "");

            if (aliceAdventures.Contains(searchInput))
            {
                Console.WriteLine("Congrats! " + searchInput.ToUpper() + " was found.");
            }
            else
            {
                Console.WriteLine("Sorry, '" + searchInput + "' was not found, try again.");

            }

            Console.WriteLine("Press enter to exit!");
            Console.ReadLine();
        }
    }
}



//am i supposed to put the search function in it's own method? 