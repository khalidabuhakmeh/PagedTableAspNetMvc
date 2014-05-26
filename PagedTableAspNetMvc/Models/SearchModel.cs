using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using PagedList;

namespace PagedTableAspNetMvc.Models
{
    public class SearchModel
    {
        public SearchModel()
        {
            Page = 1;
            Size = 10;
        }

        public int Page { get; set; }
        public int Size { get; set; }
    }

    public class IndexModel
    {
        public SearchModel Search { get; set; }

        public IndexModel(SearchModel search)
        {
            People = new PagedList<Person>(new List<Person>(), 1, search.Size);
            Search = search;
        }

        public IPagedList<Person> People { get; set; }
    }
}