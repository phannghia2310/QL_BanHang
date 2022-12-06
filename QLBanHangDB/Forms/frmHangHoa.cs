using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHangDB.BusinessLayer;
using QLBanHangDB.DataLayer;
using QLBanHangDB.Entities;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLBanHangDB.Forms
{
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        HangHoa hh;
        HangHoaBLL bllHangHoa = new HangHoaBLL();
        NhomHangBLL bllNhomHang = new NhomHangBLL();
        HangSXBLL bllHangSX = new HangSXBLL();
        
        private void GetDataHangHoa()
        {
            hh = new HangHoa();
            hh.MaHang = txt_MaHang.Text;
            hh.TenHang = txt_TenHang.Text;
            hh.DonGia = txt_DonGia.Text;
            hh.DVT = cmb_DVT.Text;
            hh.VAT = txt_VAT.Text;
            hh.MaNhomHang = cmb_MaNhomHang.SelectedValue.ToString();
            hh.MaHangSX = cmb_MaHangSX.SelectedValue.ToString();
        }
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            dgv_HangHoa.DataSource = bllHangHoa.GetListMatHang();
            cmb_MaNhomHang.DataSource = bllNhomHang.GetListNhomHang();
            cmb_MaNhomHang.DisplayMember = "TenNhomHang";
            cmb_MaNhomHang.ValueMember = "MaNhomHang";
            cmb_MaHangSX.DataSource = bllHangSX.GetListHangSX();
            cmb_MaHangSX.DisplayMember = "TenHangSX";
            cmb_MaHangSX.ValueMember = "MaHangSX";
        }
        private void dgv_HangHoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txt_MaHang.Text = dgv_HangHoa.Rows[row].Cells["MaHang"].Value.ToString();
            txt_TenHang.Text = dgv_HangHoa.Rows[row].Cells["TenHang"].Value.ToString();
            txt_DonGia.Text = dgv_HangHoa.Rows[row].Cells["DonGia"].Value.ToString();
            txt_VAT.Text = dgv_HangHoa.Rows[row].Cells["VAT"].Value.ToString();
            cmb_DVT.Text = dgv_HangHoa.Rows[row].Cells["DVT"].Value.ToString();
            cmb_MaHangSX.Text = dgv_HangHoa.Rows[row].Cells["TenHangSX"].Value.ToString();
            cmb_MaNhomHang.Text = dgv_HangHoa.Rows[row].Cells["TenNhomHang"].Value.ToString();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string select = "";
            if(txt_MaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hàng!", "Thông báo");
                txt_MaHang.Focus();
            }
            else
            {
                if(txt_TenHang.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên hàng!", "Thông báo");
                    txt_TenHang.Focus();
                }
                else
                {
                    select = "Select hh.MaHang, hh.TenHang, hh.DVT, hh.DonGia, hh.VAT," +
                                    " nh.TenNhomHang, hsx.TenHangSX from HangHoa hh, NhomHang nh, HangSX hsx" +
                                    " where hh.MaHangSX=hsx.MaHangSX, hh.MaNhomHang=nh.MaNhomHang" +
                                    " and hh.MaHang='" + txt_MaHang.Text + "'";
                    if(da.CheckKey(select))
                    {
                        MessageBox.Show("Mã hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaHang.Focus();
                        return;
                    }
                    else
                    {
                        GetDataHangHoa();
                        bllHangHoa.Insert(hh);
                        dgv_HangHoa.DataSource = bllHangHoa.GetListMatHang();
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            GetDataHangHoa();
            bllHangHoa.Update(hh);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            dgv_HangHoa.DataSource = bllHangHoa.GetListMatHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            GetDataHangHoa();
            if (result == DialogResult.Yes)
            {
                bllHangHoa.Delete(hh);
                dgv_HangHoa.DataSource = bllHangHoa.GetListMatHang();
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
            for (int k = 1; k < dgv_HangHoa.Columns.Count + 1; k++)
            {

                xlWorkSheet.Cells[1, k] = dgv_HangHoa.Columns[k - 1].HeaderText;

            }
            for (i = 0; i <= dgv_HangHoa.RowCount - 1; i++)
            {
                for (j = 0; j <= dgv_HangHoa.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgv_HangHoa[j, i];
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
            GetDataHangHoa();
            if (txt_MaHang.Text == "" && txt_TenHang.Text == "" && txt_DonGia.Text == "" && txt_VAT.Text == ""
                && cmb_DVT.Text == "" && cmb_MaHangSX.Text == "" && cmb_MaNhomHang.Text == "")
                dgv_HangHoa.DataSource = bllHangHoa.GetListMatHang();
            else
                dgv_HangHoa.DataSource = bllHangHoa.Search(hh);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaHang.Text = "";
            txt_TenHang.Text = "";
            txt_DonGia.Text = "";
            txt_VAT.Text = "";
            cmb_DVT.Text = "";
            cmb_MaHangSX.Text = "";
            cmb_MaNhomHang.Text = "";
            txt_MaHang.Focus();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
