using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singer s = new Singer();
            s.Name = "Elvis";
            Console.WriteLine(s.Name);


            s.Surname = "Presli";
            Console.WriteLine(s.Surname);

            s.Age =40 ;
            Console.WriteLine(s.Age);

            Song sng = new Song();
            sng.Name = "Zombie";
            sng.Genre = "Rock";
            sng.singer = new Singer();
            sng.singer.Name = "Dolores";
            sng.singer.Surname = "Eileen";
            sng.singer.Age = 30;
            Console.WriteLine(sng.singer.Name);

            sng.AddNewRating(5);
            sng.AddNewRating(4);
            sng.AddNewRating(3);
            Console.WriteLine(sng.FingAverageRating());
        }
    }
}
