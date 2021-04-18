using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    class PeanutPicante : PeanutModelAndService
    {
        public PeanutPicante()
        {
            CreatePeanutFlavor();
        }
        public override void CreatePeanutFlavor()
        {
            Id = "Picante1";
            Name = "Mc Nuts Sabor Picante";
            ElaborationDate = DateTime.Now;
            ExpirationDate = ElaborationDate.AddMonths(2);
            UnitCost = 5;
            WholesalePrice = 3;
            Amount = 25;
            ProductionStatus = true;
            DiscontinuationDate = null;
            ProductionStartDate = DateTime.Now;
        }
    }
}
