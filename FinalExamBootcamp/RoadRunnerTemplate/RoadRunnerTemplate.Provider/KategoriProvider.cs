using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRunnerTemplate.DataAccess;
using RoadRunnerTemplate.ViewModel.Kategori;

namespace RoadRunnerTemplate.Provider
{
    public class KategoriProvider
    {
        private readonly EntitiesModel context;
        public KategoriProvider(EntitiesModel context)
        {
            this.context = context;
        }

        public IQueryable<Kategori> GetAllKategori()
        {
            return context.Kategoris;
        }

        public Kategori GetKategori(int id)
        {
            return context.Kategoris.SingleOrDefault(kategori => kategori.ID == id);
        }

        public List<KategoriViewModel> GetListKategoriViewModel()
        {
            var allKategoris = GetAllKategori();
            var query = from kategori in allKategoris
                        select new KategoriViewModel()
                        {
                            ID = kategori.ID,
                            Nama = kategori.Nama
                        };
            return query.ToList();
        }

        public KategoriViewModel GetKategoriViewModel(int ID)
        {
            var selectedKategori = GetKategori(ID);

            var viewModel = new KategoriViewModel()
            {
                ID = selectedKategori.ID,
                Nama= selectedKategori.Nama
            };
            return viewModel;
        }

        public KategoriCreateEditViewModel GetKategoriCreateViewModel()
        {
            var viewModel = new KategoriCreateEditViewModel();
            return viewModel;
        }

        public void AddKategori(KategoriCreateEditViewModel model)
        {
            var kategori = new Kategori()
            {
                Nama = model.Nama
            };
            context.Add(kategori);
            context.SaveChanges();
        }

        public KategoriCreateEditViewModel GetKategoriEditViewModel(int id)
        {
            var kategori = GetKategori(id);
            var viewModel = new KategoriCreateEditViewModel()
            {
                ID = kategori.ID,
                Nama = kategori.Nama
            };
            return viewModel;
        }

        public void EditKategori(KategoriCreateEditViewModel model)
        {
            var kategori = GetKategori(model.ID);
            kategori.Nama = model.Nama;

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var kategori = GetKategori(id);
            if (kategori != null)
            {
                context.Delete(kategori);
                context.SaveChanges();
            }
        }
    }
}
