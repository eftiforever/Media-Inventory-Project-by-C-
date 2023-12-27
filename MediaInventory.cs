using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Immutable;
using System.Data;
using System.Globalization;
using Microsoft.VisualBasic;

namespace MediaLibrary
{
    class MediaInventory : Media<string>
    {
        // List<Book> books = new List<Book>(); // list of books only
        // List<CD> cds = new List<CD>(); // list of cds only
        // List<DVD> dvds = new List<DVD>(); // list of dvds only
        // Method for Add Media
        List<Media<string>> medias = new List<Media<string>>();
        public void AddMedia()
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Add CD");
            Console.WriteLine("3. Add DVD");
            Console.Write("Select a menu : ");

            int m = Convert.ToInt32(Console.ReadLine());

            if (m == 1)
            {
                Book book = new Book();
                Console.Write("Name of the Title : ");
                book.Title = Console.ReadLine();
                Console.Write("Name of the Author : ");
                book.Author = Console.ReadLine();
                Console.Write("Release Year : ");
                book.ReleaseYear = Convert.ToInt32(Console.ReadLine());
                Console.Write("Genre : ");
                book.Genre = Console.ReadLine();
                Console.Write("Price : ");
                book.Price = Convert.ToDecimal(Console.ReadLine());
                medias.Add(book); // adding to the list of books
            }

            else if (m == 2)
            {
                CD cd = new CD();
                Console.Write("Name of the CD title : ");
                cd.Title = Console.ReadLine();
                Console.Write("Name of the Author : ");
                cd.Author = Console.ReadLine();
                Console.Write("Release Year : ");
                cd.ReleaseYear = Convert.ToInt32(Console.ReadLine());
                Console.Write("Artist of the CD : ");
                cd.Artist = Console.ReadLine();
                Console.Write("Genre : ");
                cd.Genre = Console.ReadLine();
                Console.Write("Price : ");
                cd.Price = Convert.ToDecimal(Console.ReadLine());
                medias.Add(cd); // adding to the list of cds
            }

            else if (m == 3)
            {
                DVD dvd = new DVD();
                Console.Write("Name of the DVD title : ");
                dvd.Title = Console.ReadLine();
                Console.Write("Name of the Author : ");
                dvd.Author = Console.ReadLine();
                Console.Write("Release Year : ");
                dvd.ReleaseYear = Convert.ToInt32(Console.ReadLine());
                Console.Write("Producer of the DVD : ");
                dvd.Producer = Console.ReadLine();
                Console.Write("Genre : ");
                dvd.Genre = Console.ReadLine();
                medias.Add(dvd); // adding the list of dvds
            }
        }

        public void RemoveMedia()
        {
            Console.WriteLine("1. Book");
            Console.WriteLine("2. CD");
            Console.WriteLine("7. DVD title");
            Console.WriteLine("8. DVD Author");
            Console.WriteLine("9. DVD Release Year");
            Console.Write("Select a menu : ");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("1. By Book title");
                Console.WriteLine("2. By Book Author");
                Console.WriteLine("3. By Book Release Year");
                Console.WriteLine("4. By Book Genre");
                Console.Write("Select a menu : ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Name the Title of Book: ");
                    string? requiredBookTitle = Console.ReadLine();
                    var booktoremove = medias.OfType<Book>().FirstOrDefault(b => b.Title == requiredBookTitle);

                    if (booktoremove != null)
                    {
                        medias.Remove(booktoremove); // remove the content of the desired term
                        Console.WriteLine("Book has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Book has not found in the library.");
                    }
                }
                else if (choice == 2)
                {
                    Console.Write("Name the Author of Book: ");
                    string? requiredBookAuthor = Console.ReadLine();
                    var booktoremove = medias.OfType<Book>().FirstOrDefault(b => b.Author == requiredBookAuthor);

                    if (booktoremove != null)
                    {
                        medias.Remove(booktoremove);// remove the content of the desired term
                        Console.WriteLine("Book has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Book has not found in the library.");
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter the Release Year of Book: ");
                    int requiredBookReleaseYear = Convert.ToInt32(Console.ReadLine());
                    var booktoremove = medias.OfType<Book>().FirstOrDefault(b => b.ReleaseYear == requiredBookReleaseYear);

                    if (booktoremove != null)
                    {
                        medias.Remove(booktoremove);// remove the content of the desired term
                        Console.WriteLine("Book has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Book has not found in the library.");
                    }
                }
                else if (choice == 4)
                {
                    Console.Write("Enter the Genre of Book: ");
                    string? requiredBookGenre = Console.ReadLine();
                    var booktoremove = medias.OfType<Book>().FirstOrDefault(b => b.Genre == requiredBookGenre);

                    if (booktoremove != null)
                    {
                        medias.Remove(booktoremove);
                        Console.WriteLine("Book has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Book has not found in the library.");
                    }
                }

            }
            else if (n == 2)
            {
                Console.WriteLine("1. By CD title");
                Console.WriteLine("2. By CD Author");
                Console.WriteLine("3. By CD Release Year");
                Console.WriteLine("4. By CD Genre");
                Console.WriteLine("5. By CD Artist");
                Console.Write("Select a menu:");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Name the Title of CD: ");
                    string? requiredCDTitle = Console.ReadLine();
                    var cdtoremove = medias.OfType<CD>().FirstOrDefault(c => c.Title == requiredCDTitle);

                    if (cdtoremove != null)
                    {
                        medias.Remove(cdtoremove);// remove the content of the desired term
                        Console.WriteLine("CD has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("CD has not found in the library.");
                    }
                }
                else if (choice == 2)
                {
                    Console.Write("Name the Author of CD: ");
                    string? requiredCDAuthor = Console.ReadLine();
                    var cdtoremove = medias.OfType<CD>().FirstOrDefault(c => c.Author == requiredCDAuthor);

                    if (cdtoremove != null)
                    {
                        medias.Remove(cdtoremove);// remove the content of the desired term
                        Console.WriteLine("CD has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("CD has not found in the library.");
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter the Release Year of CD: ");
                    int requiredCDRealeaseYear = Convert.ToInt32(Console.ReadLine());
                    var cdtoremove = medias.OfType<CD>().FirstOrDefault(c => c.ReleaseYear == requiredCDRealeaseYear);

                    if (cdtoremove != null)
                    {
                        medias.Remove(cdtoremove);// remove the content of the desired term
                        Console.WriteLine("CD has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("CD has not found in the library.");
                    }
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter the Genre of CD: ");
                    string? requiredCDGenre = Console.ReadLine();
                    var cdtoremove = medias.OfType<CD>().FirstOrDefault(c => c.Genre == requiredCDGenre);

                    if (cdtoremove != null)
                    {
                        medias.Remove(cdtoremove);
                        Console.WriteLine("CD has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("CD has not found in the library.");
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Enter the Artist of CD: ");
                    string? requiredCDArtist = Console.ReadLine();
                    var cdtoremove = medias.OfType<CD>().FirstOrDefault(c => c.Artist == requiredCDArtist);

                    if (cdtoremove != null)
                    {
                        medias.Remove(cdtoremove);
                        Console.WriteLine("CD has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("CD has not found in the library.");
                    }
                }
                else
                {
                    try
                    {
                        {
                            throw new Exception("Wrong INPUT submitted!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"WARNIG : {ex.Message}");
                    }
                }
            }
            else if (n == 3)
            {
                Console.WriteLine("1. By DVD title");
                Console.WriteLine("2. By DVD Author");
                Console.WriteLine("3. By DVD Release Year");
                Console.WriteLine("4. By DVD Genre");
                Console.WriteLine("5. By DVD Producer");
                Console.Write("Select a menu: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Name the Title of DVD: ");
                    string? requiredDVDTitle = Console.ReadLine();
                    var dvdtoremove = medias.OfType<DVD>().FirstOrDefault(d => d.Title == requiredDVDTitle);

                    if (dvdtoremove != null)
                    {
                        medias.Remove(dvdtoremove);// remove the content of the desired term
                        Console.WriteLine("DVD has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("DVD has not found in the library.");
                    }
                }
                else if (choice == 2)
                {
                    Console.Write("Name the Author of DVD: ");
                    string? requiredDVDAuthor = Console.ReadLine();
                    var dvdtoremove = medias.OfType<DVD>().FirstOrDefault(d => d.Author == requiredDVDAuthor);

                    if (dvdtoremove != null)
                    {
                        medias.Remove(dvdtoremove);// remove the content of the desired term
                        Console.WriteLine("DVD has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("DVD has not found in the library.");
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter the Release Year of DVD: ");
                    int requiredDVDReleaseYear = Convert.ToInt32(Console.ReadLine());
                    var dvdtoremove = medias.OfType<DVD>().FirstOrDefault(d => d.ReleaseYear == requiredDVDReleaseYear);

                    if (dvdtoremove != null)
                    {
                        medias.Remove(dvdtoremove);// remove the content of the desired term
                        Console.WriteLine("DVD has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("DVD has not found in the library.");
                    }
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter the Genre of DVD: ");
                    string? requiredDVDGenre = Console.ReadLine();
                    var dvdtoremove = medias.OfType<DVD>().FirstOrDefault(d => d.Genre == requiredDVDGenre);

                    if (dvdtoremove != null)
                    {
                        medias.Remove(dvdtoremove);
                        Console.WriteLine("DVD has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("DVD has not found in the library.");
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Enter the Producer of DVD: ");
                    string? requiredDVDProducer = Console.ReadLine();
                    var dvdtoremove = medias.OfType<DVD>().FirstOrDefault(d => d.Producer == requiredDVDProducer);

                    if (dvdtoremove != null)
                    {
                        medias.Remove(dvdtoremove);
                        Console.WriteLine("DVD has removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("DVD has not found in the library.");
                    }
                }
                try
                {
                    {
                        throw new Exception("Wrong INPUT submitted!!!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"WARNIG : {ex.Message}");
                }
            }
            else
            {
                try
                {
                    {
                        throw new Exception("Wrong INPUT submitted!!!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"WARNIG : {ex.Message}");
                }
            }
        }
        public void UpdateMedia()
        {
            Console.WriteLine("1. Update Book section");
            Console.WriteLine("2. Update CD section");
            Console.WriteLine("3. Update DVD section");
            Console.Write("Select a menu : ");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.Write("Enter the title of the book to update: ");
                string? updatedTitle = Console.ReadLine();
                var bookToUpdate = medias.OfType<Book>().FirstOrDefault(b => b.Title == updatedTitle); // find the update section

                if (bookToUpdate != null)
                { // ready to update the info
                    Console.Write("Enter the new title: ");
                    string? newTitle = Console.ReadLine();
                    Console.Write("Enter the new author: ");
                    string? newAuthor = Console.ReadLine();
                    Console.Write("Enter the new release year: ");
                    int newReleaseYear = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the new genre: ");
                    string? newGenre = Console.ReadLine();
                    Console.Write("Enter the new Price: ");
                    int newPrice = Convert.ToInt32(Console.ReadLine());
                    bookToUpdate.Title = newTitle;
                    bookToUpdate.Author = newAuthor;
                    bookToUpdate.ReleaseYear = newReleaseYear;
                    bookToUpdate.Genre = newGenre;
                    bookToUpdate.Price = newPrice;
                    Console.WriteLine("Book info updated.");
                }
                else
                {
                    Console.WriteLine("Book not found in library.");
                }
            }
            else if (n == 2)
            {
                Console.Write("Enter the title of the CD to update: ");
                string? updatedTitle = Console.ReadLine();

                var cdToUpdate = medias.OfType<CD>().FirstOrDefault(c => c.Title == updatedTitle);// find the update section

                if (cdToUpdate != null)
                {// ready to update the info
                    Console.Write("Enter the new title: ");
                    string? newTitle = Console.ReadLine();
                    Console.Write("Enter the new author: ");
                    string? newAuthor = Console.ReadLine();
                    Console.Write("Enter the new release year: ");
                    int newReleaseYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the new artist of the CD : ");
                    string? newartist = Console.ReadLine();
                    Console.WriteLine("Enter the new genre : ");
                    string? newGenre = Console.ReadLine();
                    Console.WriteLine("Enter the new price : ");
                    int newPrice = Convert.ToInt32(Console.ReadLine());
                    cdToUpdate.Title = newTitle;
                    cdToUpdate.Author = newAuthor;
                    cdToUpdate.ReleaseYear = newReleaseYear;
                    cdToUpdate.Artist = newartist;
                    cdToUpdate.Genre = newGenre;
                    cdToUpdate.Price = newPrice;
                    Console.WriteLine("CD info updated.");
                }
                else
                {
                    Console.WriteLine("CD not found in library.");
                }
            }
            else if (n == 3)
            {
                Console.Write("Enter the title of the DVD to update: ");
                string? updatedTitle = Console.ReadLine();
                var dvdToUpdate = medias.OfType<DVD>().FirstOrDefault(d => d.Title == updatedTitle);// find the update section

                if (dvdToUpdate != null)
                {// ready to update the info
                    Console.Write("Enter the new title: ");
                    string? newTitle = Console.ReadLine();
                    Console.Write("Enter the new author: ");
                    string? newAuthor = Console.ReadLine();
                    Console.Write("Enter the new release year: ");
                    int newReleaseYear = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the new Producer: ");
                    string? newProducer = Console.ReadLine();
                    Console.Write("Enter the new genre: ");
                    string? newGenre = Console.ReadLine();
                    dvdToUpdate.Title = newTitle;
                    dvdToUpdate.Author = newAuthor;
                    dvdToUpdate.ReleaseYear = newReleaseYear;
                    dvdToUpdate.Producer = newProducer;
                    dvdToUpdate.Genre = newGenre;
                    Console.WriteLine("DVD info updated.");
                }
                else
                {
                    Console.WriteLine("DVD not found in library.");
                }
            }
            else
            {
                try
                {
                    {
                        throw new Exception("Wrong INPUT submitted!!!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"WARNIG : {ex.Message}");
                }
            }
        }
        public void List()
        {
            Console.WriteLine("Types of List: ");
            Console.WriteLine("1. All Media");
            Console.WriteLine("2. Only Book");
            Console.WriteLine("3. Only CD");
            Console.WriteLine("4. Only DVD");
            Console.WriteLine("5. Oldest Entry");
            Console.WriteLine("6. Latest Entry");
            Console.WriteLine("7. Order By Descending");
            Console.WriteLine("8. Order By Ascending");
            Console.Write("Select a menu: ");

            int n = Convert.ToInt32(Console.ReadLine());
            if(n == 1)
            {
                foreach (Media<string> media in medias)
                {
                    if (media is Book book)
                    {
                        book.ShowDetails();
                    }
                    else if (media is CD cd)
                    {
                        cd.ShowDetails();
                    }
                    else if (media is DVD dvd)
                    {
                        dvd.ShowDetails();
                    }
                }
            }
            else if(n == 2)
            {
                foreach(Media<string> media in medias)
                {
                    if(media is Book book)
                    {
                        book.ShowDetails();
                    }
                }
            }
            else if(n == 3)
            {
                foreach(Media<string> media in medias)
                {
                    if(media is CD cd)
                    {
                        cd.ShowDetails();
                    }
                }
            }
            else if(n == 4)
            {
                foreach(Media<string> media in medias)
                {
                    if(media is DVD dvd)
                    {
                        dvd.ShowDetails();
                    }
                }
            }
            else if(n == 5)
            {
                var firstEntry = medias.Min(b => b.ReleaseYear);
                Console.WriteLine($"Oldest Entry Year:\t{firstEntry}");
            }
            else if(n == 6)
            {
                var lastEntry = medias.Max(b => b.ReleaseYear);
                Console.WriteLine($"Latest Entry Year:\t{lastEntry}");
            }
            else if(n == 7)
            {
                var orderbyDescending = medias.OrderByDescending(b => b.ReleaseYear);
                foreach(Media<string> media in orderbyDescending)
                {
                    media.ShowDetails();
                }
            }
            else if(n == 8)
            {
                var orderbyAscending = medias.OrderByDescending(b => b.ReleaseYear).Reverse();
                foreach(Media<string> media in orderbyAscending)
                {
                    media.ShowDetails();
                }
            }
            else
            {
                try
                {
                    {
                        throw new Exception("Wrong INPUT submitted!!!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"WARNIG : {ex.Message}");
                }
            }
        }
        public void Statistics()
        {
            Console.WriteLine("1. Sum of All Book Price: ");
            Console.WriteLine("2. Sum of All CD Price: ");
            Console.WriteLine("3. Number of All Collection: ");
            Console.WriteLine("4. Number of Books: ");
            Console.WriteLine("5. Number of CDs: ");
            Console.WriteLine("6. Number of DVDs: ");
            Console.Write("Select a menu: ");

            int choice = Convert.ToInt32(Console.Read());
            
            if(choice == 1)
            {
                var sumOfBookPrice = medias.OfType<Book>().Sum(b => b.Price);
                Console.WriteLine($"Sum of All Book Price : {sumOfBookPrice}");
            }
            else if(choice == 2)
            {
                var sumOfCDPrice = medias.OfType<CD>().Sum(cd => cd.Price);
                Console.WriteLine($"Sum of All CD Price : {sumOfCDPrice}");
            }
            else if(choice == 3)
            {
                var numberOfAll = medias.Count();
                Console.WriteLine($"Number of All Collection : {numberOfAll}");
            }
            else if(choice == 4)
            {
                var numberOfBooks = medias.OfType<Book>().Count();
                Console.WriteLine($"Number of Books : {numberOfBooks}");
            }
            else if(choice == 5)
            {
                var numberOfCDs = medias.OfType<CD>().Count();
                Console.WriteLine($"Number of CDs : {numberOfCDs}");
            }
            else if(choice == 6)
            {
                var numberOfDVDs = medias.OfType<DVD>().Count();
                Console.WriteLine($"Number of DVDs : {numberOfDVDs}");
            }
            try
            {
                {
                    throw new Exception("Wrong INPUT submitted!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"WARNIG : {ex.Message}");
            }
        }
        public void Search()
        {
            Console.Write("Type your desired key : ");
            string? key = Console.ReadLine();

            var booklist = medias.OfType<Book>();
            var cdlist = medias.OfType<CD>();
            var dvdlist = medias.OfType<DVD>();
            var Bookkey = booklist.Where(booklist => booklist.Title.Contains(key) || booklist.Author.Contains(key) || booklist.Genre.Contains(key));
            var CDkey = cdlist.Where(cdlist => cdlist.Title.Contains(key) || cdlist.Author.Contains(key) || cdlist.Artist.Contains(key) || cdlist.Genre.Contains(key));
            var DVDkey = dvdlist.Where(dvdlist => dvdlist.Title.Contains(key) || dvdlist.Author.Contains(key) || dvdlist.Producer.Contains(key) || dvdlist.Genre.Contains(key));
            
            if(Bookkey != null)
            {
                foreach(Media<String> media in Bookkey)
                {
                    media.ShowDetails();
                }
            }
            else if(CDkey != null)
            {
                foreach(Media<string> media in CDkey)
                {
                    media.ShowDetails();
                }
            }
            else if(DVDkey != null)
            {
                foreach(Media<string> media in DVDkey)
                {
                    media.ShowDetails();
                }
            }
            else
            {
                Console.WriteLine("Sorry Couldn't found any record");
            }
        }
    }
}