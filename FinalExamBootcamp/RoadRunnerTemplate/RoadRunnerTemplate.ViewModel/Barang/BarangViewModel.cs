using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRunnerTemplate.ViewModel.Barang
{
    public class BarangViewModel
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public string Lokasi { get; set; }
        public decimal HargaBeli { get; set; }
        public decimal HargaJual { get; set; }
        public string Kategori { get; set; }
    }
}
