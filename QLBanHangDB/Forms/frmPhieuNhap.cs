using QLBanHangDB.BusinessLayer;
using QLBanHangDB.DataLayer;
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
    public partial class frmPhieuNhap : Form
    {
        frmMain frm;
        public frmPhieuNhap(frmMain _frm)
        {
            InitializeComponent();
            this.frm = _frm;
        }

        DataAccess da = new DataAccess();
        PhieuNhap pn = new PhieuNhap();
        ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
        PhieuNhapBLL bllPhieuNhap = new PhieuNhapBLL();
        List<ChiTietPhieuNhap> listCTPhieuNhap = new List<ChiTietPhieuNhap>();
        NhaCCBLL bllNhaCC = new NhaCCBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        HangHoaBLL bllHangHoa = new HangHoaBLL();
        DataTable DTChiTietPhieuNhap = new DataTable();
        int gianhap, soluong, chietkhau, thanhtien;
        private void GetDataPhieuNhap()
        {
            pn = new PhieuNhap();
            listCTPhieuNhap = new List<ChiTietPhieuNhap>();
            pn.MaPN = txt_MaPN.Text;
            pn.MaNCC = cmb_NhaCC.SelectedValue.ToString();
            pn.NgayNhap = DateTime.Parse(dtp_NgayNhap.Text);
            pn.MaNV = cmb_NhanVien.SelectedValue.ToString();
            pn.TongTienNhap = int.Parse(txt_TongTienNhap.Text);
            pn.ListCTPhieuNhap = listCTPhieuNhap;
            int tongTienNhap;
            int.TryParse(txt_TongTienNhap.Text, out tongTienNhap);
            pn.TongTienNhap = tongTienNhap;
            foreach(DataRow row in DTChiTietPhieuNhap.Rows)
            {
                ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
                ct.MaPN = txt_MaPN.Text;
                ct.MaHang = row["MaHN"].ToString();
                ct.GiaNhap = int.Parse(row["GiaNhap"].ToString());
                ct.SoLuong = int.Parse(row["SoLuong"].ToString());
                ct.ChietKhau = int.Parse(row["ChietKhau"].ToString());
                ct.ThanhTien = int.Parse(row["ThanhTien"].ToString());
                listCTPhieuNhap.Add(ct);
            }
            pn.ListCTPhieuNhap = listCTPhieuNhap;
        }


        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            cmb_MaHang.DataSource = bllHangHoa.GetListMatHang();
            cmb_MaHang.DisplayMember = "MaHang";
            cmb_MaHang.ValueMember = "MaHang";
            cmb_MaHang.Text = "";
            dtp_NgayNhap.Text = DateTime.Now.ToString();
            cmb_NhaCC.DataSource = bllNhaCC.GetListNhaCC();
            cmb_NhaCC.DisplayMember = "TenNCC";
            cmb_NhaCC.ValueMember = "MaNCC";
            cmb_NhaCC.Text = "";
            cmb_NhanVien.DataSource = bllNhanVien.GetListNhanVienNhapHang();
            cmb_NhanVien.DisplayMember = "TenNV";
            cmb_NhanVien.ValueMember = "MaNV";

            DTChiTietPhieuNhap.Columns.Add("STTHN");
            DTChiTietPhieuNhap.Columns.Add("MaHN");
            DTChiTietPhieuNhap.Columns.Add("TenHN");
            DTChiTietPhieuNhap.Columns.Add("GiaNhap", typeof(int));
            DTChiTietPhieuNhap.Columns.Add("SoLuong", typeof(int));
            DTChiTietPhieuNhap.Columns.Add("DVT");
            DTChiTietPhieuNhap.Columns.Add("ChietKhau", typeof(int));
            DTChiTietPhieuNhap.Columns.Add("ThanhTienPN", typeof(int));

        }
        private void dgv_HangNhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cmb_MaHang.Text = dgv_HangNhap.Rows[row].Cells["MaHN"].Value.ToString();
            txt_TenHang.Text = dgv_HangNhap.Rows[row].Cells["TenHN"].Value.ToString();
            txt_GiaNhap.Text = dgv_HangNhap.Rows[row].Cells["GiaNhap"].Value.ToString();
            txt_DVT.Text = dgv_HangNhap.Rows[row].Cells["DVT"].Value.ToString();
            txt_SoLuong.Text = dgv_HangNhap.Rows[row].Cells["SoLuong"].Value.ToString();
            txt_ThanhTien.Text = dgv_HangNhap.Rows[row].Cells["ThanhTienPN"].Value.ToString();
        }
        private void cmb_NhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_NhaCC.SelectedValue != null)
            {
                if(bllNhaCC.GetNhaCCByID(cmb_NhaCC.SelectedValue.ToString()).Rows.Count > 0)
                {
                    txt_DiaChi.Text = bllNhaCC.GetNhaCCByID(cmb_NhaCC.SelectedValue.ToString()).Rows[0]["DiaChi"].ToString();
                    txt_SDT.Text = bllNhaCC.GetNhaCCByID(cmb_NhaCC.SelectedValue.ToString()).Rows[0]["SDT"].ToString();
                    txt_Email.Text = bllNhaCC.GetNhaCCByID(cmb_NhaCC.SelectedValue.ToString()).Rows[0]["Email"].ToString();
                }
            }
        }
        private void cmb_MaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_MaHang.SelectedValue != null)
            {
                if(bllHangHoa.GetMatHangById(cmb_MaHang.SelectedValue.ToString()).Rows.Count > 0)
                {
                    txt_TenHang.Text = bllHangHoa.GetMatHangById(cmb_MaHang.SelectedValue.ToString()).Rows[0]["TenHang"].ToString();
                    txt_DVT.Text = bllHangHoa.GetMatHangById(cmb_MaHang.SelectedValue.ToString()).Rows[0]["DVT"].ToString();
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(cmb_MaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã hàng!", "Thông báo");
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
                        if (DTChiTietPhieuNhap.Select("MaHN='" + cmb_MaHang.Text + "'").Length > 0)
                        {
                            if(MessageBox.Show("Mặt hàng " + cmb_MaHang.Text + " đã tồn tại.\n Bạn có muốn cập nhật lại không?", "Thông báo",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                btn_Sua_Click(sender, e);
                            }
                        }
                        else
                        {
                            DataRow row = DTChiTietPhieuNhap.NewRow();
                            row["MaHN"] = cmb_MaHang.Text;
                            row["TenHN"] = txt_TenHang.Text;
                            row["GiaNhap"] = int.Parse(txt_GiaNhap.Text.Replace(",", ""));
                            row["SoLuong"] = txt_SoLuong.Text;
                            row["DVT"] = txt_DVT.Text;
                            int chietkhau;
                            int.TryParse(txt_ChietKhau.Text, out chietkhau);
                            row["ChietKhau"] = chietkhau;
                            thanhtien = gianhap * soluong * (100 - chietkhau) / 100;
                            txt_ThanhTien.Text = thanhtien.ToString();
                            row["ThanhTienPN"] = thanhtien.ToString();
                            DTChiTietPhieuNhap.Rows.Add(row);
                            dgv_HangNhap.DataSource = DTChiTietPhieuNhap;
                            for (int i = 0; i < dgv_HangNhap.Rows.Count; i++)
                            {
                                dgv_HangNhap.Rows[i].Cells["STTHN"].Value = i + 1;
                            }
                            TongDonHang();
                        }
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_HangNhap.Rows.Count; i++)
            {
                dgv_HangNhap.Rows[i].Cells["STTHN"].Value = (i + 1).ToString();
            }
            DataRow[] drr = DTChiTietPhieuNhap.Select("MaHN='" + cmb_MaHang.Text + "'");
            if (drr.Length > 0)
            {
                drr[0]["GiaNhap"] = int.Parse(txt_GiaNhap.Text.Replace(",",""));
                drr[0]["SoLuong"] = txt_SoLuong.Text;
                int.TryParse(txt_ChietKhau.Text, out chietkhau);
                drr[0]["ChietKhau"] = chietkhau;
                thanhtien = gianhap * soluong * (100 - chietkhau) / 100;
                drr[0]["ThanhTienPN"] = thanhtien;
                txt_ThanhTien.Text = thanhtien.ToString();
            }
            MessageBox.Show("Cập nhật thành công!");
            dgv_HangNhap.DataSource = DTChiTietPhieuNhap;
            TongDonHang();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_HangNhap.Rows.Count; i++)
            {
                dgv_HangNhap.Rows[i].Cells["STTHN"].Value = i + 1;
            }
            DataRow[] drr = DTChiTietPhieuNhap.Select("MaHN='" + cmb_MaHang.Text + "'");
            for(int i=0; i<drr.Length; i++)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    DTChiTietPhieuNhap.Rows.Remove(drr[i]);
                    DTChiTietPhieuNhap.AcceptChanges();
                    btn_Refresh_Click(sender, e);
                }
            }
            TongDonHang();
            dgv_HangNhap.DataSource = DTChiTietPhieuNhap;
        }
        private void btn_SavePrint_Click(object sender, EventArgs e)
        {
            string sql;
            //Kiểm tra và tạo phiếu nhập
            sql = "Select MaPN from PhieuNhap where MaPN='" + txt_MaPN.Text + "'";
            if(da.CheckKey(sql))
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại!", "Thông báo");
                txt_MaPN.Focus();
            }
            else
            {
                if(txt_MaPN.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã phiếu nhập!", "Thông báo");
                    txt_MaPN.Focus();
                }
                else
                {
                    if (cmb_NhaCC.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn nhà cung cấp!", "Thông báo");
                        cmb_NhaCC.Focus();
                    }
                    else
                    {
                        if (cmb_NhanVien.Text == "")
                        {
                            MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông báo");
                            cmb_NhanVien.Focus();
                        }
                        else
                        {
                            if(DTChiTietPhieuNhap.Rows.Count == 0)
                            {
                                MessageBox.Show("Phiếu nhập không có hàng, bạn có muốn lưu không?", "Thông báo");
                            }
                            else
                            {
                                GetDataPhieuNhap();
                                bllPhieuNhap.Insert(pn);
                                DTChiTietPhieuNhap.Clear();
                                txt_TongTienNhap.Text = "0";
                                txt_ThanhTien.Text = "0";
                            }
                        }
                    }
                }
            }
        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            frm.openChildForm(new frmTimKiemPN(frm));
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_MaHang.Text = "";
            txt_TenHang.Text = "";
            txt_DVT.Text = "";
            txt_GiaNhap.Text = "0";
            txt_SoLuong.Text = "0";
            txt_ChietKhau.Text = "0";
            txt_ThanhTien.Text = "0";
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_MaPN.Text = "";
            dtp_NgayNhap.Value = DateTime.Today;
            cmb_NhanVien.Text = "";
            cmb_NhaCC.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
            txt_Email.Text = "";
            txt_TongTienNhap.Text = "0";
            DTChiTietPhieuNhap.Clear();
            dgv_HangNhap.DataSource = DTChiTietPhieuNhap;
        }

        private void TongDonHang()
        {
            object sum = DTChiTietPhieuNhap.Compute("Sum(ThanhTienPN)", string.Empty);
            int Tong;
            int.TryParse(sum.ToString(), out Tong);
            txt_TongTienNhap.Text = Tong.ToString();
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





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
