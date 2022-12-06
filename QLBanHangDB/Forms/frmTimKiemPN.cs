using Microsoft.Office.Interop.Excel;
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
    public partial class frmTimKiemPN : Form
    {
        frmMain frm;

        public frmTimKiemPN(frmMain _frm)
        {
            InitializeComponent();
            this.frm = _frm;
        }

        PhieuNhap pn = new PhieuNhap();
        PhieuNhapBLL bllPhieuNhap = new PhieuNhapBLL();
        NhaCCBLL bllNhaCC = new NhaCCBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        ChiTietPhieuNhapBLL bllCTPhieuNhap = new ChiTietPhieuNhapBLL();
        string _MaPN;

        private void frmTimKemPN_Load(object sender, EventArgs e)
        {
            rdb_Ngay.Select();
            cmb_MaPN.DataSource = bllPhieuNhap.GetListPhieuNhap();
            cmb_MaPN.DisplayMember = "MaPN";
            cmb_MaPN.ValueMember = "MaPN";
            cmb_MaPN.Text = "";
            cmb_NhaCC.DataSource = bllNhaCC.GetListNhaCC();
            cmb_NhaCC.DisplayMember = "TenNCC";
            cmb_NhaCC.ValueMember = "MaNCC";
            cmb_NhaCC.Text = "";
            cmb_MaNV.DataSource = bllNhanVien.GetListNhanVienNhapHang();
            cmb_MaNV.DisplayMember = "TenNV";
            cmb_MaNV.ValueMember = "MaNV";
            cmb_MaNV.Text = "";
        }

        private void cmb_NhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_NhaCC.SelectedValue != null)
            {
                if (bllNhaCC.GetNhaCCByID(cmb_NhaCC.SelectedValue.ToString()).Rows.Count > 0)
                {
                    txt_DiaChi.Text = bllNhaCC.GetNhaCCByID(cmb_NhaCC.SelectedValue.ToString()).Rows[0]["DiaChi"].ToString();
                    txt_SDT.Text = bllNhaCC.GetNhaCCByID(cmb_NhaCC.SelectedValue.ToString()).Rows[0]["SDT"].ToString();
                }
            }
        }

        public void STTDatagrid()
        {
            if (dgv_PhieuNhap.Rows.Count == 0)
            {
                _MaPN = "";
                dgv_ChiTietPN.DataSource = bllCTPhieuNhap.GetListChiTietPNByMaPN(_MaPN);

            }
            for (int i = 0; i < dgv_PhieuNhap.Rows.Count; i++)
                dgv_PhieuNhap.Rows[i].Cells["STT"].Value = (i + 1).ToString();
            for (int i = 0; i < dgv_ChiTietPN.Rows.Count; i++)
                dgv_ChiTietPN.Rows[i].Cells["STT1"].Value = (i + 1).ToString();
        }

        private void dgv_PhieuNhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            _MaPN = dgv_PhieuNhap.Rows[row].Cells["MaPN"].Value.ToString();
            dgv_ChiTietPN.DataSource = bllCTPhieuNhap.GetListChiTietPNByMaPN(_MaPN);
            for (int i = 0; i < dgv_ChiTietPN.Rows.Count; i++)
                dgv_ChiTietPN.Rows[i].Cells["STT1"].Value = (i + 1).ToString();
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if(rdb_Ngay.Checked == true)
            {
                dgv_PhieuNhap.DataSource = bllPhieuNhap.GetListPhieuNhapByDate(dtp_DateFrom.Text, dtp_DateTo.Text);
            }
            if(rdb_MaPN.Checked == true)
            {
                if(cmb_MaPN.SelectedValue != null)
                {
                    dgv_PhieuNhap.DataSource = bllPhieuNhap.GetListPhieuNhapByID(cmb_MaPN.Text);
                }
            }
            if(rdb_NhaCC.Checked == true)
            {
                if(cmb_NhaCC.SelectedValue != null)
                {
                    dgv_PhieuNhap.DataSource = bllPhieuNhap.GetListPhieuNhapByMaNCC(cmb_NhaCC.SelectedValue.ToString());
                }
            }
            if(rdb_NhanVien.Checked == true)
            {
                if(cmb_MaNV.SelectedValue != null)
                {
                    dgv_PhieuNhap.DataSource = bllPhieuNhap.GetListPhieuNhapByMaNV(cmb_MaNV.SelectedValue.ToString());
                }
            }
            STTDatagrid();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            frm.activeForm.Close();
            frm.openChildForm(new frmCapNhatPhieuNhap(_MaPN));
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            frm.activeForm.Close();
            frm.openChildForm(new frmPhieuNhap(frm));
        }

        private void dgv_ChiTietPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn_ViewPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
