using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRunnerTemplate.DataAccess;

namespace RoadRunnerTemplate.ViewModel.Pembelian
{
    public class PembelianDetailCreateEditViewModel
    {
        public int ID { get; set; }
        public string Barang { get; set; }
        public int BarangID { get; set; }
        public int PembelianID { get; set; }

        public IEnumerable<RoadRunnerTemplate.DataAccess.Barang> BarangLookup;
    }
}
