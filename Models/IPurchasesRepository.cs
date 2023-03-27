using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_zm275.Models
{
    public interface IPurchasesRepository
    {
        IQueryable<Purchase> Purchases { get; }
        void SavePurchase(Purchase purchase);
    }

}
