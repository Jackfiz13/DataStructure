using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie deadpool3;
            deadpool3.title = "Deadpool & Wolverine";
            deadpool3.releaseyear = 2024;
            deadpool3.price = 19.99;
            deadpool3.rating = MovieRating._15;

            Console.WriteLine(deadpool3.title + "(" + deadpool3.releaseyear + ") rated" + deadpool3.rating);

            Console.ReadKey();
            Console.WriteLine("\n\n");

            List<TVShows> shows = new List<TVShows>();
            shows.Add(new TVShows("the Lord of the Rings: The Rings of Power", 2022, 0, MovieRating._15));
            shows.Add(new TVShows("The Boys", 2019, 7.99, MovieRating._u));
            shows.Add(new TVShows("Thor", 2009, 12.45, MovieRating._u));

            for (int i = 0; i < shows.Count; i++)
            {
                Console.WriteLine(shows[i].ToString());
            }   
            Console.ReadKey();
        }
    }

    public enum MovieRating
    {
        _u,
        _12a,
        _12,
        _15,
        _18
    }
    public struct Movie
    {
        public string title;
        public int releaseyear;
        public double price;
        public MovieRating rating;

    }
}
