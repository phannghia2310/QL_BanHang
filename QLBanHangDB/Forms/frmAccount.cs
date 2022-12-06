using QLBanHangDB.BusinessLayer;
using System;
using System.Windows.Forms;
using QLBanHangDB.Entities;

namespace QLBanHangDB.Forms
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        QuyenDangNhapBLL bllUser = new QuyenDangNhapBLL();
        QuyenDangNhap user = new QuyenDangNhap();
        ChucVuBLL bllChucVu = new ChucVuBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();

        private void GetData()
        {
            user.TenDangNhap = txt_Username.Text;
            user.MatKhau = txt_Password.Text;
            user.MaNV = cmb_MaNV.Text;
            user.MaCV = cmb_MaCV.Text;
        }

        private void GetUser()
        {
            dgv_Account.DataSource = bllUser.GetListUser();
        }
        private void frmAccount_Load(object sender, EventArgs e)
        {
            //Get data for cmb_MaNV
            cmb_MaNV.DataSource = bllNhanVien.GetListNhanVien();
            cmb_MaNV.DisplayMember = "MaNV";
            cmb_MaNV.ValueMember = "MaNV";
            cmb_MaNV.AutoCompleteSource = AutoCompleteSource.ListItems;
            //Get data for cmb_MaCV
            cmb_MaCV.DataSource = bllChucVu.GetListChucVu();
            cmb_MaCV.DisplayMember = "MaCV";
            cmb_MaCV.ValueMember = "MaCV";
            cmb_MaCV.AutoCompleteSource = AutoCompleteSource.ListItems;
            //Load GridView
            GetUser();
        }
        private void cmb_MaNV_Leave(object sender, EventArgs e)
        {
            if(bllNhanVien.GetNhanVienById(cmb_MaNV.Text).Rows.Count == 0)
            {
                MessageBox.Show(" Không tôn tại nhân viên có mã:  " + cmb_MaNV.Text + " trong csdl", "Thông báo");
                cmb_MaNV.Text = "";
            }
        }
        private void cmb_MaCV_Leave(object sender, EventArgs e)
        {
            if(bllChucVu.GetChucVuById(cmb_MaCV.Text).Rows.Count == 0)
            {
                MessageBox.Show(" Không tôn tại chức vụ có mã:  " + cmb_MaCV.Text + " trong csdl", "Thông báo");
                cmb_MaCV.Text = "";
            }
        }
        private void dgv_Account_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = e.RowIndex;
            txt_Username.Text = dgv_Account.Rows[row].Cells["TenDangNhap"].Value.ToString();
            txt_Password.Text = dgv_Account.Rows[row].Cells["MatKhau"].Value.ToString();
            cmb_MaNV.Text = dgv_Account.Rows[row].Cells["MaNV"].Value.ToString();
            cmb_MaCV.Text = dgv_Account.Rows[row].Cells["MaCV"].Value.ToString();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
            cmb_MaNV.Text = "";
            cmb_MaCV.Text = "";
            txt_Username.Focus();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_Username.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản.", "Thông báo");
                txt_Username.Focus();
            }
            else
            {
                if(bllUser.ExistUser(txt_Username.Text) == true)
                {
                    MessageBox.Show("Tài khoản: " + txt_Username.Text + " đã được sử dụng.\nBạn phải chọn tên đăng nhập khác", "Thông báo");
                    txt_Username.Text = "";
                    txt_Username.Focus();
                }
                else
                {
                    if(txt_Password.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu.", "Thông báo");
                        txt_Password.Focus();
                    }
                    else
                    {
                        if(cmb_MaNV.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập mã nhân viên.", "Thông báo");
                            cmb_MaNV.Focus();
                        }
                        else
                        {
                            if(cmb_MaCV.Text == "")
                            {
                                MessageBox.Show("Bạn chưa chọn mã chức vụ.", "Thông báo");
                                cmb_MaCV.Focus();
                            }
                            else
                            {
                                GetData();
                                bllUser.Insert(user);
                                GetUser();
                            }
                        }
                    }
                }
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(txt_Username.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập cần sửa.", "Thông báo");
                txt_Username.Focus();
            }
            else
            {
                GetData();
                bllUser.Update(user);
                GetUser();
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập cần xóa.", "Thông báo");
                txt_Username.Focus();
            }
            else
            {
                GetData();
                bllUser.Delete(user);
                GetUser();
            }
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            GetData();
            if (txt_Username.Text == "" && txt_Password.Text == "" && cmb_MaNV.Text == "" && cmb_MaCV.Text == "")
                GetUser();
            else
                dgv_Account.DataSource = bllUser.Search(user, txt_Username.Text, txt_Password.Text, cmb_MaNV.Text, cmb_MaCV.Text);
        }




        private void grb_Account_Enter(object sender, EventArgs e)
        {

        }

    }
}
