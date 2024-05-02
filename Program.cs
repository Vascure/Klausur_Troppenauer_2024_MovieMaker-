
using Klausur_Troppenauer_2024_MovieMaker_;

internal class Program
{
    static void Main(string[] args)
    {
        AdultRentalStore adultRentalStore = new AdultRentalStore(new List<Movie>());
        KidsRentalStore kidsRentalStore = new KidsRentalStore(new List<Movie>());

      

        var validInput = false;
        while (!validInput)
        {
            Console.WriteLine("Which Movies do you want to browse?");
            Console.WriteLine("Press A to check out the Adult movies");
            Console.WriteLine("Press K to check out the Kids movies");
            Console.WriteLine("Press X to exit the store.");


            string input = Console.ReadLine();

            if (input == "A" || input == "a")
            {
                adultRentalStore.Start();
            }
            else if (input == "K" || input == "k")
            {
                kidsRentalStore.Start();
            }
            else if (input == "X" || input == "x")
            {
                Console.WriteLine("Good bye");
                validInput = true;
            }
            else
            {
                Console.WriteLine("Sorry, I don't understand what you're trying to tell me.");
            }
        }

    }
}
