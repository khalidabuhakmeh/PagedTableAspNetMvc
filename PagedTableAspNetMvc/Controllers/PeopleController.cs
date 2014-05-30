using System.Linq;
using System.Web.Mvc;
using PagedTableAspNetMvc.Models;
using PagedList;

namespace PagedTableAspNetMvc.Controllers
{
    public class PeopleController : Controller
    {
        public ExampleDataContext Database { get; set; }

        public PeopleController()
        {
            Database = new ExampleDataContext();
        }

        public ActionResult Index(SearchModel search)
        {
            var model = new IndexModel(search)
            {
                People = Database.People
                .OrderBy(x => x.FullName)
                .ToPagedList(search.Page, search.Size)
            };

            return View(model);
        }

        public ActionResult New()
        {
            return View(new EditModel());
        }

        [HttpPost]
        public ActionResult Create(EditModel input)
        {
            if (ModelState.IsValid)
            {
                var person = input.ToPerson();
                Database.People.Add(person);
                Database.SaveChanges();

                return RedirectToAction("Edit", new {id = person.Id});
            }

            return View("New", input);
        }

        public ActionResult Edit(int id)
        {
            var person = Database.People.Find(id);
            return View(new EditModel(person));
        }

        [HttpPost, HttpPut]
        public ActionResult Update(EditModel input)
        {
            if (ModelState.IsValid)
            {
                var person = Database.People.Find(input.Id);
                input.ToPerson(person);

                Database.SaveChanges();

                return RedirectToAction("Edit", new { id = person.Id });
            }

            return View("Edit", input);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            Database.Dispose();
        }
    }
}
