using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_Tschen02.Models
{
    public class EFBookProjectRepositoryClass : IBookProjectRepository
    {
        private BookstoreContext context { get; set; }
        public EFBookProjectRepositoryClass (BookstoreContext temp)
        {
            context = temp;

        }
        public IQueryable<Book> Books => context.Books;

    }
}
