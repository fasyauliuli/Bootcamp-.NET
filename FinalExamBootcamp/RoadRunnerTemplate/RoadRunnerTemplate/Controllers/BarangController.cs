using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoadRunnerTemplate.DataAccess;
using RoadRunnerTemplate.Provider;
using RoadRunnerTemplate.ViewModel.Barang;

namespace RoadRunnerTemplate.Controllers
{
    public class BarangController : Controller
    {
        private readonly BarangProvider barangProvider;

        public BarangController(BarangProvider barangProvider)
        {
            this.barangProvider = barangProvider;
        }

        public ActionResult Index(string nama=null)
        {
            var viewModel = new BarangViewModel();
            var AllBarangs = barangProvider.GetListBarangViewModel(nama);

            return View(AllBarangs);
        }

        [HttpPost]
        public ActionResult Filter(FormCollection values)
        {
            string nama = values["Kategori"];
            return RedirectToAction("Index", new { nama = nama });
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = barangProvider.GetBarangCreateViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(BarangCreateEditViewModel model)
        {
            try
            {
                barangProvider.AddBarang(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
                return RedirectToAction("Create");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var viewModel = barangProvider.GetBarangEditViewModel(id);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(BarangCreateEditViewModel model)
        {
            try
            {
                barangProvider.EditBarang(model);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Edit");
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var result = "";
            try
            {
                barangProvider.Delete(id);
                result = "Success";
            }
            catch (Exception ex)
            {
                result = ex.GetBaseException().Message;
            }
            return Json(result);
        }

    }
}
