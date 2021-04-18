using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    class ConcretePeanutFactory : PeanutsFactory
    {
        public override PeanutModelAndService GetPeanut(string peanutFlavor)
        {
            switch (peanutFlavor.ToLower())
            {
                case "miel":
                case "mostaza":
                case "miel y mostaza":
                    return new PeanutMielYMostaza();
                case "coco":
                case "leche condensada y coco":
                case "leche condensada":
                    return new PeanutLecheCondesadaCoco();
                case "oreo":
                    return new PeanutOreo();
                case "picante":
                    return new PeanutPicante();
                default:
                    throw new Exception($"No existe el sabor  {peanutFlavor} dentro nuestro catalogo :C");
                    
            }
        }
    }
}
