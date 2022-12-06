using QLBanHangDB.BusinessLayer;
using QLBanHangDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangDB.Forms
{
    public partial class frmTimKiemHD : Form
    {
        frmMain frm;
        public frmTimKiemHD(frmMain _frm)
        {
            InitializeComponent();
            this.frm = _frm;
        }

        HoaDonBanHang hd = new HoaDonBanHang();
        HoaDonBLL bllHoaDon = new HoaDonBLL();
        KhachHangBLL bllKhachHang = new KhachHangBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        ChiTietHoaDonBLL bllCTHoaDon = new ChiTietHoaDonBLL();
        string _MaHD;

        private void frmTimKiemHD_Load(object sender, EventArgs e)
        {
            rdb_Ngay.Select();
            cmb_MaHD.DataSource = bllHoaDon.GetListHoaDon();
            cmb_MaHD.DisplayMember = "MaHD";
            cmb_MaHD.ValueMember = "MaHD";
            cmb_MaHD.Text = "";
            cmb_KhachHang.DataSource = bllKhachHang.GetListKhachHang();
            cmb_KhachHang.DisplayMember = "TenKH";
            cmb_KhachHang.ValueMember = "MaKH";
            cmb_KhachHang.Text = "";
            cmb_MaNV.DataSource = bllNhanVien.GetListNhanVienBanHang();
            cmb_MaNV.DisplayMember = "TenNV";
            cmb_MaNV.ValueMember = "MaNV";
            cmb_MaNV.Text = "";
        }

        private void cmb_KhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_KhachHang.SelectedValue != null)
            {
                if (bllKhachHang.GetListKhachHangByID(cmb_KhachHang.SelectedValue.ToString()).Rows.Count > 0)
                {
                    txt_DiaChi.Text = bllKhachHang.GetListKhachHangByID(cmb_KhachHang.SelectedValue.ToString()).Rows[0]["DiaChi"].ToString();
                    txt_SDT.Text = bllKhachHang.GetListKhachHangByID(cmb_KhachHang.SelectedValue.ToString()).Rows[0]["SDT"].ToString();
                }
            }
        }
        public void STTDatagrid()
        {
            if (dgv_HoaDon.Rows.Count == 0)
            {
                _MaHD = "";
                dgv_ChiTietHD.DataSource = bllCTHoaDon.GetListChiTietHDByMaHD(_MaHD);

            }
            for (int i = 0; i < dgv_HoaDon.Rows.Count; i++)
                dgv_HoaDon.Rows[i].Cells["STT"].Value = (i + 1).ToString();
            for (int i = 0; i < dgv_ChiTietHD.Rows.Count; i++)
                dgv_ChiTietHD.Rows[i].Cells["STT1"].Value = (i + 1).ToString();
        }
        private void dgv_HoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            _MaHD = dgv_HoaDon.Rows[row].Cells["MaHD"].Value.ToString();
            dgv_ChiTietHD.DataSource = bllCTHoaDon.GetListChiTietHDByMaHD(_MaHD);
            for (int i = 0; i < dgv_ChiTietHD.Rows.Count; i++)
                dgv_ChiTietHD.Rows[i].Cells["STT1"].Value = (i + 1).ToString();
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (rdb_Ngay.Checked == true)
            {
                dgv_HoaDon.DataSource = bllHoaDon.GetListHoaDonByDate(dtp_DateFrom.Text, dtp_DateTo.Text);
            }
            if (rdb_MaHD.Checked == true)
            {
                if (cmb_MaHD.SelectedValue != null)
                {
                    dgv_HoaDon.DataSource = bllHoaDon.GetListHoaDonByID(cmb_MaHD.Text);
                }
            }
            if (rdb_KhachHang.Checked == true)
            {
                if (cmb_KhachHang.SelectedValue != null)
                {
                    dgv_HoaDon.DataSource = bllHoaDon.GetListHoaDonByMaKH(cmb_KhachHang.SelectedValue.ToString());
                }
            }
            if (rdb_NhanVien.Checked == true)
            {
                if (cmb_MaNV.SelectedValue != null)
                {
                    dgv_HoaDon.DataSource = bllHoaDon.GetListHoaDonByMaNV(cmb_MaNV.SelectedValue.ToString());
                }
            }
            STTDatagrid();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            frm.activeForm.Close();
            frm.openChildForm(new frmCapNhatHoaDon(_MaHD));
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            frm.activeForm.Close();
            frm.openChildForm(new frmHoaDon(frm));
        }














        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
