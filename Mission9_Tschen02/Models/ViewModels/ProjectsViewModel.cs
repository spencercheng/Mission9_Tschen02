using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_Tschen02.Models.ViewModels
{
    public class ProjectsViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }


    }
}
