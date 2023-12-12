using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi2
{
    public class Departemen
    {
        protected string nama_dep;
        public string Nama_dep
        {
            get { return nama_dep; }
            set { nama_dep = value; }
        }
        public Departemen(string nama_dep)
        {
            this.nama_dep = nama_dep;
        }
        public virtual void set_nama(string text)
        {
            Nama_dep = this.nama_dep;
        }
    }
}
