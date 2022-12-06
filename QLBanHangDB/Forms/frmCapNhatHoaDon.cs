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
    public partial class frmCapNhatHoaDon : Form
    {
        frmMain frm;
        string _MaHD;
        int giaban, soluong, vat;
        HoaDonBanHang hd = new HoaDonBanHang();
        HoaDonBLL bllHoaDon = new HoaDonBLL();
        ChiTietHoaDonBLL bllCTHoaDon = new ChiTietHoaDonBLL();
        KhachHangBLL bllKhachHang = new KhachHangBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        HangHoaBLL bllHangHoa = new HangHoaBLL();
        ChiTietHoaDon ct = new ChiTietHoaDon();
        public frmCapNhatHoaDon(string MaHD)
        {
            InitializeComponent();
            this._MaHD = MaHD;
        }

        public void TongDonHang()
        {
            if (bllHoaDon.GetListHoaDonByID(_MaHD).Rows.Count > 0)
            {
                object sum = bllCTHoaDon.GetListChiTietHDByMaHD(_MaHD).Compute("Sum(ThanhTien)", string.Empty);
                txt_TongTienHD.Text = sum.ToString();
            }
        }
        private void GetDataHoaDon()
        {
            txt_GiaBan.Text = String.Format("{0:0,0}", int.Parse(txt_GiaBan.Text.Replace(",", "")));
            giaban = int.Parse(txt_GiaBan.Text.Replace(",", ""));
            int vat;
            int.TryParse(txt_VAT.Text, out vat);
            ct.VAT = vat;
            ct.MaHD = txt_MaHD.Text;
            ct.GiaBan = giaban;
            ct.MaHang = cmb_MaHang.SelectedValue.ToString();
            ct.SoLuong = int.Parse(txt_SoLuong.Text);
            int thanhtien = giaban * int.Parse(txt_SoLuong.Text) * (100 + vat) / 100;
            ct.ThanhTien = thanhtien;
        }
        private void frmCapNhatHoaDon_Load(object sender, EventArgs e)
        {
            cmb_MaHang.DataSource = bllHangHoa.GetListMatHang();
            cmb_MaHang.DisplayMember = "MaHang";
            cmb_MaHang.ValueMember = "MaHang";
            cmb_NhanVien.DataSource = bllNhanVien.GetListNhanVienNhapHang();
            cmb_NhanVien.DisplayMember = "TenNV";
            cmb_NhanVien.ValueMember = "MaNV";
            if (bllHoaDon.GetListHoaDonByID(_MaHD).Rows.Count > 0)
            {
                txt_MaHD.Text = bllHoaDon.GetListHoaDonByID(_MaHD).Rows[0]["MaHD"].ToString();
                txt_NgayBan.Text = bllHoaDon.GetListHoaDonByID(_MaHD).Rows[0]["NgayBan"].ToString();
                txt_NgayBan.Text = DateTime.Parse(txt_NgayBan.Text).ToShortDateString();
                cmb_NhanVien.Text = bllHoaDon.GetListHoaDonByID(_MaHD).Rows[0]["MaNV"].ToString();
                txt_MaKH.Text = bllHoaDon.GetListHoaDonByID(_MaHD).Rows[0]["MaKH"].ToString();
                dgv_HangBan.DataSource = bllCTHoaDon.GetListChiTietHDByMaHD(_MaHD);
                TongDonHang();
            }
            cmb_MaHang.Text = "";
            cmb_NhanVien.Text = "";
        }
        private void txt_MaKH_TextChanged(object sender, EventArgs e)
        {
            if (bllKhachHang.GetListKhachHangByID(txt_MaKH.Text).Rows.Count > 0)
            {
                txt_TenKH.Text = bllKhachHang.GetListKhachHangByID(txt_MaKH.Text).Rows[0]["TenKH"].ToString();
                txt_DiaChi.Text = bllKhachHang.GetListKhachHangByID(txt_MaKH.Text).Rows[0]["DiaChi"].ToString();
                txt_SDT.Text = bllKhachHang.GetListKhachHangByID(txt_MaKH.Text).Rows[0]["SDT"].ToString();
            }
            else
            {
                txt_TenKH.Text = "";
                txt_DiaChi.Text = "";
                txt_SDT.Text = "";
            }
        }
        private void dgv_Hangban_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cmb_MaHang.Text = dgv_HangBan.Rows[row].Cells["MaHang"].Value.ToString();
            txt_TenHang.Text = dgv_HangBan.Rows[row].Cells["TenHang"].Value.ToString();
            txt_DVT.Text = dgv_HangBan.Rows[row].Cells["DVT"].Value.ToString();
            txt_GiaBan.Text = dgv_HangBan.Rows[row].Cells["GiaBan"].Value.ToString();
            txt_SoLuong.Text = dgv_HangBan.Rows[row].Cells["SoLuong"].Value.ToString();
            txt_VAT.Text = dgv_HangBan.Rows[row].Cells["VAT"].Value.ToString();
            txt_ThanhTien.Text = dgv_HangBan.Rows[row].Cells["ThanhTien"].Value.ToString();
        }
        private void cmb_MaHang_TextChanged(object sender, EventArgs e)
        {
            if (cmb_MaHang.SelectedValue != null || cmb_MaHang.Text != "")
            {
                if (bllHangHoa.GetMatHangById(cmb_MaHang.Text).Rows.Count > 0)
                {
                    txt_TenHang.Text = bllHangHoa.GetMatHangById(cmb_MaHang.Text).Rows[0]["TenHang"].ToString();
                    txt_DVT.Text = bllHangHoa.GetMatHangById(cmb_MaHang.Text).Rows[0]["DVT"].ToString();
                }
            }
            else
            {
                txt_TenHang.Text = "";
                txt_DVT.Text = "";
            }
        }
        private void txt_GiaBan_Leave(object sender, EventArgs e)
        {

            try
            {
                txt_GiaBan.Text = string.Format("{0:0,0}", double.Parse(txt_GiaBan.Text.Replace(",", "")));
                giaban = int.Parse(txt_GiaBan.Text.Replace(",", ""));
            }
            catch
            {
                MessageBox.Show("Ban phai nhap vao mot so");
                txt_GiaBan.Text = "0";
                txt_GiaBan.Focus();
            }
        }

        private void txt_SoLuong_Leave(object sender, EventArgs e)
        {
            try
            {
                soluong = int.Parse(txt_SoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Ban phai nhap vao mot so");
                txt_SoLuong.Text = "0";
                txt_SoLuong.Focus();
            }
        }
        private void txt_VAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vat = int.Parse(txt_VAT.Text);
            }
            catch
            {
                MessageBox.Show("Ban phai nhap vao mot so");
                txt_VAT.Focus();
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cmb_MaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin mặt hàng!", "Thông báo");
                cmb_MaHang.Focus();
            }
            else
            {
                if (txt_GiaBan.Text == "0" || txt_GiaBan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập giá nhập!", "Thông báo");
                    txt_GiaBan.Focus();
                }
                else
                {
                    if (txt_SoLuong.Text == "0" || txt_SoLuong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo");
                        txt_SoLuong.Focus();
                    }
                    else
                    {
                        if (bllCTHoaDon.GetListChiTietHDByMaHDandMaHang(txt_MaHD.Text, cmb_MaHang.SelectedValue.ToString()).Rows.Count > 0)
                        {
                            if (MessageBox.Show("Mặt hàng " + cmb_MaHang.SelectedValue.ToString() +
                                " đã có trong đơn hàng.\n Bạn có muốn cập nhật lại không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                btn_Sua_Click(sender, e);
                            }
                        }
                        else
                        {
                            GetDataHoaDon();
                            bllCTHoaDon.Insert(ct);
                            bllHoaDon.UpdateNguoiLapHD(txt_MaHD.Text, cmb_NhanVien.SelectedValue.ToString());
                            dgv_HangBan.DataSource = bllCTHoaDon.GetListChiTietHDByMaHD(_MaHD);
                            TongDonHang();
                        }
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            GetDataHoaDon();
            bllCTHoaDon.Update(ct);
            bllHoaDon.UpdateNguoiLapHD(txt_MaHD.Text, cmb_NhanVien.SelectedValue.ToString());
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            dgv_HangBan.DataSource = bllCTHoaDon.GetListChiTietHDByMaHD(_MaHD);
            TongDonHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                GetDataHoaDon();
                bllCTHoaDon.Delete(ct);
                bllHoaDon.UpdateNguoiLapHD(txt_MaHD.Text, cmb_NhanVien.SelectedValue.ToString());
                dgv_HangBan.DataSource = bllCTHoaDon.GetListChiTietHDByMaHD(_MaHD);
                TongDonHang();
                btn_Clear_Click(sender, e);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_MaHang.Text = "";
            txt_TenHang.Text = "";
            txt_DVT.Text = "";
            txt_SoLuong.Text = "0";
            txt_GiaBan.Text = "0";
            txt_VAT.Text = "0";
            txt_ThanhTien.Text = "0";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật \n Phiếu nhập " + txt_MaHD.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bllHoaDon.Update(txt_MaHD.Text, cmb_NhanVien.SelectedValue.ToString(), txt_TongTienHD.Text);
                MessageBox.Show("Bạn đã cập nhật thành công!");
                frm.openChildForm(new frmTimKiemPN(frm));
            }
        }

        private void btn_XoaCTHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập " + txt_MaHD.Text + "?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bllHoaDon.Delete(txt_MaHD.Text);
                MessageBox.Show("Bạn đã xóa thành công!");
                frm.openChildForm(new frmTimKiemPN(frm));
            }
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            frm.activeForm.Close();
            frm.openChildForm(new frmTimKiemPN(frm));
        }
    }
}
