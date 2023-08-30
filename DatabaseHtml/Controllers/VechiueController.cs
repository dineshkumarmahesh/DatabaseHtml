using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using DataAccessLibrary.Repository;
using DataAccessLibrary.Model;
using Dapper;
using System.Data.SqlClient;
using DatabaseHtml.Models;

namespace DatabaseHtml.Controllers
{
    public class VechiueController : Controller
    {
        
        VechiueRepository obj;
        dropdownRepository obj1;


        public VechiueController()
        {
            obj = new VechiueRepository();
            obj1 = new  dropdownRepository();

        }
        public ActionResult List()
        {
            return View("List", obj.SelectSP()); 
        }

        // GET: VechiueController/Details/5
        public ActionResult Details(int id)
        {
            var result = obj.SelectSP(id);
            return View("Details", result);
        }

        // GET: VechiueController/Create
        public ActionResult Create()

        {
           var model = new VechiueModel();
            model.typeValues = obj1.SelectSP();
            return View("Create", model);
        }

        // POST: VechiueController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VechiueModel collection)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    obj.InsertSP(collection);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    collection.typeValues = obj1.SelectSP();
                    return View("create", collection);
                }
                   
           }
            catch(Exception ex)
            {
                
                return View("Error", new ErrorViewModel { CustomMessage = "Error in Product Edit feature", ActualMessage = ex.Message });
            }
        }

        // GET: VechiueController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = obj.SelectSP(id);
            result.typeValues = obj1.SelectSP();
            return View("Edit",result);
        }

        // POST: VechiueController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VechiueModel u)
        {
            try
            {
                u.id= id;
                obj.updateSP(u);
                return RedirectToAction(nameof(List));
            }
            catch(Exception ex)
            {
                return View("Error", new ErrorViewModel { CustomMessage = "Error in Product Edit feature", ActualMessage = ex.Message });
            }
        }

        // GET: VechiueController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = obj.SelectSP(id);
            return View("Delete",result);
        }

        // POST: VechiueController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int id)
        {
            try
            {
                obj.deleteSP(id);
                return RedirectToAction(nameof(List));
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { CustomMessage = "Error in Product Edit feature", ActualMessage = ex.Message });
            }
        }
    }
}
