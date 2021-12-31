using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilbasiCekilisi
{
    public class Kisi
    {
        public Kisi()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
