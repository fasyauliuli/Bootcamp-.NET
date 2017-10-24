using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRunnerTemplate.DataAccess;
using RoadRunnerTemplate.ViewModel.Pembelian;

namespace RoadRunnerTemplate.Provider
{
    public class PembelianProvider
    {
        private readonly EntitiesModel context;
        public PembelianProvider(EntitiesModel context)
        {
            this.context = context;
        }

        public IQueryable<DetilPembelian> GetAllDetilPembelian()
        {
            return context.DetilPembelians;
        }

        public IQueryable<Pembelian> GetAllPembelian()
        {
            return context.Pembelians;
        }

        public IQueryable<Barang> GetAllBarang()
        {
            return context.Barangs;
        }

        public Pembelian GetPembelian(int id)
        {
            return context.Pembelians.SingleOrDefault(pembelian => pembelian.ID == id);
        }

        public List<PembelianViewModel> GetListPembelianViewModel()
        {
            var allPembelians = GetAllPembelian();
            var query = from pembelian in allPembelians
                        select new PembelianViewModel()
                        {
                            ID = pembelian.ID,
                            Tanggal = pembelian.TanggalPembelian,
                            Total = pembelian.DetilPembelians.Sum(x=>x.Barang.HargaJual)
                        };
            return query.ToList();
        }

        public List<JoinBarangLokasiViewModel> GetListJoinDetailBarangLokasi(DateTime tanggal)
        {
            var allBarang = GetAllBarang();
            var allPembelian = GetAllPembelian();
            var allDetilPembelian = GetAllDetilPembelian();

            var query = from pembelian in allPembelian
                        where pembelian.TanggalPembelian == tanggal
                        join detail in allDetilPembelian on pembelian.ID equals detail.PembelianID
                        join barang in allBarang on detail.BarangID equals barang.ID

                        select new JoinBarangLokasiViewModel
                        {
                            ID = barang.ID,
                            Nama = barang.Nama,
                            NomorRak = barang.Lokasi.NomorRak,
                            NomorBay = barang.Lokasi.NomorBay,
                            HargaJual = barang.HargaJual
                        };
            return query.ToList();
        }

        public PembelianViewModel GetPembelianViewModel(int ID)
        {
            var selectedPembelian = GetPembelian(ID);

            var viewModel = new PembelianViewModel()
            {
                ID = selectedPembelian.ID,
                Tanggal = selectedPembelian.TanggalPembelian,
                Total = selectedPembelian.DetilPembelians.Sum( x => x.Barang.HargaJual )
            };
            return viewModel;
        }

        public PembelianDetailViewModel GetPembelianDetailViewModel(int ID)
        {
            var selectePembelian = GetPembelian(ID);
            var allBarang = GetAllBarang();
            var join = GetListJoinDetailBarangLokasi(selectePembelian.TanggalPembelian);
            
            var viewModel = new PembelianDetailViewModel()
            {
                
                ID = selectePembelian.ID,
                Tanggal = selectePembelian.TanggalPembelian,
                Total = selectePembelian.DetilPembelians.Sum(x => x.Barang.HargaJual),
                BarangLookup = join.Select(y => new JoinBarangLokasiViewModel()
                {
                    ID = y.ID,
                    Nama = y.Nama,
                    NomorRak = y.NomorRak,
                    NomorBay = y.NomorBay,
                    HargaJual = y.HargaJual
                }),
            };
            return viewModel;
        }

        public PembelianCreateEditViewModel GetPembelianCreateViewModel()
        {
            var viewModel = new PembelianCreateEditViewModel();

            viewModel.Tanggal = DateTime.Today;

            return viewModel;
        }

        public void AddPembelian(PembelianCreateEditViewModel model)
        {
            var pembelian = new Pembelian()
            {
                ID = model.ID,
                TanggalPembelian = model.Tanggal
            };
            context.Add(pembelian);
            context.SaveChanges();
        }

        public PembelianCreateEditViewModel GetPembelianEditViewModel(int id)
        {
            var pembelian = GetPembelian(id);
            var viewModel = new PembelianCreateEditViewModel()
            {
                ID = pembelian.ID,
                Tanggal = pembelian.TanggalPembelian
            };
            return viewModel;
        }

        public void EditPembelian(PembelianCreateEditViewModel model)
        {
            var pembelian = GetPembelian(model.ID);
            pembelian.TanggalPembelian = model.Tanggal;

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pembelian = GetPembelian(id);
            if (pembelian != null)
            {
                context.Delete(pembelian);
                context.SaveChanges();
            }
        }
    }
}
