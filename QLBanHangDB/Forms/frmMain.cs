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
using QLBanHangDB.Forms;

namespace QLBanHangDB
{
    public partial class frmMain : Form
    {
        QuyenDangNhap us = new QuyenDangNhap();
        QuyenDangNhapBLL bllUser = new QuyenDangNhapBLL();
        public frmMain()
        {
            InitializeComponent();
            customizeDesign();
            time_DateTime.Start();
        }

        private void customizeDesign()
        {
            panel_SubSetting.Visible = false;
            panel_SubList.Visible = false;
            panel_SubEmployee.Visible = false;
            panel_SubProduct.Visible = false;
            panel_SubImEx.Visible = false;
            panel_SubFind.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panel_SubSetting.Visible == true)
                panel_SubSetting.Visible = false;
            if (panel_SubList.Visible == true)
            {
                panel_SubEmployee.Visible = false;
                panel_SubList.Visible = false;
                panel_SubProduct.Visible = false;
            }
            if (panel_SubImEx.Visible == true)
                panel_SubImEx.Visible = false;
            if (panel_SubFind.Visible == true)
                panel_SubFind.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = frmLogin.username;
            lbl_TitleBar.Text = "HOME";
            if (SqlHelper.MaCV == 2)
            {
                this.btn_Account.Enabled = false;
                this.btn_ListCustomer.Enabled = false;
                this.btn_Bill.Enabled = false;
                this.btn_FindBill.Enabled = false;
            }
            if (SqlHelper.MaCV == 3)
            {
                this.btn_Account.Enabled = false;
                this.btn_ListSupplier.Enabled = false;
                this.btn_Import.Enabled = false;
                this.btn_FindImport.Enabled = false;
            }
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SubSetting);
        }
        private void btn_ChangePWD_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhau());
            HideSubMenu();
        }
        private void btn_Account_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmAccount());
            HideSubMenu();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SubList);
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SubEmployee);
        }
        private void btn_ListPart_Click(object sender, EventArgs e)
        {

        }

        private void btn_ListPosition_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmDMChucVu());
            HideSubMenu();
        }

        private void btn_ListEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDMNhanVien());
            HideSubMenu();
        }
        private void btn_ListCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDMKhachHang());
            HideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDMNhaCC());
            HideSubMenu();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SubProduct);
        }
        private void btn_ListIndustry_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmNganhHang());
            HideSubMenu();
        }

        private void btn_GroupPro_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmNhomHang());
            HideSubMenu();
        }

        private void btn_ListManufacturer_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmHangSX());
            HideSubMenu();
        }

        private void btn_ListProduct_Click_2(object sender, EventArgs e)
        {
            openChildForm(new frmHangHoa());
            HideSubMenu();
        }
        private void btn_ImEx_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SubImEx);
        }
        private void btn_Import_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuNhap(this));
            HideSubMenu();
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDon(this));
            HideSubMenu();
        }
        private void btn_FindImport_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTimKiemPN(this));
            HideSubMenu();
        }

        private void btn_FindBill_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTimKiemHD(this));
            HideSubMenu();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SubFind);
        }
        private void btn_Report_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDashBoard());
        }
        private void btn_ReportSell_Click(object sender, EventArgs e)
        {
        }
        private void btn_SellByEmployee_Click(object sender, EventArgs e)
        {
            /*code*/
            HideSubMenu();
        }

        private void btn_SellByMonth_Click(object sender, EventArgs e)
        {
            /*code*/
            HideSubMenu();
        }

        private void btn_SellByDay_Click(object sender, EventArgs e)
        {
            /*code*/
            HideSubMenu();
        }
        private void btn_ReportImport_Click(object sender, EventArgs e)
        {

        }

        private void btn_ImportByDay_Click(object sender, EventArgs e)
        {
            /*code*/
            HideSubMenu();
        }

        private void btn_ImportByMonth_Click(object sender, EventArgs e)
        {
            /*code*/
            HideSubMenu();
        }
        private void btn_inventory_Click(object sender, EventArgs e)
        {
        }
        private void btn_InventoryByImport_Click(object sender, EventArgs e)
        {
            /*code*/
            HideSubMenu();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void time_DateTime_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbNgayThangBig.Text = datetime.ToString("dd/MM/yyyy");
            this.labelGioBig.Text = datetime.ToString("HH:mm:ss");
            this.lbl_DateTime.Text = datetime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_TitleBar.Text = childForm.Text;
        }

        private void pic_Logo_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            lbl_TitleBar.Text = "HOME";
        }













        private void panel_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ListPosition_Click(object sender, EventArgs e)
        {

        }

        private void btn_Account_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel_SubReport_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ListProduct_Click(object sender, EventArgs e)
        {

        }

        private void btn_ListIndustry_Click(object sender, EventArgs e)
        {

        }

        private void btn_GroupPro_Click(object sender, EventArgs e)
        {

        }

        private void btn_ListManufacturer_Click(object sender, EventArgs e)
        {

        }

        private void btn_ListProduct_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_TitleBar_Click(object sender, EventArgs e)
        {

        }

        private void panel_SubReport_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_ReportBussiness_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReportProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
