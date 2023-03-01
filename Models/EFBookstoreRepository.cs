using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_zm275.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext Books { get; set; }

        public EFBookstoreRepository(BookstoreContext temp) => Books = temp;

        public IQueryable<Books> Book => Books.Books;
    }
}
