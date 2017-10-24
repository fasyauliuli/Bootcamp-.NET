using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRunnerTemplate.DataAccess;

namespace RoadRunnerTemplate.ViewModel.Pembelian
{
    public class PembelianDetailViewModel
    {
        public int ID { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Total { get; set; }

        public IEnumerable<JoinBarangLokasiViewModel> BarangLookup { get; set; }
    }
}
