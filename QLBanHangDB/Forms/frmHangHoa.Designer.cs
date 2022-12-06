namespace QLBanHangDB.Forms
{
    partial class frmHangHoa
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
            this.grb_ListHangHoa = new System.Windows.Forms.GroupBox();
            this.dgv_HangHoa = new System.Windows.Forms.DataGridView();
            this.grb_HangHoa = new System.Windows.Forms.GroupBox();
            this.cmb_DVT = new System.Windows.Forms.ComboBox();
            this.lbl_DVT = new System.Windows.Forms.Label();
            this.txt_VAT = new System.Windows.Forms.TextBox();
            this.lbl_VAT = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.cmb_MaHangSX = new System.Windows.Forms.ComboBox();
            this.lbl_MaHangSX = new System.Windows.Forms.Label();
            this.cmb_MaNhomHang = new System.Windows.Forms.ComboBox();
            this.lbl_MaNhomH = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.lbl_TenNganhH = new System.Windows.Forms.Label();
            this.lbl_MaHang = new System.Windows.Forms.Label();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.grb_ListHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).BeginInit();
            this.grb_HangHoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_ListHangHoa
            // 
            this.grb_ListHangHoa.Controls.Add(this.dgv_HangHoa);
            this.grb_ListHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListHangHoa.Location = new System.Drawing.Point(106, 327);
            this.grb_ListHangHoa.Name = "grb_ListHangHoa";
            this.grb_ListHangHoa.Size = new System.Drawing.Size(970, 279);
            this.grb_ListHangHoa.TabIndex = 25;
            this.grb_ListHangHoa.TabStop = false;
            this.grb_ListHangHoa.Text = "Danh sách hàng hóa";
            // 
            // dgv_HangHoa
            // 
            this.dgv_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HangHoa.Location = new System.Drawing.Point(0, 22);
            this.dgv_HangHoa.Name = "dgv_HangHoa";
            this.dgv_HangHoa.RowHeadersWidth = 51;
            this.dgv_HangHoa.RowTemplate.Height = 24;
            this.dgv_HangHoa.Size = new System.Drawing.Size(970, 257);
            this.dgv_HangHoa.TabIndex = 0;
            this.dgv_HangHoa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HangHoa_RowEnter);
            // 
            // grb_HangHoa
            // 
            this.grb_HangHoa.Controls.Add(this.cmb_DVT);
            this.grb_HangHoa.Controls.Add(this.lbl_DVT);
            this.grb_HangHoa.Controls.Add(this.txt_VAT);
            this.grb_HangHoa.Controls.Add(this.lbl_VAT);
            this.grb_HangHoa.Controls.Add(this.txt_DonGia);
            this.grb_HangHoa.Controls.Add(this.lbl_DonGia);
            this.grb_HangHoa.Controls.Add(this.cmb_MaHangSX);
            this.grb_HangHoa.Controls.Add(this.lbl_MaHangSX);
            this.grb_HangHoa.Controls.Add(this.cmb_MaNhomHang);
            this.grb_HangHoa.Controls.Add(this.lbl_MaNhomH);
            this.grb_HangHoa.Controls.Add(this.btn_Refresh);
            this.grb_HangHoa.Controls.Add(this.btn_TimKiem);
            this.grb_HangHoa.Controls.Add(this.txt_TenHang);
            this.grb_HangHoa.Controls.Add(this.txt_MaHang);
            this.grb_HangHoa.Controls.Add(this.lbl_TenNganhH);
            this.grb_HangHoa.Controls.Add(this.lbl_MaHang);
            this.grb_HangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_HangHoa.Location = new System.Drawing.Point(106, 94);
            this.grb_HangHoa.Name = "grb_HangHoa";
            this.grb_HangHoa.Size = new System.Drawing.Size(970, 204);
            this.grb_HangHoa.TabIndex = 24;
            this.grb_HangHoa.TabStop = false;
            this.grb_HangHoa.Text = "Thông tin hàng hóa";
            // 
            // cmb_DVT
            // 
            this.cmb_DVT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_DVT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DVT.FormattingEnabled = true;
            this.cmb_DVT.Items.AddRange(new object[] {
            "Cái",
            "Chiếc",
            "Hộp"});
            this.cmb_DVT.Location = new System.Drawing.Point(605, 118);
            this.cmb_DVT.Name = "cmb_DVT";
            this.cmb_DVT.Size = new System.Drawing.Size(142, 26);
            this.cmb_DVT.TabIndex = 15;
            // 
            // lbl_DVT
            // 
            this.lbl_DVT.AutoSize = true;
            this.lbl_DVT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DVT.Location = new System.Drawing.Point(447, 121);
            this.lbl_DVT.Name = "lbl_DVT";
            this.lbl_DVT.Size = new System.Drawing.Size(77, 18);
            this.lbl_DVT.TabIndex = 14;
            this.lbl_DVT.Text = "Đơn vị tính";
            // 
            // txt_VAT
            // 
            this.txt_VAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_VAT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VAT.Location = new System.Drawing.Point(168, 159);
            this.txt_VAT.Name = "txt_VAT";
            this.txt_VAT.Size = new System.Drawing.Size(96, 26);
            this.txt_VAT.TabIndex = 13;
            this.txt_VAT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.AutoSize = true;
            this.lbl_VAT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VAT.Location = new System.Drawing.Point(61, 161);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(68, 18);
            this.lbl_VAT.TabIndex = 12;
            this.lbl_VAT.Text = "VAT (%)";
            this.lbl_VAT.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonGia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(168, 119);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(157, 26);
            this.txt_DonGia.TabIndex = 11;
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.Location = new System.Drawing.Point(61, 121);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(57, 18);
            this.lbl_DonGia.TabIndex = 10;
            this.lbl_DonGia.Text = "Đơn giá";
            // 
            // cmb_MaHangSX
            // 
            this.cmb_MaHangSX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_MaHangSX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaHangSX.FormattingEnabled = true;
            this.cmb_MaHangSX.Location = new System.Drawing.Point(605, 74);
            this.cmb_MaHangSX.Name = "cmb_MaHangSX";
            this.cmb_MaHangSX.Size = new System.Drawing.Size(142, 26);
            this.cmb_MaHangSX.TabIndex = 9;
            // 
            // lbl_MaHangSX
            // 
            this.lbl_MaHangSX.AutoSize = true;
            this.lbl_MaHangSX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHangSX.Location = new System.Drawing.Point(447, 77);
            this.lbl_MaHangSX.Name = "lbl_MaHangSX";
            this.lbl_MaHangSX.Size = new System.Drawing.Size(127, 18);
            this.lbl_MaHangSX.TabIndex = 8;
            this.lbl_MaHangSX.Text = "Mã hãng sản xuất";
            // 
            // cmb_MaNhomHang
            // 
            this.cmb_MaNhomHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_MaNhomHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaNhomHang.FormattingEnabled = true;
            this.cmb_MaNhomHang.Location = new System.Drawing.Point(605, 34);
            this.cmb_MaNhomHang.Name = "cmb_MaNhomHang";
            this.cmb_MaNhomHang.Size = new System.Drawing.Size(142, 26);
            this.cmb_MaNhomHang.TabIndex = 7;
            // 
            // lbl_MaNhomH
            // 
            this.lbl_MaNhomH.AutoSize = true;
            this.lbl_MaNhomH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNhomH.Location = new System.Drawing.Point(447, 36);
            this.lbl_MaNhomH.Name = "lbl_MaNhomH";
            this.lbl_MaNhomH.Size = new System.Drawing.Size(107, 18);
            this.lbl_MaNhomH.TabIndex = 6;
            this.lbl_MaNhomH.Text = "Mã nhóm hàng";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(801, 122);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(102, 34);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(801, 61);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(102, 34);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHang.Location = new System.Drawing.Point(168, 75);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(257, 26);
            this.txt_TenHang.TabIndex = 3;
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHang.Location = new System.Drawing.Point(168, 34);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.Size = new System.Drawing.Size(157, 26);
            this.txt_MaHang.TabIndex = 2;
            // 
            // lbl_TenNganhH
            // 
            this.lbl_TenNganhH.AutoSize = true;
            this.lbl_TenNganhH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNganhH.Location = new System.Drawing.Point(61, 77);
            this.lbl_TenNganhH.Name = "lbl_TenNganhH";
            this.lbl_TenNganhH.Size = new System.Drawing.Size(71, 18);
            this.lbl_TenNganhH.TabIndex = 1;
            this.lbl_TenNganhH.Text = "Tên hàng";
            // 
            // lbl_MaHang
            // 
            this.lbl_MaHang.AutoSize = true;
            this.lbl_MaHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHang.Location = new System.Drawing.Point(61, 36);
            this.lbl_MaHang.Name = "lbl_MaHang";
            this.lbl_MaHang.Size = new System.Drawing.Size(65, 18);
            this.lbl_MaHang.TabIndex = 0;
            this.lbl_MaHang.Text = "Mã hàng";
            // 
            // btn_Excel
            // 
            this.btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.Location = new System.Drawing.Point(754, 626);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(122, 39);
            this.btn_Excel.TabIndex = 32;
            this.btn_Excel.Text = "Xuất Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(595, 626);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 39);
            this.btn_Xoa.TabIndex = 31;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(433, 626);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 39);
            this.btn_Sua.TabIndex = 30;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(272, 626);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 39);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grb_ListHangHoa);
            this.Controls.Add(this.grb_HangHoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHangHoa";
            this.Text = "DANH MỤC HÀNG HÓA";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.grb_ListHangHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).EndInit();
            this.grb_HangHoa.ResumeLayout(false);
            this.grb_HangHoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_ListHangHoa;
        private System.Windows.Forms.DataGridView dgv_HangHoa;
        private System.Windows.Forms.GroupBox grb_HangHoa;
        private System.Windows.Forms.ComboBox cmb_MaHangSX;
        private System.Windows.Forms.Label lbl_MaHangSX;
        private System.Windows.Forms.Label lbl_MaNhomH;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.Label lbl_TenNganhH;
        private System.Windows.Forms.Label lbl_MaHang;
        private System.Windows.Forms.TextBox txt_VAT;
        private System.Windows.Forms.Label lbl_VAT;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.ComboBox cmb_DVT;
        private System.Windows.Forms.Label lbl_DVT;
        private System.Windows.Forms.ComboBox cmb_MaNhomHang;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
    }
}