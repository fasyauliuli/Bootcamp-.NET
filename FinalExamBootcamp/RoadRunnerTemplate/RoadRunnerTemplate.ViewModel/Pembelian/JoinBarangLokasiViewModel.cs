using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRunnerTemplate.ViewModel.Pembelian
{
    public class JoinBarangLokasiViewModel
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public string NomorRak { get; set; }
        public string NomorBay { get; set; }
        public decimal HargaJual { get; set; }
    }
}
