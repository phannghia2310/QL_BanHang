namespace QLBanHangDB.Forms
{
    partial class frmDMNhanVien
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.grb_ListNV = new System.Windows.Forms.GroupBox();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_TenNV = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_MaCV = new System.Windows.Forms.Label();
            this.cmb_MaCV = new System.Windows.Forms.ComboBox();
            this.lbl_MaQL = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.grb_NhanVien = new System.Windows.Forms.GroupBox();
            this.txt_MaQL = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.grb_ListNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.grb_NhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(602, 652);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 39);
            this.btn_Xoa.TabIndex = 18;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(440, 652);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 39);
            this.btn_Sua.TabIndex = 17;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(279, 652);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 39);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // grb_ListNV
            // 
            this.grb_ListNV.Controls.Add(this.dgv_NhanVien);
            this.grb_ListNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListNV.Location = new System.Drawing.Point(91, 345);
            this.grb_ListNV.Name = "grb_ListNV";
            this.grb_ListNV.Size = new System.Drawing.Size(1000, 279);
            this.grb_ListNV.TabIndex = 15;
            this.grb_ListNV.TabStop = false;
            this.grb_ListNV.Text = "Danh sách nhân viên";
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 22);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1000, 257);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_RowEnter);
            // 
            // btn_Excel
            // 
            this.btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.Location = new System.Drawing.Point(761, 652);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(122, 39);
            this.btn_Excel.TabIndex = 19;
            this.btn_Excel.Text = "Xuất Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.Location = new System.Drawing.Point(55, 38);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(96, 18);
            this.lbl_MaNV.TabIndex = 0;
            this.lbl_MaNV.Text = "Mã nhân viên";
            // 
            // lbl_TenNV
            // 
            this.lbl_TenNV.AutoSize = true;
            this.lbl_TenNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNV.Location = new System.Drawing.Point(55, 77);
            this.lbl_TenNV.Name = "lbl_TenNV";
            this.lbl_TenNV.Size = new System.Drawing.Size(102, 18);
            this.lbl_TenNV.TabIndex = 1;
            this.lbl_TenNV.Text = "Tên nhân viên";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV.Location = new System.Drawing.Point(172, 75);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(230, 26);
            this.txt_TenNV.TabIndex = 3;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(837, 61);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(102, 34);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(837, 134);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(102, 34);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_MaCV
            // 
            this.lbl_MaCV.AutoSize = true;
            this.lbl_MaCV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaCV.Location = new System.Drawing.Point(465, 38);
            this.lbl_MaCV.Name = "lbl_MaCV";
            this.lbl_MaCV.Size = new System.Drawing.Size(62, 18);
            this.lbl_MaCV.TabIndex = 6;
            this.lbl_MaCV.Text = "Chức vụ";
            // 
            // cmb_MaCV
            // 
            this.cmb_MaCV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmb_MaCV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_MaCV.FormattingEnabled = true;
            this.cmb_MaCV.Location = new System.Drawing.Point(568, 35);
            this.cmb_MaCV.Name = "cmb_MaCV";
            this.cmb_MaCV.Size = new System.Drawing.Size(207, 26);
            this.cmb_MaCV.TabIndex = 7;
            this.cmb_MaCV.SelectedIndexChanged += new System.EventHandler(this.cmb_MaCV_SelectedIndexChanged);
            // 
            // lbl_MaQL
            // 
            this.lbl_MaQL.AutoSize = true;
            this.lbl_MaQL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaQL.Location = new System.Drawing.Point(465, 77);
            this.lbl_MaQL.Name = "lbl_MaQL";
            this.lbl_MaQL.Size = new System.Drawing.Size(80, 18);
            this.lbl_MaQL.TabIndex = 8;
            this.lbl_MaQL.Text = "Mã quản lý";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(465, 122);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(58, 18);
            this.lbl_GioiTinh.TabIndex = 10;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(55, 122);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(72, 18);
            this.lbl_NgaySinh.TabIndex = 13;
            this.lbl_NgaySinh.Text = "Ngày sinh";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtp_NgaySinh.CustomFormat = "mm/dd/yyyy";
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(172, 116);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(132, 26);
            this.dtp_NgaySinh.TabIndex = 14;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(55, 166);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(50, 18);
            this.lbl_DiaChi.TabIndex = 15;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(172, 164);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(417, 26);
            this.txt_DiaChi.TabIndex = 16;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(55, 209);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(92, 18);
            this.lbl_SDT.TabIndex = 17;
            this.lbl_SDT.Text = "Số điện thoại";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(172, 209);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(178, 26);
            this.txt_SDT.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(316, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "mm/dd/yyyy";
            // 
            // cmb_GioiTinh
            // 
            this.cmb_GioiTinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmb_GioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_GioiTinh.FormattingEnabled = true;
            this.cmb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmb_GioiTinh.Location = new System.Drawing.Point(568, 116);
            this.cmb_GioiTinh.Name = "cmb_GioiTinh";
            this.cmb_GioiTinh.Size = new System.Drawing.Size(94, 26);
            this.cmb_GioiTinh.TabIndex = 21;
            // 
            // grb_NhanVien
            // 
            this.grb_NhanVien.Controls.Add(this.txt_MaQL);
            this.grb_NhanVien.Controls.Add(this.cmb_GioiTinh);
            this.grb_NhanVien.Controls.Add(this.label1);
            this.grb_NhanVien.Controls.Add(this.txt_SDT);
            this.grb_NhanVien.Controls.Add(this.lbl_SDT);
            this.grb_NhanVien.Controls.Add(this.txt_DiaChi);
            this.grb_NhanVien.Controls.Add(this.lbl_DiaChi);
            this.grb_NhanVien.Controls.Add(this.dtp_NgaySinh);
            this.grb_NhanVien.Controls.Add(this.lbl_NgaySinh);
            this.grb_NhanVien.Controls.Add(this.lbl_GioiTinh);
            this.grb_NhanVien.Controls.Add(this.lbl_MaQL);
            this.grb_NhanVien.Controls.Add(this.cmb_MaCV);
            this.grb_NhanVien.Controls.Add(this.lbl_MaCV);
            this.grb_NhanVien.Controls.Add(this.btn_Refresh);
            this.grb_NhanVien.Controls.Add(this.btn_TimKiem);
            this.grb_NhanVien.Controls.Add(this.txt_TenNV);
            this.grb_NhanVien.Controls.Add(this.txt_MaNV);
            this.grb_NhanVien.Controls.Add(this.lbl_TenNV);
            this.grb_NhanVien.Controls.Add(this.lbl_MaNV);
            this.grb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_NhanVien.Location = new System.Drawing.Point(91, 59);
            this.grb_NhanVien.Name = "grb_NhanVien";
            this.grb_NhanVien.Size = new System.Drawing.Size(1000, 258);
            this.grb_NhanVien.TabIndex = 14;
            this.grb_NhanVien.TabStop = false;
            this.grb_NhanVien.Text = "Thông tin nhân viên";
            // 
            // txt_MaQL
            // 
            this.txt_MaQL.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_MaQL.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_MaQL.Enabled = false;
            this.txt_MaQL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaQL.ForeColor = System.Drawing.Color.Black;
            this.txt_MaQL.Location = new System.Drawing.Point(568, 75);
            this.txt_MaQL.Name = "txt_MaQL";
            this.txt_MaQL.Size = new System.Drawing.Size(131, 28);
            this.txt_MaQL.TabIndex = 22;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(174, 36);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(167, 26);
            this.txt_MaNV.TabIndex = 2;
            // 
            // frmDMNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grb_ListNV);
            this.Controls.Add(this.grb_NhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDMNhanVien";
            this.Text = "DANH MỤC NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frmDMNhanVien_Load);
            this.grb_ListNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.grb_NhanVien.ResumeLayout(false);
            this.grb_NhanVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox grb_ListNV;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_TenNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_MaCV;
        private System.Windows.Forms.ComboBox cmb_MaCV;
        private System.Windows.Forms.Label lbl_MaQL;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_GioiTinh;
        private System.Windows.Forms.GroupBox grb_NhanVien;
        private System.Windows.Forms.TextBox txt_MaQL;
        private System.Windows.Forms.TextBox txt_MaNV;
    }
}