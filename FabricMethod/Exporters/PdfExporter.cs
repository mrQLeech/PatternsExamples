using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class PdfExporter : IExporter
    {
        public void Export()
        {
            Console.WriteLine("Export to PDF");
        }
    }
}
