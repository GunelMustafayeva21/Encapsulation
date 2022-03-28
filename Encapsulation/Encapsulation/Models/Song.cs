using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    internal class Song
    {
        private string name;
        private string genre;
        private Singer sngr;
        private int[] ratings = new int[0];

        public string Name
        {

            set
            {
                if (value.Length < 100) name = value;
                else Console.WriteLine("Input for Name is invalid");
            }
            get { return name; }
        }


        public string Genre
        {

            set
            {
                if (value == "Pop" || value == "Rock" || value == "Jazz" || value == "Techno") genre = value;
                else Console.WriteLine("Input for Genre is invalid");
            }
            get { return genre; }
        }

        public Singer singer
        {
            set { sngr = value; }
            get { return sngr; }
        }
        
        public void AddNewRating(int newAdded)
        {
            Array.Resize(ref ratings, ratings.Length + 1);
            ratings[ratings.Length - 1] = newAdded;
        }

        public double FingAverageRating()
        {
            return Math.Round(ratings.Average(), 2);
        }

    }
}
