using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readLog
{
    public class Comment
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public string YorumcuAdSoyad { get; set; }
        public string YorumMetni { get; set;}

        public DateTime YorumTarihi { get; set; }
    }
}
