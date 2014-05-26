using System.Linq;
using System.Web.Mvc;
using PagedTableAspNetMvc.Models;
using PagedList;

namespace PagedTableAspNetMvc.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Index(SearchModel search)
        {
            using (var database = new ExampleDataContext())
            {
                var model = new IndexModel(search)
                {
                    People = database.People
                    .OrderBy(x => x.FullName)
                    .ToPagedList(search.Page, search.Size)
                };

                return View(model);    
            }            
        }
    }
}
