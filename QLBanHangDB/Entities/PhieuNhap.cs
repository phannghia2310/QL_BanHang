using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class PhieuNhap
    {
        private string _MaPN;
        public string MaPN
        {
            get { return _MaPN; }
            set { _MaPN = value; }
        }

        private string _MaNCC;
        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }

        private string _MaNV;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private DateTime _NgayNhap = DateTime.Parse("01/01/1900");
        public DateTime NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }

        private int _TongTienNhap;
        public int TongTienNhap
        {
            get { return _TongTienNhap; }
            set { _TongTienNhap = value; }
        }

        private List<ChiTietPhieuNhap> _ListCTPhieuNhap;
        public List<ChiTietPhieuNhap> ListCTPhieuNhap
        {
            get { return _ListCTPhieuNhap; }
            set { _ListCTPhieuNhap = value; }
        }

        public PhieuNhap()
        {
        }
    }
}
