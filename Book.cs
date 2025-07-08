using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readLog
{
    public class Book
    {
        public int Id { get; set; }

        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
        public int SayfaSayisi { get; set; }
        public bool OkunduMu { get; set; }
        public bool FavoriMi { get; set; }

        public DateTime? OkumaBaslangicTarihi { get; set; }
        public DateTime? OkumaBitisTarihi { get; set; }

    }

}
