﻿using System;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laptop.Models;
using System.Data;
using System.Data.Entity;

namespace Laptop.Controllers
{
    public class customertController : Controller
    {
        LaptopNTT db = new LaptopNTT();
        // GET: customert
        public ActionResult Index(int? page)
        {
            if (Session["admin"] == null)
            {
                return RedirectToAction("Index", "loginAdmin");
            }
            var cus = (from b in db.Customers
                       select b).ToList();
            ViewBag.cus = cus;
            return View(cus.ToPagedList(page ?? 1, 5));
        }/*
        [HttpPost]
        public ActionResult Index(int? page, FormCollection a)
        {
            string email = Request["key"];
            var cus = (from b in db.Customers
                      where b.Email.Contains(email)
                        select b).ToList();
            return View(cus.ToPagedList(page ?? 1, 5));
        }*/
        public ActionResult Edit(int id)
        {
            var cus = db.Customers.First(b => b.ID == id);
            return View(cus);
        }
        [HttpPost]
        public ActionResult Edit(int id, Customer cus)
        {
            ViewBag.date = DateTime.Now;
            /*var filename = Request["anh"];*/
            cus = db.Customers.Where(b => b.ID == id).SingleOrDefault();
            cus.Status = Request["sta"];
            cus.Note = Request["note"];
            cus.updated_at = ViewBag.date;
            db.Entry(cus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var cus = db.Customers.Where(b => b.ID == id).SingleOrDefault();
            db.Customers.Remove(cus);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}