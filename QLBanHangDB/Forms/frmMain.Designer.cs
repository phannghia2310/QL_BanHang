namespace QLBanHangDB
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.panel_SubFind = new System.Windows.Forms.Panel();
            this.btn_FindBill = new System.Windows.Forms.Button();
            this.btn_FindImport = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.panel_SubImEx = new System.Windows.Forms.Panel();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_ImEx = new System.Windows.Forms.Button();
            this.panel_SubList = new System.Windows.Forms.Panel();
            this.panel_SubProduct = new System.Windows.Forms.Panel();
            this.btn_ListProduct = new System.Windows.Forms.Button();
            this.btn_ListManufacturer = new System.Windows.Forms.Button();
            this.btn_GroupPro = new System.Windows.Forms.Button();
            this.btn_ListIndustry = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_ListSupplier = new System.Windows.Forms.Button();
            this.btn_ListCustomer = new System.Windows.Forms.Button();
            this.panel_SubEmployee = new System.Windows.Forms.Panel();
            this.btn_ListEmployee = new System.Windows.Forms.Button();
            this.btn_ListPosition = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.panel_SubSetting = new System.Windows.Forms.Panel();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_ChangePWD = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TitleBar = new System.Windows.Forms.Label();
            this.time_DateTime = new System.Windows.Forms.Timer(this.components);
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.lbNgayThangBig = new System.Windows.Forms.Label();
            this.labelGioBig = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel_SubFind.SuspendLayout();
            this.panel_SubImEx.SuspendLayout();
            this.panel_SubList.SuspendLayout();
            this.panel_SubProduct.SuspendLayout();
            this.panel_SubEmployee.SuspendLayout();
            this.panel_SubSetting.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.panel_Title.SuspendLayout();
            this.panel_ChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Menu);
            this.panel1.Controls.Add(this.panel_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 1102);
            this.panel1.TabIndex = 0;
            // 
            // panel_Menu
            // 
            this.panel_Menu.AutoScroll = true;
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.panel_Menu.Controls.Add(this.btn_Exit);
            this.panel_Menu.Controls.Add(this.btn_Report);
            this.panel_Menu.Controls.Add(this.panel_SubFind);
            this.panel_Menu.Controls.Add(this.btn_TimKiem);
            this.panel_Menu.Controls.Add(this.panel_SubImEx);
            this.panel_Menu.Controls.Add(this.btn_ImEx);
            this.panel_Menu.Controls.Add(this.panel_SubList);
            this.panel_Menu.Controls.Add(this.btn_List);
            this.panel_Menu.Controls.Add(this.panel_SubSetting);
            this.panel_Menu.Controls.Add(this.btn_Setting);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(0, 100);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(301, 999);
            this.panel_Menu.TabIndex = 1;
            this.panel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Menu_Paint);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(0, 1073);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(280, 54);
            this.btn_Exit.TabIndex = 47;
            this.btn_Exit.Text = "   Thoát";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Report.FlatAppearance.BorderSize = 0;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Location = new System.Drawing.Point(0, 1019);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(280, 54);
            this.btn_Report.TabIndex = 45;
            this.btn_Report.Text = "   Báo Cáo Thống Kê";
            this.btn_Report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // panel_SubFind
            // 
            this.panel_SubFind.Controls.Add(this.btn_FindBill);
            this.panel_SubFind.Controls.Add(this.btn_FindImport);
            this.panel_SubFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SubFind.Location = new System.Drawing.Point(0, 915);
            this.panel_SubFind.Name = "panel_SubFind";
            this.panel_SubFind.Size = new System.Drawing.Size(280, 104);
            this.panel_SubFind.TabIndex = 39;
            this.panel_SubFind.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_SubReport_Paint_1);
            // 
            // btn_FindBill
            // 
            this.btn_FindBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(67)))), ((int)(((byte)(146)))));
            this.btn_FindBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FindBill.FlatAppearance.BorderSize = 0;
            this.btn_FindBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindBill.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindBill.ForeColor = System.Drawing.Color.White;
            this.btn_FindBill.Location = new System.Drawing.Point(0, 50);
            this.btn_FindBill.Name = "btn_FindBill";
            this.btn_FindBill.Size = new System.Drawing.Size(280, 50);
            this.btn_FindBill.TabIndex = 41;
            this.btn_FindBill.Text = "        Tìm kiếm hóa đơn";
            this.btn_FindBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FindBill.UseVisualStyleBackColor = false;
            this.btn_FindBill.Click += new System.EventHandler(this.btn_FindBill_Click);
            // 
            // btn_FindImport
            // 
            this.btn_FindImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(67)))), ((int)(((byte)(146)))));
            this.btn_FindImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FindImport.FlatAppearance.BorderSize = 0;
            this.btn_FindImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindImport.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindImport.ForeColor = System.Drawing.Color.White;
            this.btn_FindImport.Location = new System.Drawing.Point(0, 0);
            this.btn_FindImport.Name = "btn_FindImport";
            this.btn_FindImport.Size = new System.Drawing.Size(280, 50);
            this.btn_FindImport.TabIndex = 40;
            this.btn_FindImport.Text = "        Tìm kiếm phiếu nhập\r\n";
            this.btn_FindImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FindImport.UseVisualStyleBackColor = false;
            this.btn_FindImport.Click += new System.EventHandler(this.btn_FindImport_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TimKiem.FlatAppearance.BorderSize = 0;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(0, 861);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(280, 54);
            this.btn_TimKiem.TabIndex = 38;
            this.btn_TimKiem.Text = "   Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // panel_SubImEx
            // 
            this.panel_SubImEx.Controls.Add(this.btn_Bill);
            this.panel_SubImEx.Controls.Add(this.btn_Import);
            this.panel_SubImEx.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SubImEx.Location = new System.Drawing.Point(0, 761);
            this.panel_SubImEx.Name = "panel_SubImEx";
            this.panel_SubImEx.Size = new System.Drawing.Size(280, 100);
            this.panel_SubImEx.TabIndex = 5;
            // 
            // btn_Bill
            // 
            this.btn_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(67)))), ((int)(((byte)(146)))));
            this.btn_Bill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Bill.FlatAppearance.BorderSize = 0;
            this.btn_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bill.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill.ForeColor = System.Drawing.Color.White;
            this.btn_Bill.Location = new System.Drawing.Point(0, 50);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(280, 50);
            this.btn_Bill.TabIndex = 7;
            this.btn_Bill.Text = "        Hóa đơn bán";
            this.btn_Bill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bill.UseVisualStyleBackColor = false;
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(67)))), ((int)(((byte)(146)))));
            this.btn_Import.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Import.FlatAppearance.BorderSize = 0;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.ForeColor = System.Drawing.Color.White;
            this.btn_Import.Location = new System.Drawing.Point(0, 0);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(280, 50);
            this.btn_Import.TabIndex = 6;
            this.btn_Import.Text = "        Phiếu nhập hàng";
            this.btn_Import.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Import.UseVisualStyleBackColor = false;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_ImEx
            // 
            this.btn_ImEx.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ImEx.FlatAppearance.BorderSize = 0;
            this.btn_ImEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImEx.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImEx.ForeColor = System.Drawing.Color.White;
            this.btn_ImEx.Location = new System.Drawing.Point(0, 707);
            this.btn_ImEx.Name = "btn_ImEx";
            this.btn_ImEx.Size = new System.Drawing.Size(280, 54);
            this.btn_ImEx.TabIndex = 4;
            this.btn_ImEx.Text = "   Nhập - Xuất\r\n";
            this.btn_ImEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImEx.UseVisualStyleBackColor = true;
            this.btn_ImEx.Click += new System.EventHandler(this.btn_ImEx_Click);
            // 
            // panel_SubList
            // 
            this.panel_SubList.Controls.Add(this.panel_SubProduct);
            this.panel_SubList.Controls.Add(this.btn_Product);
            this.panel_SubList.Controls.Add(this.btn_ListSupplier);
            this.panel_SubList.Controls.Add(this.btn_ListCustomer);
            this.panel_SubList.Controls.Add(this.panel_SubEmployee);
            this.panel_SubList.Controls.Add(this.btn_Employee);
            this.panel_SubList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SubList.Location = new System.Drawing.Point(0, 206);
            this.panel_SubList.Name = "panel_SubList";
            this.panel_SubList.Size = new System.Drawing.Size(280, 501);
            this.panel_SubList.TabIndex = 3;
            this.panel_SubList.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel_SubProduct
            // 
            this.panel_SubProduct.Controls.Add(this.btn_ListProduct);
            this.panel_SubProduct.Controls.Add(this.btn_ListManufacturer);
            this.panel_SubProduct.Controls.Add(this.btn_GroupPro);
            this.panel_SubProduct.Controls.Add(this.btn_ListIndustry);
            this.panel_SubProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SubProduct.Location = new System.Drawing.Point(0, 300);
            this.panel_SubProduct.Name = "panel_SubProduct";
            this.panel_SubProduct.Size = new System.Drawing.Size(280, 198);
            this.panel_SubProduct.TabIndex = 63;
            // 
            // btn_ListProduct
            // 
            this.btn_ListProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.btn_ListProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ListProduct.FlatAppearance.BorderSize = 0;
            this.btn_ListProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListProduct.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListProduct.ForeColor = System.Drawing.Color.White;
            this.btn_ListProduct.Location = new System.Drawing.Point(0, 150);
            this.btn_ListProduct.Name = "btn_ListProduct";
            this.btn_ListProduct.Size = new System.Drawing.Size(280, 50);
            this.btn_ListProduct.TabIndex = 70;
            this.btn_ListProduct.Text = "             Danh mục mặt hàng\r\n";
            this.btn_ListProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListProduct.UseVisualStyleBackColor = false;
            this.btn_ListProduct.Click += new System.EventHandler(this.btn_ListProduct_Click_2);
            // 
            // btn_ListManufacturer
            // 
            this.btn_ListManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.btn_ListManufacturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ListManufacturer.FlatAppearance.BorderSize = 0;
            this.btn_ListManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListManufacturer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListManufacturer.ForeColor = System.Drawing.Color.White;
            this.btn_ListManufacturer.Location = new System.Drawing.Point(0, 100);
            this.btn_ListManufacturer.Name = "btn_ListManufacturer";
            this.btn_ListManufacturer.Size = new System.Drawing.Size(280, 50);
            this.btn_ListManufacturer.TabIndex = 69;
            this.btn_ListManufacturer.Text = "             Danh mục hãng sản xuất\r\n";
            this.btn_ListManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListManufacturer.UseVisualStyleBackColor = false;
            this.btn_ListManufacturer.Click += new System.EventHandler(this.btn_ListManufacturer_Click_1);
            // 
            // btn_GroupPro
            // 
            this.btn_GroupPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.btn_GroupPro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GroupPro.FlatAppearance.BorderSize = 0;
            this.btn_GroupPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GroupPro.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GroupPro.ForeColor = System.Drawing.Color.White;
            this.btn_GroupPro.Location = new System.Drawing.Point(0, 50);
            this.btn_GroupPro.Name = "btn_GroupPro";
            this.btn_GroupPro.Size = new System.Drawing.Size(280, 50);
            this.btn_GroupPro.TabIndex = 68;
            this.btn_GroupPro.Text = "             Danh mục nhóm hàng";
            this.btn_GroupPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GroupPro.UseVisualStyleBackColor = false;
            this.btn_GroupPro.Click += new System.EventHandler(this.btn_GroupPro_Click_1);
            // 
            // btn_ListIndustry
            // 
            this.btn_ListIndustry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.btn_ListIndustry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ListIndustry.FlatAppearance.BorderSize = 0;
            this.btn_ListIndustry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListIndustry.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListIndustry.ForeColor = System.Drawing.Color.White;
            this.btn_ListIndustry.Location = new System.Drawing.Point(0, 0);
            this.btn_ListIndustry.Name = "btn_ListIndustry";
            this.btn_ListIndustry.Size = new System.Drawing.Size(280, 50);
            this.btn_ListIndustry.TabIndex = 67;
            this.btn_ListIndustry.Text = "             Danh mục ngành hàng";
            this.btn_ListIndustry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListIndustry.UseVisualStyleBackColor = false;
            this.btn_ListIndustry.Click += new System.EventHandler(this.btn_ListIndustry_Click_1);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(67)))), ((int)(((byte)(146)))));
            this.btn_Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Product.FlatAppearance.BorderSize = 0;
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Product.Location = new System.Drawing.Point(0, 250);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(280, 50);
            this.btn_Product.TabIndex = 62;
            this.btn_Product.Text = "        Mặt hàng";
            this.btn_Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_ListSupplier
            // 
            this.btn_ListSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(67)))), ((int)(((byte)(146)))));
            this.btn_ListSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ListSupplier.FlatAppearance.BorderSize = 0;
            this.btn_ListSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListSupplier.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListSupplier.ForeColor = System.Drawing.Color.White;
            this.btn_ListSupplier.Location = new System.Drawing.Point(0, 200);
            this.btn_ListSupplier.Name = "btn_ListSupplier";
            this.btn_ListSupplier.Size = new System.Drawing.Size(280, 50);
            this.btn_ListSupplier.TabIndex = 61;
            this.btn_ListSupplier.Text = "        Danh mục nhà cung cấp";
            this.btn_ListSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListSupplier.UseVisualStyleBackColor = false;
            this.btn_ListSupplier.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ListCustomer
            // 
            this.btn_ListCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(67)))), ((int)(((byte)(146)))));
            this.btn_ListCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ListCustomer.FlatAppearance.BorderSize = 0;
            this.btn_ListCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListCustomer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_ListCustomer.Location = new System.Drawing.Point(0, 150);
            this.btn_ListCustomer.Name = "btn_ListCustomer";
            this.btn_ListCustomer.Size = new System.Drawing.Size(280, 50);
            this.btn_ListCustomer.TabIndex = 60;
            this.btn_ListCustomer.Text = "        Danh mục khách hàng";
            this.btn_ListCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListCustomer.UseVisualStyleBackColor = false;
            this.btn_ListCustomer.Click += new System.EventHandler(this.btn_ListCustomer_Click);
            // 
            // panel_SubEmployee
            // 
            this.panel_SubEmployee.Controls.Add(this.btn_ListEmployee);
            this.panel_SubEmployee.Controls.Add(this.btn_ListPosition);
            this.panel_SubEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SubEmployee.Location = new System.Drawing.Point(0, 50);
            this.panel_SubEmployee.Name = "panel_SubEmployee";
            this.panel_SubEmployee.Size = new System.Drawing.Size(280, 100);
            this.panel_SubEmployee.TabIndex = 40;
            // 
            // btn_ListEmployee
            // 
            this.btn_ListEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.btn_ListEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ListEmployee.FlatAppearance.BorderSize = 0;
            this.btn_ListEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListEmployee.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_ListEmployee.Location = new System.Drawing.Point(0, 50);
            this.btn_ListEmployee.Name = "btn_ListEmployee";
            this.btn_ListEmployee.Size = new System.Drawing.Size(280, 50);
            this.btn_ListEmployee.TabIndex = 52;
            this.btn_ListEmployee.Text = "             Danh mục nhân viên";
            this.btn_ListEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListEmployee.UseVisualStyleBackColor = false;
            this.btn_ListEmployee.Click += new System.EventHandler(this.btn_ListEmployee_Click);
            // 
            // btn_ListPosition
            // 
            this.btn_ListPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.btn_ListPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ListPosition.FlatAppearance.BorderSize = 0;
            this.btn_ListPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListPosition.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListPosition.ForeColor = System.Drawing.Color.White;
            this.btn_ListPosition.Location = new System.Drawing.Point(0, 0);
            this.btn_ListPosition.Name = "btn_ListPosition";
            this.btn_ListPosition.Size = new System.Drawing.Size(280, 50);
            this.btn_ListPosition.TabIndex = 51;
            this.btn_ListPosition.Text = "             Danh mục chức vụ";
            this.btn_ListPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListPosition.UseVisualStyleBackColor = false;
            this.btn_ListPosition.Click += new System.EventHandler(this.btn_ListPosition_Click_1);
            // 
            // btn_Employee
            // 
            this.btn_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(67)))), ((int)(((byte)(146)))));
            this.btn_Employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Employee.FlatAppearance.BorderSize = 0;
            this.btn_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employee.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Employee.Location = new System.Drawing.Point(0, 0);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(280, 50);
            this.btn_Employee.TabIndex = 39;
            this.btn_Employee.Text = "        Nhân viên";
            this.btn_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Employee.UseVisualStyleBackColor = false;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_List
            // 
            this.btn_List.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_List.FlatAppearance.BorderSize = 0;
            this.btn_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_List.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_List.ForeColor = System.Drawing.Color.White;
            this.btn_List.Location = new System.Drawing.Point(0, 152);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(280, 54);
            this.btn_List.TabIndex = 2;
            this.btn_List.Text = "   Danh Mục";
            this.btn_List.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // panel_SubSetting
            // 
            this.panel_SubSetting.Controls.Add(this.btn_Account);
            this.panel_SubSetting.Controls.Add(this.btn_ChangePWD);
            this.panel_SubSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SubSetting.Location = new System.Drawing.Point(0, 54);
            this.panel_SubSetting.Name = "panel_SubSetting";
            this.panel_SubSetting.Size = new System.Drawing.Size(280, 98);
            this.panel_SubSetting.TabIndex = 1;
            // 
            // btn_Account
            // 
            this.btn_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(67)))), ((int)(((byte)(146)))));
            this.btn_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Account.FlatAppearance.BorderSize = 0;
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.ForeColor = System.Drawing.Color.White;
            this.btn_Account.Location = new System.Drawing.Point(0, 50);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(280, 50);
            this.btn_Account.TabIndex = 5;
            this.btn_Account.Text = "        Quản lý tài khoản";
            this.btn_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.UseVisualStyleBackColor = false;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click_1);
            // 
            // btn_ChangePWD
            // 
            this.btn_ChangePWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(67)))), ((int)(((byte)(146)))));
            this.btn_ChangePWD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ChangePWD.FlatAppearance.BorderSize = 0;
            this.btn_ChangePWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePWD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePWD.ForeColor = System.Drawing.Color.White;
            this.btn_ChangePWD.Location = new System.Drawing.Point(0, 0);
            this.btn_ChangePWD.Name = "btn_ChangePWD";
            this.btn_ChangePWD.Size = new System.Drawing.Size(280, 50);
            this.btn_ChangePWD.TabIndex = 4;
            this.btn_ChangePWD.Text = "        Đổi mật khẩu";
            this.btn_ChangePWD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangePWD.UseVisualStyleBackColor = false;
            this.btn_ChangePWD.Click += new System.EventHandler(this.btn_ChangePWD_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setting.ForeColor = System.Drawing.Color.White;
            this.btn_Setting.Location = new System.Drawing.Point(0, 0);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(280, 54);
            this.btn_Setting.TabIndex = 0;
            this.btn_Setting.Text = "   Hệ Thống";
            this.btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.pic_Logo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(301, 100);
            this.panel_Logo.TabIndex = 0;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Logo.Image = global::QLBanHangDB.Properties.Resources.thien_nam_hoa_logo;
            this.pic_Logo.Location = new System.Drawing.Point(0, 0);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(301, 100);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 1;
            this.pic_Logo.TabStop = false;
            this.pic_Logo.Click += new System.EventHandler(this.pic_Logo_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel_Title.Controls.Add(this.lbl_DateTime);
            this.panel_Title.Controls.Add(this.lbl_Username);
            this.panel_Title.Controls.Add(this.label1);
            this.panel_Title.Controls.Add(this.lbl_TitleBar);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(301, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1199, 100);
            this.panel_Title.TabIndex = 1;
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.lbl_DateTime.Location = new System.Drawing.Point(6, 57);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(80, 24);
            this.lbl_DateTime.TabIndex = 14;
            this.lbl_DateTime.Text = "00:00:00";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.lbl_Username.Location = new System.Drawing.Point(75, 12);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(100, 24);
            this.lbl_Username.TabIndex = 13;
            this.lbl_Username.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "User: ";
            // 
            // lbl_TitleBar
            // 
            this.lbl_TitleBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TitleBar.AutoSize = true;
            this.lbl_TitleBar.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.lbl_TitleBar.Location = new System.Drawing.Point(516, 26);
            this.lbl_TitleBar.Name = "lbl_TitleBar";
            this.lbl_TitleBar.Size = new System.Drawing.Size(116, 40);
            this.lbl_TitleBar.TabIndex = 0;
            this.lbl_TitleBar.Text = "HOME";
            this.lbl_TitleBar.Click += new System.EventHandler(this.lbl_TitleBar_Click);
            // 
            // time_DateTime
            // 
            this.time_DateTime.Tick += new System.EventHandler(this.time_DateTime_Tick);
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.Controls.Add(this.lbNgayThangBig);
            this.panel_ChildForm.Controls.Add(this.labelGioBig);
            this.panel_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildForm.Location = new System.Drawing.Point(301, 100);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(1199, 1002);
            this.panel_ChildForm.TabIndex = 3;
            // 
            // lbNgayThangBig
            // 
            this.lbNgayThangBig.AutoSize = true;
            this.lbNgayThangBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThangBig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.lbNgayThangBig.Location = new System.Drawing.Point(376, 395);
            this.lbNgayThangBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayThangBig.Name = "lbNgayThangBig";
            this.lbNgayThangBig.Size = new System.Drawing.Size(445, 91);
            this.lbNgayThangBig.TabIndex = 9;
            this.lbNgayThangBig.Text = "04/07/2020";
            // 
            // labelGioBig
            // 
            this.labelGioBig.AutoSize = true;
            this.labelGioBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioBig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.labelGioBig.Location = new System.Drawing.Point(338, 200);
            this.labelGioBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGioBig.Name = "labelGioBig";
            this.labelGioBig.Size = new System.Drawing.Size(533, 135);
            this.labelGioBig.TabIndex = 8;
            this.labelGioBig.Text = "12:30:33";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1500, 1102);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel_SubFind.ResumeLayout(false);
            this.panel_SubImEx.ResumeLayout(false);
            this.panel_SubList.ResumeLayout(false);
            this.panel_SubProduct.ResumeLayout(false);
            this.panel_SubEmployee.ResumeLayout(false);
            this.panel_SubSetting.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel_ChildForm.ResumeLayout(false);
            this.panel_ChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Label lbl_TitleBar;
        private System.Windows.Forms.Timer time_DateTime;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_SubImEx;
        private System.Windows.Forms.Button btn_Bill;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_ImEx;
        private System.Windows.Forms.Panel panel_SubList;
        private System.Windows.Forms.Panel panel_SubProduct;
        private System.Windows.Forms.Button btn_ListProduct;
        private System.Windows.Forms.Button btn_ListManufacturer;
        private System.Windows.Forms.Button btn_GroupPro;
        private System.Windows.Forms.Button btn_ListIndustry;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_ListSupplier;
        private System.Windows.Forms.Button btn_ListCustomer;
        private System.Windows.Forms.Panel panel_SubEmployee;
        private System.Windows.Forms.Button btn_ListEmployee;
        private System.Windows.Forms.Button btn_ListPosition;
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Panel panel_SubSetting;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_ChangePWD;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Panel panel_SubFind;
        private System.Windows.Forms.Button btn_FindImport;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Panel panel_ChildForm;
        private System.Windows.Forms.Label lbNgayThangBig;
        private System.Windows.Forms.Label labelGioBig;
        private System.Windows.Forms.Button btn_FindBill;
        private System.Windows.Forms.Button btn_Exit;
    }
}