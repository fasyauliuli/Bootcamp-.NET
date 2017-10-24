using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoadRunnerTemplate.DataAccess;
using RoadRunnerTemplate.Provider;
using RoadRunnerTemplate.ViewModel.Lokasi;

namespace RoadRunnerTemplate.Controllers
{
    public class LokasiController : Controller
    {
        private readonly LokasiProvider lokasiProvider;

        public LokasiController(LokasiProvider lokasiProvider)
        {
            this.lokasiProvider = lokasiProvider;
        }

        public ActionResult Index()
        {
            var viewModel = new LokasiViewModel();

            var AllLokasis = lokasiProvider.GetListLokasiViewModel();
            return View(AllLokasis);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = lokasiProvider.GetLokasiCreateViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(LokasiCreateEditViewModel model)
        {
            try
            {
                lokasiProvider.AddLokasi(model);
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
            var viewModel = lokasiProvider.GetLokasiEditViewModel(id);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(LokasiCreateEditViewModel model)
        {
            try
            {
                lokasiProvider.EditLokasi(model);

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
                lokasiProvider.Delete(id);
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
