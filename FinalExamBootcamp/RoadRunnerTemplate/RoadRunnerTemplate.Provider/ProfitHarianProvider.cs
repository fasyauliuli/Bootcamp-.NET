using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRunnerTemplate.DataAccess;
using RoadRunnerTemplate.ViewModel.ProfitHarian;

namespace RoadRunnerTemplate.Provider
{
    public class ProfitHarianProvider
    {
        private readonly EntitiesModel context;
        public ProfitHarianProvider(EntitiesModel context)
        {
            this.context = context;
        }

        public IQueryable<Pembelian> GetAllPembelian()
        {
            return context.Pembelians;
        }

        public Pembelian GetPembelian(int id)
        {
            return context.Pembelians.SingleOrDefault(pembelian => pembelian.ID == id);
        }

        public List<ProfitHarianViewModel> GetListProfitHarianViewModel()
        {
            var allProfit = GetAllPembelian();
            var query = from profit in allProfit
                        select new ProfitHarianViewModel()
                        {
                            ID = profit.ID,
                            Tanggal = profit.TanggalPembelian,
                            Profit = profit.DetilPembelians.Sum(x=>(x.Barang.HargaJual - x.Barang.HargaBeli))
                        };
            return query.ToList();
        }
    }
}
