using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieOriginalExport
{
    public class Drama : IGenre
    {
        public void Story()
        {
            Console.WriteLine("Romance");
        }
    }
}
