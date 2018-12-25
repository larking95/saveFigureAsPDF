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
            if (Settings1.isInitialized == false)
            {
                // 初期化フラグが立っていない時，設定を初期化する
                Settings1.pathDefaultSave = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Settings1.pathMagick = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) 
                    + @"\ImageMagick-7.0.8-Q16\magick.exe";
                Settings1.pathPdfcrop = "pdfcrop.exe";
                Settings1.isInitialized = true;
            }
            System.Diagnostics.Debug.WriteLine("aaaaaaaaaaaaaaaaaaaaaaa");
            System.Diagnostics.Debug.WriteLine(Settings1.pathDefaultSave);
            System.Diagnostics.Debug.WriteLine(Settings1.pathMagick);
            System.Diagnostics.Debug.WriteLine(Settings1.pathPdfcrop);
        }
    }
}
