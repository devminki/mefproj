using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Movie_MVVM_MEF_Sample.Model
{
    public class Movie
    {
        private CompositionContainer _container;
        public string strMovieStoryList = "Movie : ";
        public Movie()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Movie).Assembly));
            //catalog.Catalogs.Add(new DirectoryCatalog(@"../../lib"));

            _container = new CompositionContainer(catalog);

            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }

        [ImportMany(typeof(IGenre))]
        IEnumerable<IGenre> GenreList { get; set; }
        public string Story()
        {
            foreach (IGenre movie in this.GenreList)
            {
                strMovieStoryList += " ";
                strMovieStoryList += movie.Story();
            }
            return strMovieStoryList;
        }
    }
}