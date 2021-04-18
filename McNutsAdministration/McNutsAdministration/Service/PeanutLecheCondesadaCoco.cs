using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    class PeanutLecheCondesadaCoco : PeanutModelAndService
    {
        public PeanutLecheCondesadaCoco()
        {
            CreatePeanutFlavor();
        }
        public override void CreatePeanutFlavor()
        {
            Id = "Coco1";
            Name = "Mc Nuts Sabor Leche condensada con Mani";
            ElaborationDate =DateTime.Now;
            ExpirationDate = ElaborationDate.AddMonths(2);
            UnitCost = 10;
            WholesalePrice = 8;
            Amount = 25;
            ProductionStatus = true;
            DiscontinuationDate = null;
            ProductionStartDate = DateTime.Now;
        }

    }
}
