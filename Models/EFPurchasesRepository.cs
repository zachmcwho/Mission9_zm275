using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_zm275.Models
{
    public class EFPurchasesRepository : IPurchasesRepository
    {
        private BookstoreContext context;
        public EFPurchasesRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Purchase> Purchases => throw new NotImplementedException();

        public void SavePurchase(Purchase purchase)
        {
            throw new NotImplementedException();
        }
    }

}
