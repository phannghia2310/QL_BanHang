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
using QLBanHangDB.DataLayer;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLBanHangDB.Forms
{
    public partial class frmDMKhachHang : Form
    {
        public frmDMKhachHang()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        KhachHang kh;
        KhachHangBLL bllKhachHang = new KhachHangBLL();

        private void GetDataKhachHang()
        {
            kh = new KhachHang();
            kh.MaKH = txt_MaKH.Text;
            kh.TenKH = txt_TenKH.Text;
            kh.DiaChi = txt_DiaChi.Text;
            kh.SDT = txt_SDT.Text;
            kh.GioiTinh = cmb_GioiTinh.Text;
        }

        private void frmDMKhachHang_Load(object sender, EventArgs e)
        {
            dgv_KhachHang.DataSource = bllKhachHang.GetListKhachHang();
        }

        private void dgv_KhacHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txt_MaKH.Text = dgv_KhachHang.Rows[row].Cells["MaKH"].Value.ToString();
            txt_TenKH.Text = dgv_KhachHang.Rows[row].Cells["TenKH"].Value.ToString();
            cmb_GioiTinh.Text = dgv_KhachHang.Rows[row].Cells["GioiTinh"].Value.ToString();
            txt_DiaChi.Text = dgv_KhachHang.Rows[row].Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = dgv_KhachHang.Rows[row].Cells["SDT"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string select = "";
            if(txt_MaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo");
                txt_MaKH.Focus();
            }
            else
            {
                if(txt_TenKH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên khách hàng!", "Thông báo");
                    txt_TenKH.Focus();
                }
                else
                {
                    select = "Select * from KhachHang where MaKhach='" + txt_MaKH.Text + "'";
                    if (da.CheckKey(select))
                    {
                        MessageBox.Show("Mã khách hàng này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaKH.Focus();
                        return;
                    }
                    else
                    {
                        GetDataKhachHang();
                        bllKhachHang.Insert(kh);
                        dgv_KhachHang.DataSource = bllKhachHang.GetListKhachHang();
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            GetDataKhachHang();
            bllKhachHang.Update(kh);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            dgv_KhachHang.DataSource = bllKhachHang.GetListKhachHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            GetDataKhachHang();
            if (result == DialogResult.Yes)
            {
                bllKhachHang.Delete(kh);
                dgv_KhachHang.DataSource = bllKhachHang.GetListKhachHang();
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
            for (int k = 1; k < dgv_KhachHang.Columns.Count + 1; k++)
            {

                xlWorkSheet.Cells[1, k] = dgv_KhachHang.Columns[k - 1].HeaderText;

            }
            for (i = 0; i <= dgv_KhachHang.RowCount - 1; i++)
            {
                for (j = 0; j <= dgv_KhachHang.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgv_KhachHang[j, i];
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
            GetDataKhachHang();
            if (txt_MaKH.Text == "" && txt_TenKH.Text == "" && txt_DiaChi.Text == "" && txt_SDT.Text == "" && cmb_GioiTinh.Text == "")
                dgv_KhachHang.DataSource = bllKhachHang.GetListKhachHang();
            else
                dgv_KhachHang.DataSource = bllKhachHang.Search(kh);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
            cmb_GioiTinh.Text = "";
            txt_MaKH.Focus();
        }
    }
}
