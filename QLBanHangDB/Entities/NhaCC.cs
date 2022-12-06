using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class NhaCC
    {
        private string _MaNCC;
        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }

        private string _TenNCC;
        public string TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }

        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _SDT;
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        private string _Fax;
        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public NhaCC()
        {
        }
    }
}
