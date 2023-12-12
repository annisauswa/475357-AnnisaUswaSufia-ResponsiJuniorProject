using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi2
{
    internal class DepLower:Departemen
    {
        public DepLower(string nama_dep) : base(nama_dep)
        {
            this.nama_dep = nama_dep;
        }
        public override void set_nama(string text)
        {
            Nama_dep = this.nama_dep+ " " + text;
        }
    }
}
