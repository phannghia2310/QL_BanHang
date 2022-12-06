using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class NhomHang
    {
        private string _MaNhomHang;
        public string MaNhomHang
        {
            get { return _MaNhomHang; }
            set { _MaNhomHang = value; }
        }

        private string _MaNganhHang;
        public string MaNganhHang
        {
            get { return _MaNganhHang; }
            set { _MaNganhHang = value; }
        }

        private string _TenNhomHang;
        public string TenNhomHang
        {
            get { return _TenNhomHang; }
            set { _TenNhomHang = value; }
        }

        public NhomHang()
        {
        }
        public NhomHang(string maNhomHang, string maNganhHang, string tenNhomHang)
        {
            this._MaNhomHang = maNhomHang;
            this._MaNganhHang = maNganhHang;
            this._TenNhomHang = tenNhomHang;
        }
    }
}
