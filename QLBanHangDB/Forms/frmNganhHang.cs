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
    public partial class frmNganhHang : Form
    {
        public frmNganhHang()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        NganhHang ngh;
        NganhHangBLL bllNganhHang = new NganhHangBLL();

        private void GetDataNganhHang()
        {
            ngh = new NganhHang();
            ngh.MaNganhHang = txt_MaNganhH.Text;
            ngh.TenNganhHang = txt_TenNganhH.Text;
        }
        private void frmNganhHang_Load(object sender, EventArgs e)
        {
            dgv_NganhHang.DataSource = bllNganhHang.GetListNganhHang();
        }
        private void dgv_NganhHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txt_MaNganhH.Text = dgv_NganhHang.Rows[row].Cells["MaNganhHang"].ToString();
            txt_TenNganhH.Text = dgv_NganhHang.Rows[row].Cells["TenNganhHang"].ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string select = "";
            if(txt_MaNganhH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã ngành hàng!", "Thông báo");
                txt_MaNganhH.Focus();
            }
            else
            {
                if(txt_TenNganhH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhạp tên ngành hàng!", "Thông báo");
                    txt_TenNganhH.Focus();
                }
                else
                {
                    select = "select * from NganhHang where MaNganhHang='" + txt_MaNganhH.Text + "'";
                    if(da.CheckKey(select))
                    {
                        MessageBox.Show("Mã ngành hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaNganhH.Focus();
                    }
                    else
                    {
                        GetDataNganhHang();
                        bllNganhHang.Insert(ngh);
                        dgv_NganhHang.DataSource = bllNganhHang.GetListNganhHang();
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            GetDataNganhHang();
            bllNganhHang.Update(ngh);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            dgv_NganhHang.DataSource = bllNganhHang.GetListNganhHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            GetDataNganhHang();
            if (result == DialogResult.Yes)
            {
                bllNganhHang.Delete(ngh);
                dgv_NganhHang.DataSource = bllNganhHang.GetListNganhHang();
            }
            else
            {
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            GetDataNganhHang();
            if (txt_MaNganhH.Text == "" && txt_TenNganhH.Text == "")
                dgv_NganhHang.DataSource = bllNganhHang.GetListNganhHang();
            else
                dgv_NganhHang.DataSource = bllNganhHang.Search(ngh);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaNganhH.Text = "";
            txt_TenNganhH.Text = "";
        }
    }
}
