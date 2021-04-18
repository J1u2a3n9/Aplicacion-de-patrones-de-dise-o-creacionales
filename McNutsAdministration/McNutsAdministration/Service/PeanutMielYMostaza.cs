using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    class PeanutMielYMostaza : PeanutModelAndService
    {
        public PeanutMielYMostaza()
        {
            CreatePeanutFlavor();
        }
        public override void CreatePeanutFlavor()
        {
            Id = "MM1";
            Name = "Mc Nuts Sabor Miel y Mostaza";
            ElaborationDate = DateTime.Now;
            ExpirationDate = ElaborationDate.AddMonths(2);
            UnitCost = 15;
            WholesalePrice = 10;
            Amount = 50;
            ProductionStatus = true;
            DiscontinuationDate = null;
            ProductionStartDate = DateTime.Now;
        }
    }
}
