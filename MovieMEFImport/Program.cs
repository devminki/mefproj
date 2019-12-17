using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
//using System.Reflection;
using MovieMefExport;

namespace MovieMefImport
{
    public class Movie
    {
        private CompositionContainer _container;

        public Movie()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog(@"../../lib"));

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
