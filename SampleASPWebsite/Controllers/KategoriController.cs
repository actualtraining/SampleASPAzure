using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;
using SampleASPWebsite.Models;

namespace SampleASPWebsite.Controllers
{
    public class KategoriController : Controller
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        // GET: Kategori
        public ActionResult Index()
        {
            List<Kategori> listKategori;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                string strSql = @"select * from Kategori order by KategoriNama asc";
                listKategori = conn.Query<Kategori>(strSql).ToList();
            }
            return View(listKategori);
        }

        // GET: Kategori/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kategori/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kategori/Create
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

        // GET: Kategori/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kategori/Edit/5
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

        // GET: Kategori/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kategori/Delete/5
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
    }
}
