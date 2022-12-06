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
    public partial class frmHangSX : Form
    {
        public frmHangSX()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        HangSX hsx;
        HangSXBLL bllHangSX = new HangSXBLL();

        private void GetDataHangSX()
        {
            hsx = new HangSX();
            hsx.MaHangSX = txt_MaHangSX.Text;
            hsx.TenHangSX = txt_TenHangSX.Text;
        }
        private void frmHangSX_Load(object sender, EventArgs e)
        {
            dgv_HangSX.DataSource = bllHangSX.GetListHangSX();
        }
        private void dgv_HangSX_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txt_MaHangSX.Text = dgv_HangSX.Rows[row].Cells["MaHangSX"].Value.ToString();
            txt_TenHangSX.Text = dgv_HangSX.Rows[row].Cells["TenHangSX"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string select = "";
            if(txt_MaHangSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hãng sản xuất~", "Thông báo");
                txt_MaHangSX.Focus();
            }
            else
            {
                if(txt_TenHangSX.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên hãng sản xuất!", "Thông báo");
                    txt_TenHangSX.Focus();
                }
                else
                {
                    select = "Select * from HangSX where MaHangSX='" + hsx.MaHangSX + "'";
                    if(da.CheckKey(select))
                    {
                        MessageBox.Show("Mã hãng sản xuất đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaHangSX.Focus();
                    }
                    else
                    {
                        GetDataHangSX();
                        bllHangSX.Insert(hsx);
                        dgv_HangSX.DataSource = bllHangSX.GetListHangSX();
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            GetDataHangSX();
            bllHangSX.Update(hsx);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            dgv_HangSX.DataSource = bllHangSX.GetListHangSX();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            GetDataHangSX();
            if (result == DialogResult.Yes)
            {
                bllHangSX.Delete(hsx);
                dgv_HangSX.DataSource = bllHangSX.GetListHangSX();
            }
            else
            {
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            GetDataHangSX();
            if (txt_MaHangSX.Text == "" && txt_TenHangSX.Text == "")
                dgv_HangSX.DataSource = bllHangSX.GetListHangSX();
            else
                dgv_HangSX.DataSource = bllHangSX.Search(hsx);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaHangSX.Text = "";
            txt_TenHangSX.Text = "";
            txt_MaHangSX.Focus();
        }
    }
}
