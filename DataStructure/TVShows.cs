using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class TVShows
    {
        public string title = "untitled";
        public int releaseyear;
        public double price;
        public MovieRating rating;

        public TVShows(string title, int releaseyear, double price, MovieRating rating)
        {
            this.title = title;
            this.releaseyear = releaseyear;
            this.price = price;
            this.rating = rating;
        }

        public override string ToString()
        {
            return title + "(" + releaseyear + ") Rated " + "...£" + price.ToString("0.00");
        }

    }
}
