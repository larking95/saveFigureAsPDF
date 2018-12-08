using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppt2pdf
{
    internal class SaveFigure
    {
        private Settings1 Settings1 = new Settings1();
        internal SaveFigure()
        {
            System.Diagnostics.Debug.WriteLine("aaaaaaaaaaaaaaaaaaaaaaa");
            System.Diagnostics.Debug.WriteLine(Settings1.pathDefaultSave);
            Settings1.pathDefaultSave = @"c://";
            System.Diagnostics.Debug.WriteLine(Settings1.pathDefaultSave);
        }
    }
}
