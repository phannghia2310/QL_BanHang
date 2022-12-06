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
    public partial class frmNhomHang : Form
    {
        public frmNhomHang()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        NhomHang nh;
        NhomHangBLL bllNhomHang = new NhomHangBLL();
        NganhHangBLL bllNganhHang = new NganhHangBLL();

        private void GetDataNhomHang()
        {
            nh = new NhomHang();
            nh.MaNhomHang = txt_MaNhomH.Text;
            nh.MaNganhHang = cmb_MaNganhH.SelectedValue.ToString();
            nh.TenNhomHang = txt_TenNhomH.Text;
        }
        private void frmNhomHang_Load(object sender, EventArgs e)
        {
            dgv_NhomHang.DataSource = bllNhomHang.GetListNhomHang();
            cmb_MaNganhH.DataSource = bllNganhHang.GetListNganhHang();
            cmb_MaNganhH.DisplayMember = "TenNganhHang";
            cmb_MaNganhH.ValueMember = "MaNganhHang";
        }
        private void dgv_NhomHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txt_MaNhomH.Text = dgv_NhomHang.Rows[row].Cells["MaNhomHang"].Value.ToString();
            txt_TenNhomH.Text = dgv_NhomHang.Rows[row].Cells["TenNhomHang"].Value.ToString();
            cmb_MaNganhH.Text = dgv_NhomHang.Rows[row].Cells["TenNganhHang"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string select = "";
            if(txt_MaNhomH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhóm hàng!", "Thông báo");
                txt_MaNhomH.Focus();
            }
            else
            {
                if(txt_TenNhomH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhóm hàng!", "Thông báo");
                    txt_TenNhomH.Focus();
                }
                else
                {
                    select = "Select NhomHang.MaNhomHang, NhomHang.TenNhomHang, NganhHang.TenNganhHang from NhomHang,NganhHang" +
                                " where NhomHang.MaNganhHang=NganhHang.MaNganhHang and NhomHang.MaNhomHang='" + txt_MaNhomH.Text + "'";
                    if(da.CheckKey(select))
                    {
                        MessageBox.Show("Mã nhóm hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaNhomH.Focus();
                    }
                    else
                    {
                        GetDataNhomHang();
                        bllNhomHang.Insert(nh);
                        dgv_NhomHang.DataSource = bllNhomHang.GetListNhomHang();
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            GetDataNhomHang();
            bllNhomHang.Update(nh);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            dgv_NhomHang.DataSource = bllNhomHang.GetListNhomHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            GetDataNhomHang();
            if (result == DialogResult.Yes)
            {
                bllNhomHang.Delete(nh);
                dgv_NhomHang.DataSource = bllNhomHang.GetListNhomHang();
            }
            else
            {
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            GetDataNhomHang();
            if (txt_MaNhomH.Text == "" && txt_TenNhomH.Text == "" && cmb_MaNganhH.Text == "")
                dgv_NhomHang.DataSource = bllNhomHang.GetListNhomHang();
            else
                dgv_NhomHang.DataSource = bllNhomHang.Search(nh);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaNhomH.Text = "";
            txt_TenNhomH.Text = "";
            cmb_MaNganhH.Text = "";
        }
    }
}
