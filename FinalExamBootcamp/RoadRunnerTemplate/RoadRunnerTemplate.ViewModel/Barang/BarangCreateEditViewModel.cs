using RoadRunnerTemplate.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoadRunnerTemplate.ViewModel.Barang
{
    public class BarangCreateEditViewModel
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public string Lokasi { get; set; }
        public decimal HargaBeli { get; set; }
        public decimal HargaJual { get; set; }
        public int KategoriID { get; set; }
        public int LokasiID { get; set; }

        public IEnumerable<RoadRunnerTemplate.DataAccess.Kategori> KategoriLookup { get; set; }
        public IEnumerable<RoadRunnerTemplate.DataAccess.Lokasi> LokasiLookup { get; set; }
    }
}
