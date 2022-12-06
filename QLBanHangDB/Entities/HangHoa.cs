using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class HangHoa
    {
        private string _MaHang;
        public string MaHang
        {
            get { return _MaHang; }
            set { _MaHang = value; }
        }

        private string _MaNhomHang;
        public string MaNhomHang
        {
            get { return _MaNhomHang; }
            set { _MaNhomHang = value; }
        }

        private string _MaHangSX;
        public string MaHangSX
        {
            get { return _MaHangSX; }
            set { _MaHangSX = value; }
        }

        private string _TenHang;
        public string TenHang
        {
            get { return _TenHang; }
            set { _TenHang = value; }
        }

        private string _DVT;
        public string DVT
        {
            get { return _DVT; }
            set { _DVT = value; }
        }

        private string _DonGia;
        public string DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

        private string _VAT;
        public string VAT
        {
            get { return _VAT; }
            set { _VAT = value; }
        }

        public HangHoa()
        {
        }
    }
}
