using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JaBak.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "fournisseur")]
        public ActionResult Getproducts(string id)
        {
            SqlConnection con = new SqlConnection();
            string path = ConfigurationManager.ConnectionStrings["app"].ConnectionString;
            con.ConnectionString = path;
            DataTable dt = new DataTable();

            
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select libelle,catégorie,prix from produit where id_fournisseur='"+id+"'", con);
                
                adp.Fill(dt);
            }
            catch (Exception)
            {
                throw;            }

            return View(dt);
        }

        [Authorize(Roles = "fournisseur")]
        public ActionResult Getinfos(String id)
        {
            SqlConnection con = new SqlConnection();
            string path = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            con.ConnectionString = path;
            DataTable dt = new DataTable();


            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select Nom,Prenom from AspNetUsers where Id='"+id+"'", con);

                adp.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }

            return View(dt);
        }

        [Authorize(Roles = "fournisseur")]
        public ActionResult Getfournisseurs()
        {
            SqlConnection con = new SqlConnection();
            string path = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            con.ConnectionString = path;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select Id,Nom,Prenom,Email from AspNetUsers,AspNetUserRoles where AspNetUsers.Id=AspNetUserRoles.UserId and RoleId='501fd159-826e-4de4-9aef-49e537312596'", con);

                adp.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return View(dt);
        }

        [Authorize(Roles = "fournisseur")]
        public ActionResult Getclientsacheter()
        {
            SqlConnection con = new SqlConnection();
            string path = ConfigurationManager.ConnectionStrings["app"].ConnectionString;
            con.ConnectionString = path;
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select id_client,Email,libelle,catégorie from acheter where id_fournisseur='" + User.Identity.GetUserId() + "'", con);

                adp.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return View(dt);
        }

        [Authorize(Roles = "fournisseur")]
        public ActionResult Getclientsreserver()
        {
            SqlConnection con = new SqlConnection();
            string path = ConfigurationManager.ConnectionStrings["app"].ConnectionString;
            con.ConnectionString = path;
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select id_client,Email,libelle,catégorie from reserver where id_fournisseur='" + User.Identity.GetUserId() + "'", con);

                adp.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return View(dt);
        }



        [Authorize(Roles = "fournisseur")]
        public ActionResult Getclients()
        {
            return View();
        }


        [Authorize(Roles = "client")]
        public ActionResult monpanier()
        {
            SqlConnection con = new SqlConnection();
            string path = ConfigurationManager.ConnectionStrings["app"].ConnectionString;
            con.ConnectionString = path;
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select libelle,catégorie,prix from acheter where id_client='" + User.Identity.GetUserId() + "'", con);

                adp.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return View(dt);
        }


        [Authorize(Roles = "client")]
        public ActionResult mesreservations()
        {
            SqlConnection con = new SqlConnection();
            string path = ConfigurationManager.ConnectionStrings["app"].ConnectionString;
            con.ConnectionString = path;
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select libelle,catégorie,prix from reserver where id_client='" + User.Identity.GetUserId() + "'", con);

                adp.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return View(dt);
        }

        
    }

    
}