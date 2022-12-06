using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class HangSX
    {
        private string _MaHangSX;
        public string MaHangSX
        {
            get { return _MaHangSX; }
            set { _MaHangSX = value; }
        }

        private string _TenHangSX;
        public string TenHangSX
        {
            get { return _TenHangSX; }
            set { _TenHangSX = value; }
        }

        public HangSX()
        {
        }
        public HangSX(string maHangSX, string tenHangSX)
        {
            this._MaHangSX = maHangSX;
            this._TenHangSX = tenHangSX;
        }
    }
}
