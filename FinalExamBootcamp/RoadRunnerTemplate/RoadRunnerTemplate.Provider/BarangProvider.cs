using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRunnerTemplate.DataAccess;
using RoadRunnerTemplate.ViewModel.Barang;

namespace RoadRunnerTemplate.Provider
{
    public class BarangProvider
    {
        private readonly EntitiesModel context;
        public BarangProvider(EntitiesModel context)
        {
            this.context = context;
        }

        public IQueryable<Barang> GetAllBarang()
        {
            return context.Barangs;
        }

        public Barang GetBarang(int id)
        {
            return context.Barangs.SingleOrDefault(barang => barang.ID == id);
        }

        public List<BarangViewModel> GetListBarangViewModel(string nama)
        {
            var allBarangs = GetAllBarang();
            var query = from barang in allBarangs
                        select new BarangViewModel()
                        {
                            ID = barang.ID,
                            Nama = barang.Nama,
                            Lokasi = "Rak " + barang.Lokasi.NomorRak + ", Bay " + barang.Lokasi.NomorBay,
                            HargaBeli = barang.HargaBeli,
                            HargaJual = barang.HargaJual,
                            Kategori = barang.Kategori.Nama
                        };
            if (!string.IsNullOrEmpty(nama))
            {
                query = query.Where(f => f.Kategori.Contains(nama));
            }

            return query.ToList();
        }

        public BarangViewModel GetBarangViewModel(int ID)
        {
            var selectedBarang = GetBarang(ID);

            var viewModel = new BarangViewModel()
            {
                ID = selectedBarang.ID,
                Nama = selectedBarang.Nama,
                Lokasi = "Rak " + selectedBarang.Lokasi.NomorRak + ", Bay " + selectedBarang.Lokasi.NomorBay,
                HargaBeli = selectedBarang.HargaBeli,
                HargaJual = selectedBarang.HargaJual
            };
            return viewModel;
        }

        public BarangCreateEditViewModel GetBarangCreateViewModel()
        {
            var viewModel = new BarangCreateEditViewModel();

            viewModel.KategoriLookup = context.Kategoris;
            viewModel.LokasiLookup = context.Lokasis;

            return viewModel;
        }

        public void AddBarang(BarangCreateEditViewModel model)
        {
            var barang = new Barang()
            {
                Nama = model.Nama,
                HargaBeli = model.HargaBeli,
                HargaJual = model.HargaJual,
                LokasiID = model.LokasiID,
                KategoriID = model.KategoriID
            };
            context.Add(barang);
            context.SaveChanges();
        }

        public BarangCreateEditViewModel GetBarangEditViewModel(int id)
        {
            var barang = GetBarang(id);
            var viewModel = new BarangCreateEditViewModel()
            {
                ID = barang.ID,
                Nama = barang.Nama,
                HargaBeli = barang.HargaBeli,
                HargaJual = barang.HargaJual,
                KategoriID = barang.KategoriID,
                LokasiID = barang.LokasiID,

                KategoriLookup = context.Kategoris,
                LokasiLookup = context.Lokasis
            };
            return viewModel;
        }

        public void EditBarang(BarangCreateEditViewModel model)
        {
            var barang = GetBarang(model.ID);
            barang.Nama = model.Nama;
            barang.HargaBeli = model.HargaBeli;
            barang.HargaJual = model.HargaJual;
            barang.KategoriID = model.KategoriID;
            barang.LokasiID = model.LokasiID;

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var barang = GetBarang(id);
            if (barang != null)
            {
                context.Delete(barang);
                context.SaveChanges();
            }
        }
    }
}
