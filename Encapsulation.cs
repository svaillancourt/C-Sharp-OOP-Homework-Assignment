using System;

namespace encapsulation{
    class Painting{
              private string paintingName;
              private string artist;
              private string medium;
              private string year;
              
              public string MyPaintingName { //accessors
                  get {
                      return paintingName;
                  } set {
                      paintingName = value;
                  }
              }  
              public string MyArtist { //accessor
                  get{
                      return artist;
                  } set {
                      artist = value;
                  }
              }
               public string MyMedium { //accessor
                  get{
                      return medium;
                  } set {
                      medium = value;
                  }
              }
              public string MyYear { //accessor
                  get{
                      return year;
                  } set {
                      year = value;
                  }
              }
            }
    class Program{ 
        static void Main(string[] args){
            Painting myPainting = new Painting();
            myPainting.MyPaintingName = "Buckets";
            myPainting.MyArtist = "Le Step";
            myPainting.MyMedium = "3D Clay Modeling";
            myPainting.MyYear = "1988";

            Console.WriteLine("--- Painting Listing ---\n");
            Console.WriteLine("Title: " + myPainting.MyPaintingName);
            Console.WriteLine("Artist: " + myPainting.MyArtist);
            Console.WriteLine("Medium: " + myPainting.MyMedium);
            Console.WriteLine("Created in: " + myPainting.MyYear);

            // string myOutput = myPainting.MyPassword;
            // Console.WriteLine(myOutput);
        }
    }
}
