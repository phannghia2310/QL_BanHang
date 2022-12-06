using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class ChucVu
    {
        private string _MaCV;

        public string MaCV
        {
            get { return _MaCV; }
            set { _MaCV = value; }
        }
        private string _TenCV;

        public string TenCV
        {
            get { return _TenCV; }
            set { _TenCV = value; }
        }

        public ChucVu()
        {
        }
        public ChucVu(string maCV, string tenCV)
        {
            this._MaCV = maCV;
            this._TenCV = tenCV;
        }
    }
}
