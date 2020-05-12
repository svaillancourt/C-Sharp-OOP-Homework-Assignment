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

        abstract class Artist : Name
        {
            public void myArtist()
            {
                Console.WriteLine("Artist: - Le Step - ");
            }
        }
        abstract class Medium : Artist
        {
            public void myMedium()
            {
                Console.WriteLine("Medium: Floppy Disk!");
            }
        }

        abstract class Year : Medium
        {
            public void myYear()
            {
                Console.WriteLine("Year: 1988!");
            }
        }
        class PublicDescription : Year
        {
            public void myPublicMessage()
            {
                Console.WriteLine("Welcome to the Art Gallery!");
            }
        }
        static void Main(string[] args)
        {
            PublicDescription myPubMsg = new PublicDescription();
            myPubMsg.myPublicMessage();
            myPubMsg.myName();
            myPubMsg.myArtist();
            myPubMsg.myMedium();
            myPubMsg.myYear();

        }
    }
}
