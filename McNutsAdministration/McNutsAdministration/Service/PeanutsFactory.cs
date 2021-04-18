using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    public abstract class PeanutsFactory
    {
        public abstract PeanutModelAndService GetPeanut(string peanutFlavor);
    }
}
