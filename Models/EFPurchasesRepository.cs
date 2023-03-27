using Microsoft.EntityFrameworkCore;
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
        public IQueryable<Purchase> Purchases => context.Purchases.Include(x => x.Lines).ThenInclude(x => x.Books);

        public void SavePurchase(Purchase purchase)
        {
            context.AttachRange(purchase.Lines.Select(x => x.Books));

            if (purchase.PurchaseId == 0)
            {
                context.Purchases.Add(purchase);
            }

            context.SaveChanges();
        }
    }

}
