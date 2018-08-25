﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class PdfExporterCreator : ExporterCreator
    {
        public override IExporter Create()
        {
            return new PdfExporter();
        }
    }
}
