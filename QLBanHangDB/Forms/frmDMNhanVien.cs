using QLBanHangDB.BusinessLayer;
using QLBanHangDB.DataLayer;
using QLBanHangDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLBanHangDB.Forms
{
    public partial class frmDMNhanVien : Form
    {
        public frmDMNhanVien()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        ChucVuBLL bllChucVu = new ChucVuBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        NhanVien nv;

        private void GetDataNhanVien()
        {
            nv = new NhanVien();
            nv.MaNV = txt_MaNV.Text;
            nv.TenNV = txt_TenNV.Text;
            nv.MaCV = cmb_MaCV.SelectedValue.ToString();
            nv.MaQL = txt_MaQL.Text;
            nv.NgaySinh = dtp_NgaySinh.Value;
            nv.GioiTinh = cmb_GioiTinh.Text;
            nv.DiaChi = txt_DiaChi.Text;
            nv.SDT = txt_SDT.Text;
        }
        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = bllNhanVien.GetListNhanVien();
            cmb_MaCV.DataSource = bllChucVu.GetListChucVu();
            cmb_MaCV.DisplayMember = "TenCV";
            cmb_MaCV.ValueMember = "MaCV";
        }
        private void dgv_NhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txt_MaNV.Text = dgv_NhanVien.Rows[row].Cells["MaNV"].Value.ToString();
            txt_TenNV.Text = dgv_NhanVien.Rows[row].Cells["TenNV"].Value.ToString();
            txt_DiaChi.Text = dgv_NhanVien.Rows[row].Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = dgv_NhanVien.Rows[row].Cells["SDT"].Value.ToString();
            dtp_NgaySinh.Text = dgv_NhanVien.Rows[row].Cells["NgaySinh"].Value.ToString();
            cmb_MaCV.Text = dgv_NhanVien.Rows[row].Cells["TenCV"].Value.ToString();
            txt_MaQL.Text = dgv_NhanVien.Rows[row].Cells["MaQL"].Value.ToString();
            cmb_GioiTinh.Text = dgv_NhanVien.Rows[row].Cells["GioiTinh"].Value.ToString();
        }
        private void cmb_MaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_MaCV.SelectedValue != null)
            {
                if(bllChucVu.GetChucVuById(cmb_MaCV.SelectedValue.ToString()).Rows.Count > 0)
                {
                    txt_MaQL.Text = bllNhanVien.GetMaQuanLyByID(cmb_MaCV.SelectedValue.ToString()).Rows[0]["MaQL"].ToString();
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string select = "";
            if(txt_MaNV.Text == null || txt_MaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông báo");
                txt_MaNV.Focus();
            }
            else
            {
                if (txt_TenNV.Text == null || txt_TenNV.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Thông báo");
                    txt_TenNV.Focus();
                }
                else
                {
                    select = "Select nv.MaNV,nv.TenNV,nv.MaQL,nv.GioiTinh,nv.NgaySinh," +
                                "nv.DiaChi,nv.SDT, cv.TenCV from NhanVien nv, ChucVu cv " +
                                "where nv.MaCV = cv.MaCV and nv.MaNV='" + txt_MaNV.Text + "'";
                    if (da.CheckKey(select))
                    {
                        MessageBox.Show("Mã nhân viên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaNV.Focus();
                        return;
                    }
                    else
                    {
                        GetDataNhanVien();
                        bllNhanVien.Insert(nv);
                        dgv_NhanVien.DataSource = bllNhanVien.GetListNhanVien();
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            GetDataNhanVien();
            bllNhanVien.Update(nv);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            dgv_NhanVien.DataSource = bllNhanVien.GetListNhanVien();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            GetDataNhanVien();
            if (result == DialogResult.Yes)
            {
                bllNhanVien.Delete(nv);
                dgv_NhanVien.DataSource = bllNhanVien.GetListNhanVien();
            }
            else
            {
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (int k = 1; k < dgv_NhanVien.Columns.Count + 1; k++)
            {

                xlWorkSheet.Cells[1, k] = dgv_NhanVien.Columns[k - 1].HeaderText;

            }
            for (i = 0; i <= dgv_NhanVien.RowCount - 1; i++)
            {
                for (j = 0; j <= dgv_NhanVien.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgv_NhanVien[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = "Excel Files (*.xls)|*.xls;";
            if (sdlg.ShowDialog() == DialogResult.OK)
            {
                string filename = sdlg.FileName;

                xlWorkBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                MessageBox.Show("You saved success!");
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            GetDataNhanVien();
            if (txt_MaNV.Text == "" && txt_TenNV.Text == "" && txt_DiaChi.Text == "" && txt_SDT.Text == ""
                && cmb_MaCV.Text == "" && cmb_MaCV.Text == "" && cmb_GioiTinh.Text == ""
                && dtp_NgaySinh.Text == DateTime.Now.ToShortDateString())
                dgv_NhanVien.DataSource = bllNhanVien.GetListNhanVien();
            else
            {
                dgv_NhanVien.DataSource = bllNhanVien.Search(nv);
            }
                
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_TenNV.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
            txt_MaQL.Text = "";
            cmb_MaCV.Text = "";
            dtp_NgaySinh.Text = DateTime.Now.ToString();
            cmb_GioiTinh.Text = "";
            txt_MaNV.Focus();
        }

    }
}
