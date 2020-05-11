using System;

namespace abstraction
{
    class Program
    {
        abstract class Name
        {
            public void myName()
            {
                Console.WriteLine("Name: - He's on FIRE! - ");
            }
        }

        abstract class Artist
        {
            public void myArtist()
            {
                Console.WriteLine("Artist: - He's on FIRE! - ");
            }
        }
        abstract class Medium
        {
            public void myMedium()
            {
                Console.WriteLine("Floppy Disk!");
            }
        }

        class PublicMessage : Name
        {
            public void myPublicMessage()
            {
                Console.WriteLine("Welcome to the Art Gallery!");
            }
        }
        static void Main(string[] args)
        {
            PublicMessage myPubMsg = new PublicMessage();
            myPubMsg.myPublicMessage();
            myPubMsg.myName();
            myPubMsg.myMedium();

        }
    }
}
