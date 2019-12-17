using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace MovieMefExport
{
    [Export(typeof(IGenre))]
    public class Drama : IGenre
    {
        public void Story()
        {
            Console.WriteLine("Romance");
        }
    }
}
