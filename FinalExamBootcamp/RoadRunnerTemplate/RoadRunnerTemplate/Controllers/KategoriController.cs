using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoadRunnerTemplate.DataAccess;
using RoadRunnerTemplate.Provider;
using RoadRunnerTemplate.ViewModel.Kategori;

namespace RoadRunnerTemplate.Controllers
{
    public class KategoriController : Controller
    {
        private readonly KategoriProvider kategoriProvider;

        public KategoriController(KategoriProvider kategoriProvider)
        {
            this.kategoriProvider = kategoriProvider;
        }

        public ActionResult Index()
        {
            var viewModel = new KategoriViewModel();

            var AllKategoris = kategoriProvider.GetListKategoriViewModel();
            return View(AllKategoris);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = kategoriProvider.GetKategoriCreateViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(KategoriCreateEditViewModel model)
        {
            try
            {
                kategoriProvider.AddKategori(model);
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
            var viewModel = kategoriProvider.GetKategoriEditViewModel(id);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(KategoriCreateEditViewModel model)
        {
            try
            {
                kategoriProvider.EditKategori(model);

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
                kategoriProvider.Delete(id);
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
