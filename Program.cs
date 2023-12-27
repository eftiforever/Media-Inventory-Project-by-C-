using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace MediaLibrary{
    class Program{
        static void Main(){
            Media<dynamic> media = new Media<dynamic>();
            Book book = new Book();
            CD cd = new CD();
            DVD dvd = new DVD();
            MediaInventory mediaInventory = new MediaInventory();
            List<Media<string>> media_list = new List<Media<string>>();
            while(true){
                Console.WriteLine("1. Add Media");
                Console.WriteLine("2. Remove Media");
                Console.WriteLine("3. Update Media");
                Console.WriteLine("4. Get list");
                Console.WriteLine("5. Statistics");
                Console.WriteLine("6. Search with keyword");
                Console.Write("Select a menu : ");

                int n = Convert.ToInt32(Console.ReadLine());
                if(n == 1) mediaInventory.AddMedia();
                else if(n == 2) mediaInventory.RemoveMedia();
                else if(n == 3) mediaInventory.UpdateMedia();
                else if(n == 4) mediaInventory.List();
                else if(n == 5) mediaInventory.Statistics();
                else if(n == 6) mediaInventory.Search();
            }
        }
    }
}