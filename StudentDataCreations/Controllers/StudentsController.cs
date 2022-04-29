using Microsoft.AspNetCore.Mvc;
using StudentDataCreation.Core.IRepository;
using StudentDataCreation.Core.IServices;
using StudentDataCreation.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDataCreations.Controllers
{
    public class StudentsController : Controller
    {
        #region Decleartion
        private readonly IServices _InService;
        #endregion
        #region Con_
        public StudentsController(IServices InsertService)
        {
            this._InService = InsertService;
        }
        #endregion
        public IActionResult Index()
        {
            return View();
        }
        //Insert
        [HttpPost]
        public IActionResult IndexDetails(StudentDataModel empDetails)
        {
            _InService.InsertEmpDetails(empDetails);
            return RedirectToAction("ListView");

        }
        public IActionResult ListView()
        {
            var listStudentsData = _InService.listStudents();
            return View(listStudentsData);

        }

        /*        //List
                public IActionResult ListView()
                {
                    var listStudentsData = _InService.listStudents();
                    return View(listStudentsData);

                }
                public IActionResult Delete(int id)
                {
                    if (id < 0)
                    {
                        return RedirectToAction("ListView");
                    }
                    var dataDelete = _InService.DeleteOrEdit(id);
                    return View(dataDelete);
                }
                [HttpPost]
                public IActionResult Delete(int? id)
                {
                    if (ModelState.IsValid)
                    {
                        _InService.DeleteStudents(id);
                        return RedirectToAction("ListView");
                    }
                    return RedirectToAction("Delete");
                }
                //Retrieve
                public IActionResult Edit(int id)
                {
                    if (id < 0)
                    {
                        return RedirectToAction("ListView");
                    }
                    var dataDelete = _InService.DeleteOrEdit(id);
                    return View(dataDelete);
                }

                //Edit
                [HttpPost]
                public IActionResult Edit(StudentDataModel model)
                {
                    if (ModelState.IsValid)
                    {
                        _InService.saveOrEditStudents(model);
                        return RedirectToAction("ListView");
                    }
                    return View(model);
                }*/
    }
}

  