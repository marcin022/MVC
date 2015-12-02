using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Project1.Models;

namespace WebApplication.Project1.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            var result = from r in _articles
                orderby r.ArticleId
                select r;
            return View(result);
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        List<Article> _articles = new List<Article>()
        {
            new Article
            {
                ArticleId = 1,
                Author = "Marcin",
                Context = "Lorem ipsum patafianie",
                Title = "Dupa"
            },
            new Article
            {
                ArticleId = 2,
                Author = "Lolo",
                Context = "Sssij szmato ",
                Title = "o boze"
            }
        };
    }
}
