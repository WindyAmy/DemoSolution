using BlogAppDAL;
using BlogAppDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        public ActionResult Index()
        {
            //var list = new IEnumerable<User>();
            using (BlogAppContext context = new BlogAppContext())
            {
                context.Database.CreateIfNotExists();
                Repository<User> r = new Repository<User>(context);
                var list = r.GetAllList();
                return View(list.ToList());
            }
            //return View();
        }

        //
        // GET: /Users/Details/5
        public ActionResult Details(int id)
        {
            using (BlogAppContext context = new BlogAppContext())
            {
                Repository<User> r = new Repository<User>(context);
                var model = r.Get(a => a.Id == id);
                return View(model);
            }
        }

        //
        // GET: /Users/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Users/Create
        [HttpPost]
        public ActionResult Create(User model)
        {
            try
            {
                using (BlogAppContext context = new BlogAppContext())
                {
                    Repository<User> r = new Repository<User>(context);
                    r.Insert(model);
                    context.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Users/Edit/5
        public ActionResult Edit(int id)
        {
            using (BlogAppContext context = new BlogAppContext())
            {
                Repository<User> r = new Repository<User>(context);
                var model = r.Get(a => a.Id == id);
                return View(model);
            }
        }

        //
        // POST: /Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User model)
        {
            try
            {
                // TODO: Add update logic here
                using (BlogAppContext context = new BlogAppContext())
                {
                    Repository<User> r = new Repository<User>(context);
                    r.Update(model);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Users/Delete/5
        public ActionResult Delete(int id)
        {
            using (BlogAppContext context = new BlogAppContext())
            {
                Repository<User> r = new Repository<User>(context);
                var model = r.Get(a => a.Id == id);
                return View(model);
            }
        }

        //
        // POST: /Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User model)
        {
            try
            {
                // TODO: Add delete logic here
                // TODO: Add update logic here
                using (BlogAppContext context = new BlogAppContext())
                {
                    Repository<User> r = new Repository<User>(context);
                    r.Delete(model);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}