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
    public partial class frmCapNhatPhieuNhap : Form
    {
        frmMain frm;
        string _MaPN;
        int gianhap, soluong, chietkhau;
        PhieuNhap pn = new PhieuNhap();
        PhieuNhapBLL bllPhieuNhap = new PhieuNhapBLL();
        ChiTietPhieuNhapBLL bllCTPhieuNhap = new ChiTietPhieuNhapBLL();
        NhaCCBLL bllNhaCC = new NhaCCBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        HangHoaBLL bllHangHoa = new HangHoaBLL();
        ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
        public frmCapNhatPhieuNhap(string MaPN)
        {
            InitializeComponent();
            this._MaPN = MaPN;
        }

        public void TongDonHang()
        {
            if(bllPhieuNhap.GetListPhieuNhapByID(_MaPN).Rows.Count > 0)
            {
                object sum = bllCTPhieuNhap.GetListChiTietPNByMaPN(_MaPN).Compute("Sum(ThanhTien)", string.Empty);
                txt_TongTienNhap.Text = sum.ToString();
            }
        }

        private void GetDataPhieuNhap()
        {
            txt_GiaNhap.Text = String.Format("{0:0,0}", int.Parse(txt_GiaNhap.Text.Replace(",", "")));
            gianhap = int.Parse(txt_GiaNhap.Text.Replace(",", ""));
            int chietkhau;
            int.TryParse(txt_ChietKhau.Text, out chietkhau);
            ct.ChietKhau = chietkhau;
            ct.MaPN = txt_MaPN.Text;
            ct.GiaNhap = gianhap;
            ct.MaHang = cmb_MaHang.SelectedValue.ToString();
            ct.SoLuong = int.Parse(txt_SoLuong.Text);
            int thanhtien = gianhap * int.Parse(txt_SoLuong.Text) * (100 - chietkhau) / 100;
            ct.ThanhTien = thanhtien;
        }

        private void frmCapNhatPhieuNhap_Load(object sender, EventArgs e)
        {
            cmb_MaHang.DataSource = bllHangHoa.GetListMatHang();
            cmb_MaHang.DisplayMember = "MaHang";
            cmb_MaHang.ValueMember = "MaHang";
            cmb_NhanVien.DataSource = bllNhanVien.GetListNhanVienNhapHang();
            cmb_NhanVien.DisplayMember = "TenNV";
            cmb_NhanVien.ValueMember = "MaNV";
            if(bllPhieuNhap.GetListPhieuNhapByID(_MaPN).Rows.Count > 0)
            {
                txt_MaPN.Text = bllPhieuNhap.GetListPhieuNhapByID(_MaPN).Rows[0]["MaPN"].ToString();
                txt_NgayNhap.Text = bllPhieuNhap.GetListPhieuNhapByID(_MaPN).Rows[0]["NgayNhap"].ToString();
                txt_NgayNhap.Text = DateTime.Parse(txt_NgayNhap.Text).ToShortDateString();
                cmb_NhanVien.Text = bllPhieuNhap.GetListPhieuNhapByID(_MaPN).Rows[0]["MaNV"].ToString();
                txt_MaNCC.Text = bllPhieuNhap.GetListPhieuNhapByID(_MaPN).Rows[0]["MaNCC"].ToString();
                dgv_HangNhap.DataSource = bllCTPhieuNhap.GetListChiTietPNByMaPN(_MaPN);
                TongDonHang();
            }
            cmb_MaHang.Text = "";
            cmb_NhanVien.Text = "";
        }


        private void txt_NhaCC_TextChanged(object sender, EventArgs e)
        {
            if(bllNhaCC.GetNhaCCByID(txt_MaNCC.Text).Rows.Count > 0)
            {
                txt_NhaCC.Text = bllNhaCC.GetNhaCCByID(txt_MaNCC.Text).Rows[0]["TenNCC"].ToString();
                txt_DiaChi.Text = bllNhaCC.GetNhaCCByID(txt_MaNCC.Text).Rows[0]["DiaChi"].ToString();
                txt_SDT.Text = bllNhaCC.GetNhaCCByID(txt_MaNCC.Text).Rows[0]["SDT"].ToString();
                txt_Email.Text = bllNhaCC.GetNhaCCByID(txt_MaNCC.Text).Rows[0]["Email"].ToString();
            }
            else
            {
                txt_NhaCC.Text = "";
                txt_DiaChi.Text = "";
                txt_SDT.Text = "";
                txt_Email.Text = "";
            }
        }

        private void dgv_HangNhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cmb_MaHang.Text = dgv_HangNhap.Rows[row].Cells["MaHang"].Value.ToString();
            txt_TenHang.Text = dgv_HangNhap.Rows[row].Cells["TenHang"].Value.ToString();
            txt_DVT.Text = dgv_HangNhap.Rows[row].Cells["DVT"].Value.ToString();
            txt_GiaNhap.Text = dgv_HangNhap.Rows[row].Cells["GiaNhap"].Value.ToString();
            txt_SoLuong.Text = dgv_HangNhap.Rows[row].Cells["SoLuong"].Value.ToString();
            txt_ChietKhau.Text = dgv_HangNhap.Rows[row].Cells["ChietKhau"].Value.ToString();
            txt_ThanhTien.Text = dgv_HangNhap.Rows[row].Cells["ThanhTien"].Value.ToString();
        }

        private void cmb_MaHang_TextChanged(object sender, EventArgs e)
        {
            if(cmb_MaHang.SelectedValue != null || cmb_MaHang.Text != "")
            {
                if(bllHangHoa.GetMatHangById(cmb_MaHang.Text).Rows.Count > 0)
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
        private void txt_GiaNhap_Leave(object sender, EventArgs e)
        {

            try
            {
                txt_GiaNhap.Text = string.Format("{0:0,0}", double.Parse(txt_GiaNhap.Text.Replace(",", "")));
                gianhap = int.Parse(txt_GiaNhap.Text.Replace(",", ""));
            }
            catch
            {
                MessageBox.Show("Ban phai nhap vao mot so");
                txt_GiaNhap.Text = "0";
                txt_GiaNhap.Focus();
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
        private void txt_ChietKhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chietkhau = int.Parse(txt_ChietKhau.Text);
            }
            catch
            {
                MessageBox.Show("Ban phai nhap vao mot so");
                txt_ChietKhau.Focus();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(cmb_MaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin mặt hàng!", "Thông báo");
                cmb_MaHang.Focus();
            }
            else
            {
                if(txt_GiaNhap.Text == "0" || txt_GiaNhap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập giá nhập!", "Thông báo");
                    txt_GiaNhap.Focus();
                }
                else
                {
                    if(txt_SoLuong.Text == "0" || txt_SoLuong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo");
                        txt_SoLuong.Focus();
                    }
                    else
                    {
                        if(bllCTPhieuNhap.GetListChiTietPNByMaPNandMaHang(txt_MaPN.Text, cmb_MaHang.SelectedValue.ToString()).Rows.Count > 0)
                        {
                            if(MessageBox.Show("Mặt hàng " + cmb_MaHang.SelectedValue.ToString() +
                                " đã có trong đơn hàng.\n Bạn có muốn cập nhật lại không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                btn_Sua_Click(sender, e);
                            }
                        }
                        else
                        {
                            GetDataPhieuNhap();
                            bllCTPhieuNhap.Insert(ct);
                            bllPhieuNhap.UpdateNguoiLapPhieu(txt_MaPN.Text, cmb_NhanVien.SelectedValue.ToString());
                            dgv_HangNhap.DataSource = bllCTPhieuNhap.GetListChiTietPNByMaPN(_MaPN);
                            TongDonHang();
                        }
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            GetDataPhieuNhap();
            bllCTPhieuNhap.Update(ct);
            bllPhieuNhap.UpdateNguoiLapPhieu(txt_MaPN.Text, cmb_NhanVien.SelectedValue.ToString());
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            dgv_HangNhap.DataSource = bllCTPhieuNhap.GetListChiTietPNByMaPN(_MaPN);
            TongDonHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                GetDataPhieuNhap();
                bllCTPhieuNhap.Delete(ct);
                bllPhieuNhap.UpdateNguoiLapPhieu(txt_MaPN.Text, cmb_NhanVien.SelectedValue.ToString());
                dgv_HangNhap.DataSource = bllCTPhieuNhap.GetListChiTietPNByMaPN(_MaPN);
                TongDonHang();
                btn_Refresh_Click(sender, e);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_MaHang.Text = "";
            txt_TenHang.Text = "";
            txt_DVT.Text = "";
            txt_SoLuong.Text = "0";
            txt_GiaNhap.Text = "0";
            txt_ChietKhau.Text = "0";
            txt_ThanhTien.Text = "0";
        }

        private void btn_SavePrint_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn cập nhật \n Phiếu nhập " + txt_MaPN.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bllPhieuNhap.Update(txt_MaPN.Text, cmb_NhanVien.SelectedValue.ToString(), txt_TongTienNhap.Text);
                MessageBox.Show("Bạn đã cập nhật thành công!");
                frm.openChildForm(new frmTimKiemPN(frm));
            }
        }

        private void btn_XoaCTPN_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập " + txt_MaPN.Text + "?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bllPhieuNhap.Delete(txt_MaPN.Text);
                MessageBox.Show("Bạn đã xóa thành công!");
                frm.activeForm.Close();
                frm.openChildForm(new frmTimKiemPN(frm));
            }
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            frm.activeForm.Close();
            frm.openChildForm(new frmTimKiemPN(frm));
        }








        private void grb_PhieuNhap_Enter(object sender, EventArgs e)
        {

        }
        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
