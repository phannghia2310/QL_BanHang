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

namespace QLBanHangDB
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        QuyenDangNhapBLL bllUser = new QuyenDangNhapBLL();

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agree_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập của bạn.", "Thông báo");
                txt_Username.Focus();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txt_OldPass.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu cũ của bạn.", "Thông báo");
                    txt_OldPass.Focus();
                }
                else
                {
                    if(string.IsNullOrWhiteSpace(txt_NewPass.Text))
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới của bạn.", "Thông báo");
                        txt_NewPass.Focus();
                    }
                    else
                    {
                        if(string.IsNullOrWhiteSpace(txt_ReWrite.Text))
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu mới của bạn.", "Thông báo");
                            txt_ReWrite.Focus();
                        }
                        else
                        {
                            if(txt_ReWrite.Text != txt_NewPass.Text)
                            {
                                MessageBox.Show("Bạn nhập lại không đúng.", "Thông báo");
                                txt_ReWrite.Text = "";
                                txt_ReWrite.Focus();
                            }
                            else
                            {
                                if(txt_Username.Text != UserLogin.TenDangNhap && txt_OldPass.Text != UserLogin.MatKhau)
                                {
                                    MessageBox.Show("Xin lỗi, Yêu cầu của bạn không được thực thi.\nBạn đã nhập sai tài khoản đăng nhập. ");
                                    txt_Username.Text = "";
                                    txt_OldPass.Text = "";
                                    txt_NewPass.Text = "";
                                    txt_ReWrite.Text = "";
                                    txt_Username.Focus();
                                }
                                else
                                {
                                    bllUser.ChangePassword(txt_NewPass.Text);
                                    MessageBox.Show("Bạn đã đổi mật khẩu thành công.", "Thông báo");
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
