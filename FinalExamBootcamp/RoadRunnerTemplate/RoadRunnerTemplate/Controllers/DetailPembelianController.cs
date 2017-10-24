using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoadRunnerTemplate.DataAccess;
using RoadRunnerTemplate.Provider;
using RoadRunnerTemplate.ViewModel.Pembelian;

namespace RoadRunnerTemplate.Controllers
{
    public class DetailPembelianController : Controller
    {
        private readonly DetailPembelianProvider detailPembelianProvider;

        public DetailPembelianController(DetailPembelianProvider detailPembelianProvider)
        {
            this.detailPembelianProvider = detailPembelianProvider;
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = detailPembelianProvider.GetPembelianDetailCreateViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(PembelianDetailCreateEditViewModel model)
        {
            try
            {
                detailPembelianProvider.AddDetailPembelian(model);
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
            var viewModel = detailPembelianProvider.GetPembelianDetailEditViewModel(id);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(PembelianDetailCreateEditViewModel model)
        {
            try
            {
                detailPembelianProvider.EditDetailPembelian(model);

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
                detailPembelianProvider.Delete(id);
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
