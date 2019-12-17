using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieOriginalExport;

namespace MovieOriginalImport
{
    public class Movie
    {
        public Movie()
        {
            List<IGenre> genreList = new List<IGenre>();
            genreList.Add(new Drama());
            genreList.Add(new Horror());
            genreList.Add(new Comedy());
            this.GenreList = genreList;
        }

        IEnumerable<IGenre> GenreList { get; set; }
        public void Story()
        {
            foreach (IGenre genre in this.GenreList)
            {
                genre.Story();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            movie.Story();
        }
    }
}
