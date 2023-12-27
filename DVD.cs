using System;
namespace MediaLibrary
{
    class DVD : Media<string>
    {
        public string? Producer{ get; set; } // Director of DVD
        public string? Genre{ get; set; } // Genre of DVD
        public override void ShowDetails()
        {
            Console.WriteLine("#######################################################################################");
            Console.WriteLine($"Title of The DVD:\t{Title}\nAuthor of The DVD:\t{Author}\nRelease Year:\t{ReleaseYear}\nGenre or DVD:\t{Genre}\nDirector of DVD:\t{Producer}");
        }
    }
}