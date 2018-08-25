using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public abstract class ExporterCreator
    {
        public abstract IExporter Create();
    }
}
