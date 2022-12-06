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
using QLBanHangDB.BusinessLayer;
using System.Data.SqlClient;
using QLBanHangDB.DataLayer;

namespace QLBanHangDB
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static string username = "";
        public static string password = "";
        QuyenDangNhapBLL bllUser = new QuyenDangNhapBLL();

        private void frmLogin_Load(object sender, EventArgs e)
        {

            //hide password
            this.txt_Password.UseSystemPasswordChar = true;
        }

        private void txt_Username_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
        }

        private void txt_PassWord_Click(object sender, EventArgs e)
        {
            txt_Password.Clear();
        }

        private void chk_PasswordHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_PasswordHide.Checked)
            {
                this.txt_Password.UseSystemPasswordChar = false;
            }
            else
                this.txt_Password.UseSystemPasswordChar = true;
        }

        private void icon_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            username = txt_Username.Text;
            password = txt_Password.Text;
            QuyenDangNhap us = new QuyenDangNhap();
            us.TenDangNhap = txt_Username.Text;
            us.MatKhau = txt_Password.Text;
            if(bllUser.ExistUser(us) == true)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công!");
                this.Hide();
                frmMain f = new frmMain();
                f.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tên đăng nhập hoặc mật khẩu!\n Mời bạn đăng nhập lại");
            }
        }
    }
}
