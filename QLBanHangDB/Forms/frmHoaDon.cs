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
    public partial class frmHoaDon : Form
    {
        frmMain frm;
        public frmHoaDon(frmMain _frm)
        {
            InitializeComponent();
            this.frm = _frm;
        }

        DataAccess da = new DataAccess();
        HoaDonBanHang hd = new HoaDonBanHang();
        ChiTietHoaDon ct = new ChiTietHoaDon();
        HoaDonBLL bllHoaDon = new HoaDonBLL();
        List<ChiTietHoaDon> listCTHoaDon = new List<ChiTietHoaDon>();
        KhachHangBLL bllKhachHang = new KhachHangBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        HangHoaBLL bllHangHoa = new HangHoaBLL();
        DataTable DTChiTietHoaDon = new DataTable();
        int giaban, soluong, vat, thanhtien;


        private void GetDataHoaDon()
        {
            hd = new HoaDonBanHang();
            listCTHoaDon = new List<ChiTietHoaDon>();
            hd.MaHD = txt_MaHD.Text;
            hd.MaKH = cmb_KhachHang.SelectedValue.ToString();
            hd.NgayBan = DateTime.Parse(dtp_NgayBan.Text);
            hd.MaNV = cmb_NhanVien.SelectedValue.ToString();
            hd.TongTienHD = int.Parse(txt_TongTienHD.Text);
            hd.ListCTHoaDon = listCTHoaDon;
            int tongTienHD;
            int.TryParse(txt_TongTienHD.Text, out tongTienHD);
            hd.TongTienHD = tongTienHD;
            foreach(DataRow row in DTChiTietHoaDon.Rows)
            {
                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.MaHD = txt_MaHD.Text;
                ct.MaHang = row["MaHang"].ToString();
                ct.GiaBan = int.Parse(row["GiaBan"].ToString());
                ct.SoLuong = int.Parse(row["SoLuong"].ToString());
                ct.VAT = int.Parse(row["VAT"].ToString());
                ct.ThanhTien = int.Parse(row["ThanhTien"].ToString());
                listCTHoaDon.Add(ct);
            }
            hd.ListCTHoaDon = listCTHoaDon;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            cmb_MaHang.DataSource = bllHangHoa.GetListMatHang();
            cmb_MaHang.DisplayMember = "MaHang";
            cmb_MaHang.ValueMember = "MaHang";
            cmb_MaHang.Text = "";
            dtp_NgayBan.Text = DateTime.Now.ToShortDateString();
            cmb_KhachHang.DataSource = bllKhachHang.GetListKhachHang();
            cmb_KhachHang.DisplayMember = "TenKH";
            cmb_KhachHang.ValueMember = "MaKH";
            cmb_KhachHang.Text = "";
            cmb_NhanVien.DataSource = bllNhanVien.GetListNhanVienBanHang();
            cmb_NhanVien.DisplayMember = "TenNV";
            cmb_NhanVien.ValueMember = "MaNV";

            DTChiTietHoaDon.Columns.Add("STT");
            DTChiTietHoaDon.Columns.Add("MaHang");
            DTChiTietHoaDon.Columns.Add("TenHang");
            DTChiTietHoaDon.Columns.Add("GiaBanH", typeof(int));
            DTChiTietHoaDon.Columns.Add("SoLuongH", typeof(int));
            DTChiTietHoaDon.Columns.Add("DVT");
            DTChiTietHoaDon.Columns.Add("VATH", typeof(int));
            DTChiTietHoaDon.Columns.Add("ThanhTienH", typeof(int));
        }
        private void dgv_HangBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cmb_MaHang.Text = dgv_HangBan.Rows[row].Cells["MaHang"].Value.ToString();
            txt_TenHang.Text = dgv_HangBan.Rows[row].Cells["TenHang"].Value.ToString();
            txt_GiaBan.Text = dgv_HangBan.Rows[row].Cells["GiaBanH"].Value.ToString();
            txt_DVT.Text = dgv_HangBan.Rows[row].Cells["DVT"].Value.ToString();
            txt_SoLuong.Text = dgv_HangBan.Rows[row].Cells["SoLuongH"].Value.ToString();
            txt_ThanhTien.Text = dgv_HangBan.Rows[row].Cells["ThanhTienH"].Value.ToString();
        }

        private void cmb_KhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_KhachHang.SelectedValue != null)
            {
                if(bllKhachHang.GetListKhachHangByID(cmb_KhachHang.SelectedValue.ToString()).Rows.Count >0)
                {
                    txt_TenKH.Text = bllKhachHang.GetListKhachHangByID(cmb_KhachHang.SelectedValue.ToString()).Rows[0]["TenKH"].ToString();
                    txt_DiaChi.Text = bllKhachHang.GetListKhachHangByID(cmb_KhachHang.SelectedValue.ToString()).Rows[0]["DiaChi"].ToString();
                    txt_SDT.Text = bllKhachHang.GetListKhachHangByID(cmb_KhachHang.SelectedValue.ToString()).Rows[0]["SDT"].ToString();
                }
            }
        }
        private void cmb_MaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_MaHang.SelectedValue != null)
            {
                if (bllHangHoa.GetMatHangById(cmb_MaHang.SelectedValue.ToString()).Rows.Count > 0)
                {
                    txt_TenHang.Text = bllHangHoa.GetMatHangById(cmb_MaHang.SelectedValue.ToString()).Rows[0]["TenHang"].ToString();
                    txt_DVT.Text = bllHangHoa.GetMatHangById(cmb_MaHang.SelectedValue.ToString()).Rows[0]["DVT"].ToString();
                }
            }
        }
        private void TongDonHang()
        {
            object sum = DTChiTietHoaDon.Compute("Sum(ThanhTienH)", string.Empty);
            int Tong;
            int.TryParse(sum.ToString(), out Tong);
            txt_TongTienHD.Text = Tong.ToString();
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
            if(cmb_MaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã hàng!", "Thông báo");
                cmb_MaHang.Focus();
            }
            else
            {
                if(txt_GiaBan.Text == "0" || txt_GiaBan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập giá bán!", "Thông báo");
                    txt_GiaBan.Focus();
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
                        if(DTChiTietHoaDon.Select("MaHang='" + cmb_MaHang.Text + "'").Length > 0)
                        {
                            if (MessageBox.Show("Mặt hàng " + cmb_MaHang.Text + " đã tồn tại.\n Bạn có muốn cập nhật lại không?", "Thông báo",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                btn_Sua_Click(sender, e);
                            }
                        }
                        else
                        {
                            DataRow row = DTChiTietHoaDon.NewRow();
                            row["MaHang"] = cmb_MaHang.Text;
                            row["TenHang"] = txt_TenHang.Text;
                            row["GiaBanH"] = int.Parse(txt_GiaBan.Text.Replace(",", ""));
                            row["SoLuongH"] = txt_SoLuong.Text;
                            row["DVT"] = txt_DVT.Text;
                            int vat;
                            int.TryParse(txt_VAT.Text, out vat);
                            row["VATH"] = vat;
                            thanhtien = giaban * soluong * (100 + vat) / 100;
                            txt_ThanhTien.Text = thanhtien.ToString();
                            row["ThanhTienH"] = thanhtien.ToString();
                            dgv_HangBan.DataSource = DTChiTietHoaDon;
                            for(int i=0; i<dgv_HangBan.Rows.Count; i++)
                            {
                                dgv_HangBan.Rows[i].Cells["STT"].Value = i + 1;
                            }
                            TongDonHang();
                        }
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            for(int i =0; i<dgv_HangBan.Rows.Count; i++)
            {
                dgv_HangBan.Rows[i].Cells["STT"].Value = (i + 1).ToString();
            }
            DataRow[] drr = DTChiTietHoaDon.Select("MaHang='" + cmb_MaHang.Text + "'");
            if(drr.Length > 0)
            {
                drr[0]["GiaBanH"] = int.Parse(txt_GiaBan.Text.Replace(",", ""));
                drr[0]["SoLuongH"] = txt_SoLuong.Text;
                int.TryParse(txt_VAT.Text, out vat);
                thanhtien = giaban * soluong * (100 + vat) / 100;
                drr[0]["ThanhTienH"] = thanhtien;
                txt_ThanhTien.Text = thanhtien.ToString();
            }
            MessageBox.Show("Cập nhật thành công!");
            dgv_HangBan.DataSource = DTChiTietHoaDon;
            TongDonHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_HangBan.Rows.Count; i++)
            {
                dgv_HangBan.Rows[i].Cells["STT"].Value = i + 1;
            }
            DataRow[] drr = DTChiTietHoaDon.Select("MaHang='" + cmb_MaHang.Text + "'");
            for (int i = 0; i < drr.Length; i++)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DTChiTietHoaDon.Rows.Remove(drr[i]);
                    DTChiTietHoaDon.AcceptChanges();
                    btn_Refresh_Click(sender, e);
                }
            }
            TongDonHang();
            dgv_HangBan.DataSource = DTChiTietHoaDon;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_MaHang.Text = "";
            txt_TenHang.Text = "";
            txt_DVT.Text = "";
            txt_GiaBan.Text = "0";
            txt_SoLuong.Text = "0";
            txt_VAT.Text = "0";
            txt_ThanhTien.Text = "0";
        }

        private void btn_SavePrint_Click(object sender, EventArgs e)
        {
            //Kiểm tra thông tin hóa đơn
            if(txt_MaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn!", "Thông báo");
                txt_MaHD.Focus();
            }
            else
            {
                if(cmb_KhachHang.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng!", "Thông báo");
                    cmb_KhachHang.Focus();
                }
                else
                {
                    if(cmb_NhanVien.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông báo");
                        cmb_NhanVien.Focus();
                    }
                    else
                    {
                        if(DTChiTietHoaDon.Rows.Count == 0)
                        {
                            MessageBox.Show("Hóa đơn không có hàng, bạn có muốn lưu không?", "Thông báo");
                        }
                        else
                        {
                            GetDataHoaDon();
                            bllHoaDon.Insert(hd);
                            DTChiTietHoaDon.Clear();
                            txt_TongTienHD.Text = "0";
                            txt_ThanhTien.Text = "0";
                        }
                    }
                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            frm.openChildForm(new frmTimKiemHD(frm));
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_MaHD.Text = "";
            dtp_NgayBan.Value = DateTime.Today;
            cmb_NhanVien.Text = "";
            cmb_KhachHang.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
            txt_TongTienHD.Text = "0";
            DTChiTietHoaDon.Clear();
            dgv_HangBan.DataSource = DTChiTietHoaDon;
        }








        private void dgc_HangBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } 
}
