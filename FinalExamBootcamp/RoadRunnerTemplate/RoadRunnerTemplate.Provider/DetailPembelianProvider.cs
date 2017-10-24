using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRunnerTemplate.DataAccess;
using RoadRunnerTemplate.ViewModel.Pembelian;

namespace RoadRunnerTemplate.Provider
{
    public class DetailPembelianProvider
    {
        private readonly EntitiesModel context;
        public DetailPembelianProvider(EntitiesModel context)
        {
            this.context = context;
        }

        public IQueryable<Barang> GetAllBarang()
        {
            return context.Barangs;
        }

        public IQueryable<Pembelian> GetAllPembelians()
        {
            return context.Pembelians;
        }

        public IQueryable<DetilPembelian> GetAllDetilPembelian()
        {
            return context.DetilPembelians;
        }

        public DetilPembelian GetDetil(int id)
        {
            return context.DetilPembelians.SingleOrDefault(detil => detil.ID == id);
        }

        public Barang GetBarang(int id)
        {
            return context.Barangs.SingleOrDefault(barang => barang.ID == id);
        }

        public Pembelian GetPembelian(int id)
        {
            return context.Pembelians.SingleOrDefault(pembelian => pembelian.ID == id);
        }

        public PembelianDetailCreateEditViewModel GetPembelianDetailCreateViewModel()
        {
            var viewModel = new PembelianDetailCreateEditViewModel();

            viewModel.BarangLookup = context.Barangs;

            return viewModel;
        }

        public void AddDetailPembelian(PembelianDetailCreateEditViewModel model)
        {
            var pembelian = new DetilPembelian()
            {
                PembelianID = model.PembelianID,
                BarangID = model.BarangID
            };
            context.Add(pembelian);
            context.SaveChanges();
        }

        public PembelianDetailCreateEditViewModel GetPembelianDetailEditViewModel(int id)
        {
            var barang = GetBarang(id);
            var pembelian = GetPembelian(id);
            var detil = GetDetil(id);
            var viewModel = new PembelianDetailCreateEditViewModel()
            {
                ID = detil.ID,
                PembelianID = pembelian.ID,
                BarangID = barang.ID,

                BarangLookup = context.Barangs
            };
            return viewModel;
        }

        public void EditDetailPembelian(PembelianDetailCreateEditViewModel model)
        {
            var barang = GetBarang(model.ID);
            var pembelian = GetPembelian(model.ID);
            
            barang.ID = model.BarangID;
            pembelian.ID = model.PembelianID;

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pembelian = GetBarang(id);
            if (pembelian != null)
            {
                context.Delete(pembelian);
                context.SaveChanges();
            }
        }
    }
}
