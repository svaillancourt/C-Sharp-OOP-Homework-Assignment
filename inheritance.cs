using System;

namespace inheritance
{
    class Painting
    {
        public string PaintingName = "The Faculty of Arts Auction";
        public void greet()
        {
            Console.WriteLine("Welcome back!");
        }
    }

    class User : Painting // User inherites from Painting
    {
        public string userName = "Stephane";
        public string userArtist = "Step";
        public string userMedium = "Musical";
        public string userYear = "1988";
    }
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User();
            newUser.greet();
            Console.WriteLine(newUser.userName + " is a member of " + newUser.PaintingName);
            Console.WriteLine("His Artist alias is " + newUser.userArtist + ".");
            Console.WriteLine("He expresses himself through the " + newUser.userMedium + " medium");
            Console.WriteLine("Step's first album was released in " + newUser.userYear + ".");
        }
    }
}

