using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace Movie_MVVM_MEF_Sample
{
    [Export(typeof(IGenre))]
    public class Drama : IGenre
    {
        public string Story()
        {
            return "Romance";
        }
    }
}