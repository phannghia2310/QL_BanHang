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
using Excel = Microsoft.Office.Interop.Excel;

namespace QLBanHangDB.Forms
{
    public partial class frmDMNhaCC : Form
    {
        public frmDMNhaCC()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        NhaCC ncc;
        NhaCCBLL bllNhaCC = new NhaCCBLL();

        private void GetDataNhaCC()
        {
            ncc = new NhaCC();
            ncc.MaNCC = txt_MaNCC.Text;
            ncc.TenNCC = txt_TenNCC.Text;
            ncc.DiaChi = txt_DiaChi.Text;
            ncc.SDT = txt_SDT.Text;
            ncc.Fax = txt_Fax.Text;
            ncc.Email = txt_Email.Text;
        }

        private void frmDMNhaCC_Load(object sender, EventArgs e)
        {
            dgv_NhaCC.DataSource = bllNhaCC.GetListNhaCC();
        }
        private void dgv_NhaCC_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txt_MaNCC.Text = dgv_NhaCC.Rows[row].Cells["MaNCC"].Value.ToString();
            txt_TenNCC.Text = dgv_NhaCC.Rows[row].Cells["TenNCC"].Value.ToString();
            txt_DiaChi.Text = dgv_NhaCC.Rows[row].Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = dgv_NhaCC.Rows[row].Cells["SDT"].Value.ToString();
            txt_Fax.Text = dgv_NhaCC.Rows[row].Cells["Fax"].Value.ToString();
            txt_Email.Text = dgv_NhaCC.Rows[row].Cells["Email"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string select = "";
            if(txt_MaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp!", "Thông báo");
                txt_MaNCC.Focus();
            }
            else
            {
                if(txt_TenNCC.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà cung cấp!", "Thông báo");
                    txt_TenNCC.Focus();
                }
                else
                {
                    select = "Select * from NhaCungCap where MaNCC='" + txt_MaNCC.Text + "'";
                    if (da.CheckKey(select))
                    {
                        MessageBox.Show("Mã nhà cung cấp đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaNCC.Focus();
                        return;
                    }
                    else
                    {
                        GetDataNhaCC();
                        bllNhaCC.Insert(ncc);
                        dgv_NhaCC.DataSource = bllNhaCC.GetListNhaCC();
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            GetDataNhaCC();
            bllNhaCC.Update(ncc);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            dgv_NhaCC.DataSource = bllNhaCC.GetListNhaCC();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            GetDataNhaCC();
            if (result == DialogResult.Yes)
            {
                bllNhaCC.Delete(ncc);
                dgv_NhaCC.DataSource = bllNhaCC.GetListNhaCC();
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
            for (int k = 1; k < dgv_NhaCC.Columns.Count + 1; k++)
            {

                xlWorkSheet.Cells[1, k] = dgv_NhaCC.Columns[k - 1].HeaderText;

            }
            for (i = 0; i <= dgv_NhaCC.RowCount - 1; i++)
            {
                for (j = 0; j <= dgv_NhaCC.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgv_NhaCC[j, i];
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
            GetDataNhaCC();
            if (txt_MaNCC.Text == "" && txt_TenNCC.Text == "" && txt_DiaChi.Text == "" && txt_SDT.Text == "" && txt_Fax.Text == "" && txt_Email.Text == "")
                dgv_NhaCC.DataSource = bllNhaCC.GetListNhaCC();
            else
                dgv_NhaCC.DataSource = bllNhaCC.Search(ncc);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaNCC.Text = "";
            txt_TenNCC.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
            txt_Fax.Text = "";
            txt_Email.Text = "";
            txt_MaNCC.Focus();
        }
    }
}
