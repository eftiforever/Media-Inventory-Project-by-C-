using System;
using System.Linq;

namespace MediaLibrary{
    partial class Book : Media<string>
    {
        public decimal Price { get; set; } //book price
        public string? Genre { get; set; } // book genre
        public override void ShowDetails()
        {
            Console.WriteLine("#######################################################################################");
            Console.WriteLine($"Title of The Book:\t{Title}\nAuthor of The Book:\t{Author}\nRelease Year:\t{ReleaseYear}\nGenre of Book:\t{Genre}\nPrice of Book:\t{Price}\n");
        }
    }
}