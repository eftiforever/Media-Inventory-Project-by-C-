using System;
namespace MediaLibrary{
    class CD : Media<string>
    {
        public string? Artist{ get; set; } //CD artist
        public string? Genre{ get; set; } //CD genre
        public decimal Price{ get; set; } //CD price
        public override void ShowDetails()
        {
            Console.WriteLine("#######################################################################################");
            Console.WriteLine($"Title of The CD:\t{Title}\nAuthor of The CD:\t{Author}\nRelease Year:\t{ReleaseYear}\nGenre of CD:\t{Genre}\nPrice of CD:\t{Price}\n");
        }
    }
}