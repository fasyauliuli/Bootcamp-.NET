using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRunnerTemplate.DataAccess;
using RoadRunnerTemplate.ViewModel.Lokasi;

namespace RoadRunnerTemplate.Provider
{
    public class LokasiProvider
    {
        private readonly EntitiesModel context;
        public LokasiProvider(EntitiesModel context)
        {
            this.context = context;
        }

        public IQueryable<Lokasi> GetAllLokasi()
        {
            return context.Lokasis;
        }

        public Lokasi GetLokasi(int id)
        {
            return context.Lokasis.SingleOrDefault(lokasi => lokasi.ID == id);
        }

        public List<LokasiViewModel> GetListLokasiViewModel()
        {
            var allLokasis = GetAllLokasi();
            var query = from lokasi in allLokasis
                        select new LokasiViewModel()
                        {
                            ID = lokasi.ID,
                            NomorRak = lokasi.NomorRak,
                            NomorBay = lokasi.NomorBay
                        };
            return query.ToList();
        }

        public LokasiViewModel GetLokasiViewModel(int ID)
        {
            var selectedLokasi = GetLokasi(ID);

            var viewModel = new LokasiViewModel()
            {
                ID = selectedLokasi.ID,
                NomorRak = selectedLokasi.NomorRak,
                NomorBay = selectedLokasi.NomorBay
            };
            return viewModel;
        }

        public LokasiCreateEditViewModel GetLokasiCreateViewModel()
        {
            var viewModel = new LokasiCreateEditViewModel();
            return viewModel;
        }

        public void AddLokasi(LokasiCreateEditViewModel model)
        {
            var lokasi = new Lokasi()
            {
                NomorRak = model.NomorRak,
                NomorBay = model.NomorBay
            };
            context.Add(lokasi);
            context.SaveChanges();
        }

        public LokasiCreateEditViewModel GetLokasiEditViewModel(int id)
        {
            var lokasi = GetLokasi(id);
            var viewModel = new LokasiCreateEditViewModel()
            {
                ID = lokasi.ID,
                NomorRak = lokasi.NomorRak,
                NomorBay = lokasi.NomorBay
            };
            return viewModel;
        }

        public void EditLokasi(LokasiCreateEditViewModel model)
        {
            var lokasi = GetLokasi(model.ID);
            lokasi.NomorRak = model.NomorRak;
            lokasi.NomorBay = model.NomorBay;

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var lokasi = GetLokasi(id);
            if (lokasi != null)
            {
                context.Delete(lokasi);
                context.SaveChanges();
            }
        }

    }
}
