using System;
namespace MediaLibrary{
    class Media<T>
    {
        //common attribute for all book, cd, dvd
        public string? Title { get; set; } 
        public string? Author { get; set; }
        public int ReleaseYear { get; set; }
        public virtual void ShowDetails()
        {
            Console.Write($"Title:\t{Title} Author:\t{Author} Release Year:\t{ReleaseYear} ");
        }
    }
}