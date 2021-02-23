
using NetFlask.Models;
using NetFlask.Repositories;
using Netflask_again.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Netflask_again.Controllers
{
    public class HomeController : Controller
    {
        // route /Home/Index
        public ActionResult Index()
        {
            HomeViewModel hm = new HomeViewModel(); 
            ViewBag.Home = "active"; 
            return View(hm);
        }

        public ActionResult VideosTemp()
        {
            UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            List <Movie> lmv= uow.GetAllMovies(); 
            return View(lmv); 
        }

        //route /Home/Video
        public ActionResult Videos()
        {
            VideoViewModel vm = new VideoViewModel();
            ViewBag.Videos = "active";
            return View(vm);
        }

        public ActionResult Reviews()
        {
            ReviewsViewModel rm = new ReviewsViewModel();
            ViewBag.Reviews = "active";
            return View(rm);
        }

        public ActionResult Page404()
        {
            ViewBag.Page404 = "active";
            return View();
        }

        //Afficher le formulaire 
        [HttpGet]
        public ActionResult Contacts()
        {
            ViewBag.Contacts = "active";
            return View();
        }

        //Recuperer les données envoye de la view vers le controller
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contacts(Contact unContact)
        {
            if (ModelState.IsValid)
            {
                //je recupere la connectionString
                UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                if (uow.SaveContact(unContact))
                {
                    ViewBag.SuccessMessage = "Message bien envoyé"; 
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Message non enregistré";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Formulaire error";
                return View(); 
            }
    

        }

        [HttpPost]
        public ActionResult Search(string critere)
        {
            //1. Aller chercher dans la DB les films dont le titre ressemble à critere 
            //2. Garnir un modèle de recherche
            //3. Envoyer ce modèle vers la view
            return View("Resultats");
        }

    }
}