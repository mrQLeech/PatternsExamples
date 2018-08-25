using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class Exporter
    {
        public static IExporter Create(FileType fType)
        {
            ExporterCreator creator;
            switch (fType)
            {
                case (FileType.Pdf):
                {
                    creator = new PdfExporterCreator();
                    break;
                }
                default:
                    {
                        creator = new ExcelExporterCreator();
                        break;
                    }
                    
                   
            }

            return creator.Create();
        }
    }
}
