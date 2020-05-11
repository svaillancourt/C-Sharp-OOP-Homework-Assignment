// using System;

// namespace polymorphism
// {
//     class Program
//     {
//         class myPainting
//         {
//             public virtual void details()
//             {
//                 Console.WriteLine("[Insert Painting Details Here]");
//             }
//         }

//         class Name : myPainting
//         {
//             public override void details()
//             {
//                 Console.WriteLine("Turning of the Tides!");
//             }
//         }

//         class Artist : myPainting
//         {
//             public override void details()
//             {
//                 Console.WriteLine("Stefawn");
//             }
//         }
//         class Medium : myPainting
//         {
//             public override void details()
//             {
//                 Console.WriteLine("Water colour");
//             }
//         }

//         class Year : myPainting
//         {
//             public override void details()
//             {
//                 Console.WriteLine("Released in 1988");
//             }
//         }

//         static void Main(string[] args)
//         {
//             myPainting mymyPainting = new myPainting();
//             myPainting myName = new Name();
//             myPainting myArtist = new Artist();
//             myPainting myMeidum = new Medium();
//             myPainting myYear = new Year();

//             mymyPainting.details();
//             myName.details();
//             myArtist.details();
//             myMeidum.details();
//             myYear.details();
//         }
//     }
// }

