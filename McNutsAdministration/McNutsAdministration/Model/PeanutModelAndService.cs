using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    public abstract class PeanutModelAndService
    {
        public string? Id { get; set; }
        public string Name { get; set; }
        public DateTime ElaborationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public long? UnitCost { get; set; }
        public long? WholesalePrice { get; set; }
        public long? Amount { get; set; }
        public bool? ProductionStatus { get; set; }
        public DateTime? DiscontinuationDate { get; set; }
        public DateTime? ProductionStartDate { get; set; }
        public abstract void CreatePeanutFlavor();
        public void AddAmount(int amount)
        {
            if(amount<0 && Amount>0 || amount>0)
            {
                Amount = amount + amount;
            }
        }

        public void UpdateProductionStatus()
        {
            if(ProductionStatus==false)
            {
                ProductionStatus = true;
                ProductionStartDate = DateTime.Now;
            }
            else
            {
                ProductionStatus = false;
                DiscontinuationDate = DateTime.Now;
            }
        }

        public void UpdateUnitCost(long unitCost)
        {
            UnitCost = unitCost;
        }

        public void UpdateWholesaleCost(long wholesaleCost)
        {
            WholesalePrice = wholesaleCost;
        }

    }
}
