using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    class PeanutOreo : PeanutModelAndService
    {
        public PeanutOreo()
        {
            CreatePeanutFlavor();
        }
        public override void CreatePeanutFlavor()
        {
            Id = "Oreo1";
            Name = "Mc Nuts Sabor Oreo";
            ElaborationDate = DateTime.Now;
            ExpirationDate = ElaborationDate.AddMonths(2);
            UnitCost = 14;
            WholesalePrice = 7;
            Amount = 55;
            ProductionStatus = true;
            DiscontinuationDate = null;
            ProductionStartDate = DateTime.Now;
        }
    }
}
