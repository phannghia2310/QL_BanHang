using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class NhanVien
    {
        private string _MaNV;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _MaCV;
        public string MaCV
        {
            get { return _MaCV; }
            set { _MaCV = value; }
        }

        private string _MaQL;
        public string MaQL
        {
            get { return _MaQL; }
            set { _MaQL = value; }
        }

        private string _TenNV;
        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }

        private string _GioiTinh;
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        private DateTime _NgaySinh = DateTime.Parse("01/01/1900");
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
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

        public NhanVien()
        {
        }

    }
}
