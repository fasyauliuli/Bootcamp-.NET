using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoadRunnerTemplate.ViewModel.ProfitHarian;
using RoadRunnerTemplate.Provider;
using RoadRunnerTemplate.DataAccess;

namespace RoadRunnerTemplate.Controllers
{
    public class ProfitHarianController : Controller
    {
        private readonly ProfitHarianProvider profitHarianProvider;

        public ProfitHarianController(ProfitHarianProvider profitHarianProvider)
        {
            this.profitHarianProvider = profitHarianProvider;
        }

        public ActionResult Index()
        {
            var AllProfit = profitHarianProvider.GetListProfitHarianViewModel();
            return View(AllProfit);
        }
    }
}
