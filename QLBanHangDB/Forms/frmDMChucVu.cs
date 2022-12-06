using QLBanHangDB.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHangDB.Entities;
using QLBanHangDB.DataLayer;

namespace QLBanHangDB.Forms
{
    public partial class frmDMChucVu : Form
    {
        public frmDMChucVu()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        ChucVuBLL bllChucVu = new ChucVuBLL();

        private void dgv_ChucVu_RowEnter(object sender, DataGridViewCellEventArgs e) 
        {
            int row = e.RowIndex;
            txt_MaCV.Text = dgv_ChucVu.Rows[row].Cells["MaCV"].Value.ToString();
            txt_TenCV.Text = dgv_ChucVu.Rows[row].Cells["TenCV"].Value.ToString();
        }

        private void frmDMChucVu_Load(object sender, EventArgs e)
        {
            dgv_ChucVu.DataSource = bllChucVu.GetListChucVu();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string select = "";
            if(txt_MaCV.Text == null || txt_MaCV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã chức vụ!", "Thông báo");
                txt_MaCV.Focus();
            }
            else
            {
                if(txt_TenCV.Text == null || txt_TenCV.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên chức vụ!", "Thông báo");
                    txt_TenCV.Focus();
                }
                else
                {
                    select = "Select * from ChucVu where MaCV='" + txt_MaCV.Text + "'";
                    if (da.CheckKey(select))
                    {
                        MessageBox.Show("Mã chức vụ này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaCV.Focus();
                        return;
                    }
                    else
                    {
                        ChucVu cv = new ChucVu(txt_MaCV.Text, txt_TenCV.Text);
                        bllChucVu.Insert(cv);
                        dgv_ChucVu.DataSource = bllChucVu.GetListChucVu();
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu(txt_MaCV.Text, txt_TenCV.Text);
            bllChucVu.Update(cv);
            MessageBox.Show("Chỉnh sửa thành công!", "Thông báo");
            dgv_ChucVu.DataSource = bllChucVu.GetListChucVu();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            ChucVu cv = new ChucVu(txt_MaCV.Text, txt_TenCV.Text);
            if (result == DialogResult.Yes)
            {
                bllChucVu.Delete(cv);
                dgv_ChucVu.DataSource = bllChucVu.GetListChucVu();
            }
            else
            {
            }
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu(txt_MaCV.Text, txt_TenCV.Text);
            if( txt_MaCV.Text == "" && txt_TenCV.Text == "")
                dgv_ChucVu.DataSource = bllChucVu.GetListChucVu();
            else
                dgv_ChucVu.DataSource = bllChucVu.Search(cv, txt_MaCV.Text, txt_TenCV.Text);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaCV.Text = "";
            txt_TenCV.Text = "";
            txt_MaCV.Focus();
        }
    }
}
