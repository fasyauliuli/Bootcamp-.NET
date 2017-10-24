using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoadRunnerTemplate.ViewModel.Pembelian;
using RoadRunnerTemplate.Provider;
using RoadRunnerTemplate.DataAccess;

namespace RoadRunnerTemplate.Controllers
{
    public class PembelianController : Controller
    {
        private readonly PembelianProvider pembelianProvider;

        public PembelianController(PembelianProvider pembelianProvider)
        {
            this.pembelianProvider = pembelianProvider;
        }

        public ActionResult Index()
        {
            var AllPembelians = pembelianProvider.GetListPembelianViewModel();
            return View(AllPembelians);
        }

        public ActionResult Detail(int ID)
        {
            var viewModel = pembelianProvider.GetPembelianDetailViewModel(ID);
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = pembelianProvider.GetPembelianCreateViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(PembelianCreateEditViewModel model)
        {
            try
            {
                pembelianProvider.AddPembelian(model);
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
            var viewModel = pembelianProvider.GetPembelianEditViewModel(id);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(PembelianCreateEditViewModel model)
        {
            try
            {
                pembelianProvider.EditPembelian(model);

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
                pembelianProvider.Delete(id);
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
