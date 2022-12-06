using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class NganhHang
    {
        private string _MaNganhHang;
        public string MaNganhHang
        {
            get { return _MaNganhHang; }
            set { _MaNganhHang = value; }
        }

        private string _TenNganhHang;
        public string TenNganhHang
        {
            get { return _TenNganhHang; }
            set { _TenNganhHang = value; }
        }

        public NganhHang()
        {
        }

        public NganhHang(string maNganhHang, string tenNganhHang)
        {
            this._MaNganhHang = maNganhHang;
            this._TenNganhHang = tenNganhHang;
        }
    }
}
