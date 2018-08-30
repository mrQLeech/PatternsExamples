using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    abstract class State
    {
        protected Context Context { get; set; }

        public void SetContext(Context context)
        {
            this.Context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }
}
