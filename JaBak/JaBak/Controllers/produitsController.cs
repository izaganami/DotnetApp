using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using JaBak.Models;


namespace JaBak.Controllers
{
    public class produitsController : Controller
    {
        private appEntities db = new appEntities();

        // GET: produits
        [Authorize]
        public ActionResult Index()
        {
            return View(db.produit.ToList());
        }


        // GET: produits/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            produit produit = db.produit.Find(id);
            if (produit == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(produit);
        }


        [Authorize(Roles = "fournisseur")]
        // GET: produits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: produits/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_produit,libelle,catégorie,prix,quantité,id_fournisseur")] produit produit, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                ///***************************


                produit. id_fournisseur = User.Identity.GetUserId();


                if (image != null)
                {
                    produit.ImageMimeType = image.ContentType;
                    produit.PhotoFile = new byte[image.ContentLength];
                    image.InputStream.Read(produit.PhotoFile, 0, image.ContentLength);
                }

                ////******************************

                db.produit.Add(produit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produit);
        }


        public FileContentResult GetImage(int id)
        {
            produit pro = db.produit.Find(id);
            if (pro != null)
            {
                return File(pro.PhotoFile, pro.ImageMimeType);
            }
            else return null;
        }



        // GET: produits/Edit/5


        [Authorize(Roles = "fournisseur")]
        [HttpGet]


        public ActionResult Edit(int id)
        {
            produit produit = db.produit.Find(id);
            if (produit == null)
            {
                return HttpNotFound();
            }
            return View(produit);
        }

        // POST: produits/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_produit,libelle,catégorie,prix,quantité,id_fournisseur")] produit produit)
        {
            if (produit.id_fournisseur == User.Identity.GetUserId())
            {
                db.Entry(produit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            else
            {
                return View("Forbidden");
            }
        }

        // GET: produits/Delete/5
        public ActionResult Delete(int id)
        {
            produit produit = db.produit.Find(id);
            if (produit == null)
            {
                return HttpNotFound();
            }
            return View(produit);
        }


        // POST: produits/Delete/5
        [Authorize (Roles ="fournisseur")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            produit produit = db.produit.Find(id);
            if (produit.id_fournisseur== User.Identity.GetUserId())
            {
                db.produit.Remove(produit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Forbidden");
            }
            
            
        }

        [Authorize(Roles = "client")]
        [HttpGet]
        public ActionResult Acheter()
        {
            return View();
        }

        [Authorize(Roles = "client")]
        [HttpPost]
        public ActionResult Acheter(int id)
        {
            produit produit = db.produit.Find(id);
            if (produit == null)
            {
                return HttpNotFound();
            }

            acheter achat= new acheter();

            if (ModelState.IsValid)
            {
                if (produit.quantité>0)
                {
                    achat.id_produit = produit.id_produit;
                    achat.id_client = User.Identity.GetUserId();
                    achat.id_fournisseur = produit.id_fournisseur;
                    achat.Email= User.Identity.GetUserName();
                    achat.libelle = produit.libelle;
                    achat.catégorie = produit.catégorie;
                    achat.Prix = produit.prix;
                    db.acheter.Add(achat);
                    produit.quantité = produit.quantité - 1;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else if (produit.quantité==0)
                {
                    return View("Empty");
                }
                
            }
            return View(achat);
        }

        [Authorize(Roles = "client")]
        [HttpGet]
        public ActionResult reserver()
        {
            return View();
        }
        [Authorize(Roles = "client")]
        [HttpPost]
        public ActionResult reserver(int id)
        {
            produit produit = db.produit.Find(id);
            if (produit == null)
            {
                return HttpNotFound();
            }

            reserver reservation = new reserver();

           if (ModelState.IsValid)
            {
                if (produit.quantité > 0)
                {
                    return View("Full");
                }
                else
                {

                    reservation.id_produit = produit.id_produit;
                    reservation.id_client = User.Identity.GetUserId();
                    reservation.id_fournisseur = produit.id_fournisseur;
                    reservation.Email= User.Identity.GetUserName();
                    reservation.libelle = produit.libelle;
                    reservation.catégorie = produit.catégorie;
                    reservation.Prix = produit.prix;
                    db.reserver.Add(reservation);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(reservation);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
