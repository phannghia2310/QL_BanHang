namespace QLBanHangDB.Forms
{
    partial class frmCapNhatHoaDon
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
            this.grb_ListHangBan = new System.Windows.Forms.GroupBox();
            this.txt_TongTienHD = new System.Windows.Forms.TextBox();
            this.dgv_HangBan = new System.Windows.Forms.DataGridView();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.grb_HoaDon = new System.Windows.Forms.GroupBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.lel_TenKH = new System.Windows.Forms.Label();
            this.lbl_MaKH = new System.Windows.Forms.Label();
            this.cmb_NhanVien = new System.Windows.Forms.ComboBox();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.lbl_NgayBan = new System.Windows.Forms.Label();
            this.lbl_MaHD = new System.Windows.Forms.Label();
            this.txt_NgayBan = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.grb_HangBan = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_DVT = new System.Windows.Forms.TextBox();
            this.lbl_DVT = new System.Windows.Forms.Label();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.lbl_TenHang = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.txt_VAT = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.lbl_VAT = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_GiaNhap = new System.Windows.Forms.Label();
            this.cmb_MaHang = new System.Windows.Forms.ComboBox();
            this.lbl_MaHang = new System.Windows.Forms.Label();
            this.btn_XoaCTHD = new System.Windows.Forms.Button();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.grb_ListHangBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangBan)).BeginInit();
            this.grb_HoaDon.SuspendLayout();
            this.grb_HangBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_ListHangBan
            // 
            this.grb_ListHangBan.Controls.Add(this.btn_XoaCTHD);
            this.grb_ListHangBan.Controls.Add(this.btn_TroVe);
            this.grb_ListHangBan.Controls.Add(this.btn_Luu);
            this.grb_ListHangBan.Controls.Add(this.txt_TongTienHD);
            this.grb_ListHangBan.Controls.Add(this.dgv_HangBan);
            this.grb_ListHangBan.Controls.Add(this.lbl_TongTien);
            this.grb_ListHangBan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListHangBan.Location = new System.Drawing.Point(428, 250);
            this.grb_ListHangBan.Name = "grb_ListHangBan";
            this.grb_ListHangBan.Size = new System.Drawing.Size(755, 434);
            this.grb_ListHangBan.TabIndex = 8;
            this.grb_ListHangBan.TabStop = false;
            this.grb_ListHangBan.Text = "Danh sách hàng bán";
            // 
            // txt_TongTienHD
            // 
            this.txt_TongTienHD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_TongTienHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTienHD.Location = new System.Drawing.Point(571, 365);
            this.txt_TongTienHD.Name = "txt_TongTienHD";
            this.txt_TongTienHD.Size = new System.Drawing.Size(149, 32);
            this.txt_TongTienHD.TabIndex = 48;
            this.txt_TongTienHD.Text = "0";
            this.txt_TongTienHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgv_HangBan
            // 
            this.dgv_HangBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_HangBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HangBan.Location = new System.Drawing.Point(0, 26);
            this.dgv_HangBan.Name = "dgv_HangBan";
            this.dgv_HangBan.RowHeadersWidth = 51;
            this.dgv_HangBan.RowTemplate.Height = 24;
            this.dgv_HangBan.Size = new System.Drawing.Size(755, 305);
            this.dgv_HangBan.TabIndex = 0;
            this.dgv_HangBan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hangban_RowEnter);
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.Location = new System.Drawing.Point(408, 368);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(141, 24);
            this.lbl_TongTien.TabIndex = 47;
            this.lbl_TongTien.Text = "Tổng tiền HĐ";
            // 
            // grb_HoaDon
            // 
            this.grb_HoaDon.Controls.Add(this.txt_MaKH);
            this.grb_HoaDon.Controls.Add(this.txt_NgayBan);
            this.grb_HoaDon.Controls.Add(this.txt_TenKH);
            this.grb_HoaDon.Controls.Add(this.lel_TenKH);
            this.grb_HoaDon.Controls.Add(this.lbl_MaKH);
            this.grb_HoaDon.Controls.Add(this.cmb_NhanVien);
            this.grb_HoaDon.Controls.Add(this.lbl_MaNV);
            this.grb_HoaDon.Controls.Add(this.txt_SDT);
            this.grb_HoaDon.Controls.Add(this.lbl_SDT);
            this.grb_HoaDon.Controls.Add(this.txt_DiaChi);
            this.grb_HoaDon.Controls.Add(this.lbl_DiaChi);
            this.grb_HoaDon.Controls.Add(this.txt_MaHD);
            this.grb_HoaDon.Controls.Add(this.lbl_NgayBan);
            this.grb_HoaDon.Controls.Add(this.lbl_MaHD);
            this.grb_HoaDon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_HoaDon.Location = new System.Drawing.Point(15, 67);
            this.grb_HoaDon.Name = "grb_HoaDon";
            this.grb_HoaDon.Size = new System.Drawing.Size(1168, 177);
            this.grb_HoaDon.TabIndex = 6;
            this.grb_HoaDon.TabStop = false;
            this.grb_HoaDon.Text = "Thông tin hóa đơn";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_TenKH.Enabled = false;
            this.txt_TenKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(530, 72);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(222, 26);
            this.txt_TenKH.TabIndex = 35;
            // 
            // lel_TenKH
            // 
            this.lel_TenKH.AutoSize = true;
            this.lel_TenKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lel_TenKH.Location = new System.Drawing.Point(399, 74);
            this.lel_TenKH.Name = "lel_TenKH";
            this.lel_TenKH.Size = new System.Drawing.Size(114, 18);
            this.lel_TenKH.TabIndex = 34;
            this.lel_TenKH.Text = "Tên khách hàng";
            // 
            // lbl_MaKH
            // 
            this.lbl_MaKH.AutoSize = true;
            this.lbl_MaKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaKH.Location = new System.Drawing.Point(399, 35);
            this.lbl_MaKH.Name = "lbl_MaKH";
            this.lbl_MaKH.Size = new System.Drawing.Size(108, 18);
            this.lbl_MaKH.TabIndex = 32;
            this.lbl_MaKH.Text = "Mã khách hàng";
            // 
            // cmb_NhanVien
            // 
            this.cmb_NhanVien.FormattingEnabled = true;
            this.cmb_NhanVien.Location = new System.Drawing.Point(177, 116);
            this.cmb_NhanVien.Name = "cmb_NhanVien";
            this.cmb_NhanVien.Size = new System.Drawing.Size(186, 26);
            this.cmb_NhanVien.TabIndex = 31;
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.Location = new System.Drawing.Point(46, 117);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(73, 18);
            this.lbl_MaNV.TabIndex = 30;
            this.lbl_MaNV.Text = "Nhân viên";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_SDT.Enabled = false;
            this.txt_SDT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(933, 72);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(178, 26);
            this.txt_SDT.TabIndex = 28;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(802, 74);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(92, 18);
            this.lbl_SDT.TabIndex = 27;
            this.lbl_SDT.Text = "Số điện thoại";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_DiaChi.Enabled = false;
            this.txt_DiaChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(530, 114);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(417, 26);
            this.txt_DiaChi.TabIndex = 26;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(399, 116);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(50, 18);
            this.lbl_DiaChi.TabIndex = 25;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_MaHD.Enabled = false;
            this.txt_MaHD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHD.Location = new System.Drawing.Point(177, 33);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(149, 26);
            this.txt_MaHD.TabIndex = 21;
            // 
            // lbl_NgayBan
            // 
            this.lbl_NgayBan.AutoSize = true;
            this.lbl_NgayBan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayBan.Location = new System.Drawing.Point(46, 74);
            this.lbl_NgayBan.Name = "lbl_NgayBan";
            this.lbl_NgayBan.Size = new System.Drawing.Size(71, 18);
            this.lbl_NgayBan.TabIndex = 20;
            this.lbl_NgayBan.Text = "Ngày bán";
            // 
            // lbl_MaHD
            // 
            this.lbl_MaHD.AutoSize = true;
            this.lbl_MaHD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHD.Location = new System.Drawing.Point(46, 35);
            this.lbl_MaHD.Name = "lbl_MaHD";
            this.lbl_MaHD.Size = new System.Drawing.Size(87, 18);
            this.lbl_MaHD.TabIndex = 19;
            this.lbl_MaHD.Text = "Mã hóa đơn";
            // 
            // txt_NgayBan
            // 
            this.txt_NgayBan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_NgayBan.Enabled = false;
            this.txt_NgayBan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayBan.Location = new System.Drawing.Point(177, 74);
            this.txt_NgayBan.Name = "txt_NgayBan";
            this.txt_NgayBan.Size = new System.Drawing.Size(149, 26);
            this.txt_NgayBan.TabIndex = 36;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_MaKH.Enabled = false;
            this.txt_MaKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.Location = new System.Drawing.Point(530, 35);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(176, 26);
            this.txt_MaKH.TabIndex = 37;
            this.txt_MaKH.TextChanged += new System.EventHandler(this.txt_MaKH_TextChanged);
            // 
            // grb_HangBan
            // 
            this.grb_HangBan.Controls.Add(this.btn_Clear);
            this.grb_HangBan.Controls.Add(this.btn_Xoa);
            this.grb_HangBan.Controls.Add(this.btn_Sua);
            this.grb_HangBan.Controls.Add(this.btn_Them);
            this.grb_HangBan.Controls.Add(this.txt_DVT);
            this.grb_HangBan.Controls.Add(this.lbl_DVT);
            this.grb_HangBan.Controls.Add(this.txt_TenHang);
            this.grb_HangBan.Controls.Add(this.lbl_TenHang);
            this.grb_HangBan.Controls.Add(this.txt_ThanhTien);
            this.grb_HangBan.Controls.Add(this.lbl_ThanhTien);
            this.grb_HangBan.Controls.Add(this.txt_VAT);
            this.grb_HangBan.Controls.Add(this.txt_SoLuong);
            this.grb_HangBan.Controls.Add(this.txt_GiaBan);
            this.grb_HangBan.Controls.Add(this.lbl_VAT);
            this.grb_HangBan.Controls.Add(this.lbl_SoLuong);
            this.grb_HangBan.Controls.Add(this.lbl_GiaNhap);
            this.grb_HangBan.Controls.Add(this.cmb_MaHang);
            this.grb_HangBan.Controls.Add(this.lbl_MaHang);
            this.grb_HangBan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_HangBan.Location = new System.Drawing.Point(15, 250);
            this.grb_HangBan.Name = "grb_HangBan";
            this.grb_HangBan.Size = new System.Drawing.Size(403, 434);
            this.grb_HangBan.TabIndex = 50;
            this.grb_HangBan.TabStop = false;
            this.grb_HangBan.Text = "Thông tin hàng bán";
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(291, 305);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(86, 42);
            this.btn_Clear.TabIndex = 55;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(199, 305);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 42);
            this.btn_Xoa.TabIndex = 58;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(109, 305);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(84, 42);
            this.btn_Sua.TabIndex = 57;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(20, 305);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(83, 42);
            this.btn_Them.TabIndex = 56;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_DVT
            // 
            this.txt_DVT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_DVT.Enabled = false;
            this.txt_DVT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DVT.Location = new System.Drawing.Point(135, 112);
            this.txt_DVT.Name = "txt_DVT";
            this.txt_DVT.Size = new System.Drawing.Size(107, 26);
            this.txt_DVT.TabIndex = 54;
            // 
            // lbl_DVT
            // 
            this.lbl_DVT.AutoSize = true;
            this.lbl_DVT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DVT.Location = new System.Drawing.Point(17, 114);
            this.lbl_DVT.Name = "lbl_DVT";
            this.lbl_DVT.Size = new System.Drawing.Size(77, 18);
            this.lbl_DVT.TabIndex = 53;
            this.lbl_DVT.Text = "Đơn vị tính";
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_TenHang.Enabled = false;
            this.txt_TenHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHang.Location = new System.Drawing.Point(135, 76);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(242, 26);
            this.txt_TenHang.TabIndex = 52;
            // 
            // lbl_TenHang
            // 
            this.lbl_TenHang.AutoSize = true;
            this.lbl_TenHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenHang.Location = new System.Drawing.Point(17, 78);
            this.lbl_TenHang.Name = "lbl_TenHang";
            this.lbl_TenHang.Size = new System.Drawing.Size(71, 18);
            this.lbl_TenHang.TabIndex = 51;
            this.lbl_TenHang.Text = "Tên hàng";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(163, 375);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(149, 28);
            this.txt_ThanhTien.TabIndex = 46;
            this.txt_ThanhTien.Text = "0";
            this.txt_ThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(32, 377);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(101, 21);
            this.lbl_ThanhTien.TabIndex = 45;
            this.lbl_ThanhTien.Text = "Thành tiền";
            // 
            // txt_VAT
            // 
            this.txt_VAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_VAT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VAT.Location = new System.Drawing.Point(133, 248);
            this.txt_VAT.Name = "txt_VAT";
            this.txt_VAT.Size = new System.Drawing.Size(75, 26);
            this.txt_VAT.TabIndex = 41;
            this.txt_VAT.TextChanged += new System.EventHandler(this.txt_VAT_TextChanged);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(133, 203);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(109, 26);
            this.txt_SoLuong.TabIndex = 40;
            this.txt_SoLuong.Leave += new System.EventHandler(this.txt_SoLuong_Leave);
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GiaBan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaBan.Location = new System.Drawing.Point(133, 155);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(149, 26);
            this.txt_GiaBan.TabIndex = 36;
            this.txt_GiaBan.Leave += new System.EventHandler(this.txt_GiaBan_Leave);
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.AutoSize = true;
            this.lbl_VAT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VAT.Location = new System.Drawing.Point(17, 252);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(68, 18);
            this.lbl_VAT.TabIndex = 39;
            this.lbl_VAT.Text = "VAT (%)";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(17, 205);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 18);
            this.lbl_SoLuong.TabIndex = 38;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // lbl_GiaNhap
            // 
            this.lbl_GiaNhap.AutoSize = true;
            this.lbl_GiaNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaNhap.Location = new System.Drawing.Point(17, 157);
            this.lbl_GiaNhap.Name = "lbl_GiaNhap";
            this.lbl_GiaNhap.Size = new System.Drawing.Size(57, 18);
            this.lbl_GiaNhap.TabIndex = 37;
            this.lbl_GiaNhap.Text = "Giá bán";
            // 
            // cmb_MaHang
            // 
            this.cmb_MaHang.FormattingEnabled = true;
            this.cmb_MaHang.Location = new System.Drawing.Point(134, 37);
            this.cmb_MaHang.Name = "cmb_MaHang";
            this.cmb_MaHang.Size = new System.Drawing.Size(195, 26);
            this.cmb_MaHang.TabIndex = 36;
            this.cmb_MaHang.TextChanged += new System.EventHandler(this.cmb_MaHang_TextChanged);
            // 
            // lbl_MaHang
            // 
            this.lbl_MaHang.AutoSize = true;
            this.lbl_MaHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHang.Location = new System.Drawing.Point(16, 40);
            this.lbl_MaHang.Name = "lbl_MaHang";
            this.lbl_MaHang.Size = new System.Drawing.Size(65, 18);
            this.lbl_MaHang.TabIndex = 36;
            this.lbl_MaHang.Text = "Mã hàng";
            // 
            // btn_XoaCTHD
            // 
            this.btn_XoaCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaCTHD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaCTHD.Location = new System.Drawing.Point(152, 362);
            this.btn_XoaCTHD.Name = "btn_XoaCTHD";
            this.btn_XoaCTHD.Size = new System.Drawing.Size(94, 39);
            this.btn_XoaCTHD.TabIndex = 55;
            this.btn_XoaCTHD.Text = "Delete";
            this.btn_XoaCTHD.UseVisualStyleBackColor = true;
            this.btn_XoaCTHD.Click += new System.EventHandler(this.btn_XoaCTHD_Click);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe.Location = new System.Drawing.Point(267, 362);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(94, 40);
            this.btn_TroVe.TabIndex = 54;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(36, 362);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(98, 39);
            this.btn_Luu.TabIndex = 53;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // frmCapNhatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.grb_HangBan);
            this.Controls.Add(this.grb_ListHangBan);
            this.Controls.Add(this.grb_HoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCapNhatHoaDon";
            this.Text = "CẬP NHẬT HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmCapNhatHoaDon_Load);
            this.grb_ListHangBan.ResumeLayout(false);
            this.grb_ListHangBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangBan)).EndInit();
            this.grb_HoaDon.ResumeLayout(false);
            this.grb_HoaDon.PerformLayout();
            this.grb_HangBan.ResumeLayout(false);
            this.grb_HangBan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ListHangBan;
        private System.Windows.Forms.TextBox txt_TongTienHD;
        private System.Windows.Forms.DataGridView dgv_HangBan;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.GroupBox grb_HoaDon;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label lel_TenKH;
        private System.Windows.Forms.Label lbl_MaKH;
        private System.Windows.Forms.ComboBox cmb_NhanVien;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label lbl_NgayBan;
        private System.Windows.Forms.Label lbl_MaHD;
        private System.Windows.Forms.TextBox txt_NgayBan;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.GroupBox grb_HangBan;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_DVT;
        private System.Windows.Forms.Label lbl_DVT;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.Label lbl_TenHang;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.TextBox txt_VAT;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.Label lbl_VAT;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_GiaNhap;
        private System.Windows.Forms.ComboBox cmb_MaHang;
        private System.Windows.Forms.Label lbl_MaHang;
        private System.Windows.Forms.Button btn_XoaCTHD;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_Luu;
    }
}