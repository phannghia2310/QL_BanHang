namespace QLBanHangDB.Forms
{
    partial class frmTimKiemHD
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
            this.dgv_ChiTietHD = new System.Windows.Forms.DataGridView();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grb_ChiTietHD = new System.Windows.Forms.GroupBox();
            this.grb_ListHoaDon = new System.Windows.Forms.GroupBox();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.grb_TieuChi = new System.Windows.Forms.GroupBox();
            this.cmb_MaNV = new System.Windows.Forms.ComboBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.cmb_KhachHang = new System.Windows.Forms.ComboBox();
            this.cmb_MaHD = new System.Windows.Forms.ComboBox();
            this.dtp_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_To = new System.Windows.Forms.Label();
            this.dtp_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.rdb_NhanVien = new System.Windows.Forms.RadioButton();
            this.rdb_KhachHang = new System.Windows.Forms.RadioButton();
            this.rdb_MaHD = new System.Windows.Forms.RadioButton();
            this.rdb_Ngay = new System.Windows.Forms.RadioButton();
            this.TongTienHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).BeginInit();
            this.grb_ListHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.grb_TieuChi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ChiTietHD
            // 
            this.dgv_ChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.MaHang,
            this.TenHang,
            this.GiaBan,
            this.SoLuong,
            this.DVT,
            this.VAT,
            this.ThanhTien});
            this.dgv_ChiTietHD.Location = new System.Drawing.Point(133, 494);
            this.dgv_ChiTietHD.Name = "dgv_ChiTietHD";
            this.dgv_ChiTietHD.RowHeadersWidth = 51;
            this.dgv_ChiTietHD.RowTemplate.Height = 24;
            this.dgv_ChiTietHD.Size = new System.Drawing.Size(907, 172);
            this.dgv_ChiTietHD.TabIndex = 30;
            // 
            // btn_Return
            // 
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(673, 688);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(100, 39);
            this.btn_Return.TabIndex = 37;
            this.btn_Return.Text = "Trở về";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(510, 688);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(98, 39);
            this.btn_Update.TabIndex = 35;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(349, 688);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(98, 39);
            this.btn_TimKiem.TabIndex = 34;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // grb_ChiTietHD
            // 
            this.grb_ChiTietHD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ChiTietHD.Location = new System.Drawing.Point(133, 468);
            this.grb_ChiTietHD.Name = "grb_ChiTietHD";
            this.grb_ChiTietHD.Size = new System.Drawing.Size(907, 198);
            this.grb_ChiTietHD.TabIndex = 33;
            this.grb_ChiTietHD.TabStop = false;
            this.grb_ChiTietHD.Text = "Chi tiết hóa đơn";
            // 
            // grb_ListHoaDon
            // 
            this.grb_ListHoaDon.Controls.Add(this.dgv_HoaDon);
            this.grb_ListHoaDon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListHoaDon.Location = new System.Drawing.Point(133, 261);
            this.grb_ListHoaDon.Name = "grb_ListHoaDon";
            this.grb_ListHoaDon.Size = new System.Drawing.Size(907, 201);
            this.grb_ListHoaDon.TabIndex = 32;
            this.grb_ListHoaDon.TabStop = false;
            this.grb_ListHoaDon.Text = "Danh sách hóa đơn";
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NgayBan,
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.TongTienHD});
            this.dgv_HoaDon.Location = new System.Drawing.Point(0, 26);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(907, 175);
            this.dgv_HoaDon.TabIndex = 0;
            this.dgv_HoaDon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_RowEnter);
            // 
            // grb_TieuChi
            // 
            this.grb_TieuChi.Controls.Add(this.cmb_MaNV);
            this.grb_TieuChi.Controls.Add(this.txt_SDT);
            this.grb_TieuChi.Controls.Add(this.lbl_SDT);
            this.grb_TieuChi.Controls.Add(this.txt_DiaChi);
            this.grb_TieuChi.Controls.Add(this.lbl_DiaChi);
            this.grb_TieuChi.Controls.Add(this.cmb_KhachHang);
            this.grb_TieuChi.Controls.Add(this.cmb_MaHD);
            this.grb_TieuChi.Controls.Add(this.dtp_DateTo);
            this.grb_TieuChi.Controls.Add(this.lbl_To);
            this.grb_TieuChi.Controls.Add(this.dtp_DateFrom);
            this.grb_TieuChi.Controls.Add(this.rdb_NhanVien);
            this.grb_TieuChi.Controls.Add(this.rdb_KhachHang);
            this.grb_TieuChi.Controls.Add(this.rdb_MaHD);
            this.grb_TieuChi.Controls.Add(this.rdb_Ngay);
            this.grb_TieuChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TieuChi.Location = new System.Drawing.Point(133, 21);
            this.grb_TieuChi.Name = "grb_TieuChi";
            this.grb_TieuChi.Size = new System.Drawing.Size(907, 234);
            this.grb_TieuChi.TabIndex = 31;
            this.grb_TieuChi.TabStop = false;
            this.grb_TieuChi.Text = "Tiêu chí tìm kiếm";
            // 
            // cmb_MaNV
            // 
            this.cmb_MaNV.FormattingEnabled = true;
            this.cmb_MaNV.Location = new System.Drawing.Point(204, 186);
            this.cmb_MaNV.Name = "cmb_MaNV";
            this.cmb_MaNV.Size = new System.Drawing.Size(127, 26);
            this.cmb_MaNV.TabIndex = 23;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_SDT.Enabled = false;
            this.txt_SDT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(665, 107);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(178, 26);
            this.txt_SDT.TabIndex = 22;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(537, 109);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(92, 18);
            this.lbl_SDT.TabIndex = 21;
            this.lbl_SDT.Text = "Số điện thoại";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_DiaChi.Enabled = false;
            this.txt_DiaChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(204, 142);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(417, 26);
            this.txt_DiaChi.TabIndex = 20;
            this.txt_DiaChi.TextChanged += new System.EventHandler(this.txt_DiaChi_TextChanged);
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(136, 144);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(50, 18);
            this.lbl_DiaChi.TabIndex = 19;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // cmb_KhachHang
            // 
            this.cmb_KhachHang.FormattingEnabled = true;
            this.cmb_KhachHang.Location = new System.Drawing.Point(204, 105);
            this.cmb_KhachHang.Name = "cmb_KhachHang";
            this.cmb_KhachHang.Size = new System.Drawing.Size(290, 26);
            this.cmb_KhachHang.TabIndex = 8;
            this.cmb_KhachHang.SelectedIndexChanged += new System.EventHandler(this.cmb_KhachHang_SelectedIndexChanged);
            // 
            // cmb_MaHD
            // 
            this.cmb_MaHD.FormattingEnabled = true;
            this.cmb_MaHD.Location = new System.Drawing.Point(204, 67);
            this.cmb_MaHD.Name = "cmb_MaHD";
            this.cmb_MaHD.Size = new System.Drawing.Size(127, 26);
            this.cmb_MaHD.TabIndex = 7;
            // 
            // dtp_DateTo
            // 
            this.dtp_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateTo.Location = new System.Drawing.Point(420, 25);
            this.dtp_DateTo.Name = "dtp_DateTo";
            this.dtp_DateTo.Size = new System.Drawing.Size(127, 26);
            this.dtp_DateTo.TabIndex = 6;
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(358, 28);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(34, 18);
            this.lbl_To.TabIndex = 5;
            this.lbl_To.Text = "Đến";
            // 
            // dtp_DateFrom
            // 
            this.dtp_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateFrom.Location = new System.Drawing.Point(204, 25);
            this.dtp_DateFrom.Name = "dtp_DateFrom";
            this.dtp_DateFrom.Size = new System.Drawing.Size(127, 26);
            this.dtp_DateFrom.TabIndex = 4;
            // 
            // rdb_NhanVien
            // 
            this.rdb_NhanVien.AutoSize = true;
            this.rdb_NhanVien.Location = new System.Drawing.Point(67, 190);
            this.rdb_NhanVien.Name = "rdb_NhanVien";
            this.rdb_NhanVien.Size = new System.Drawing.Size(94, 22);
            this.rdb_NhanVien.TabIndex = 3;
            this.rdb_NhanVien.TabStop = true;
            this.rdb_NhanVien.Text = "Nhân viên";
            this.rdb_NhanVien.UseVisualStyleBackColor = true;
            // 
            // rdb_KhachHang
            // 
            this.rdb_KhachHang.AutoSize = true;
            this.rdb_KhachHang.Location = new System.Drawing.Point(67, 105);
            this.rdb_KhachHang.Name = "rdb_KhachHang";
            this.rdb_KhachHang.Size = new System.Drawing.Size(106, 22);
            this.rdb_KhachHang.TabIndex = 2;
            this.rdb_KhachHang.TabStop = true;
            this.rdb_KhachHang.Text = "Khách hàng";
            this.rdb_KhachHang.UseVisualStyleBackColor = true;
            // 
            // rdb_MaHD
            // 
            this.rdb_MaHD.AutoSize = true;
            this.rdb_MaHD.Location = new System.Drawing.Point(67, 67);
            this.rdb_MaHD.Name = "rdb_MaHD";
            this.rdb_MaHD.Size = new System.Drawing.Size(108, 22);
            this.rdb_MaHD.TabIndex = 1;
            this.rdb_MaHD.TabStop = true;
            this.rdb_MaHD.Text = "Mã hóa đơn";
            this.rdb_MaHD.UseVisualStyleBackColor = true;
            // 
            // rdb_Ngay
            // 
            this.rdb_Ngay.AutoSize = true;
            this.rdb_Ngay.Location = new System.Drawing.Point(67, 26);
            this.rdb_Ngay.Name = "rdb_Ngay";
            this.rdb_Ngay.Size = new System.Drawing.Size(63, 22);
            this.rdb_Ngay.TabIndex = 0;
            this.rdb_Ngay.TabStop = true;
            this.rdb_Ngay.Text = "Ngày";
            this.rdb_Ngay.UseVisualStyleBackColor = true;
            // 
            // TongTienHD
            // 
            this.TongTienHD.DataPropertyName = "TongTienHD";
            this.TongTienHD.HeaderText = "Tổng tiền HĐ";
            this.TongTienHD.MinimumWidth = 6;
            this.TongTienHD.Name = "TongTienHD";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.MinimumWidth = 6;
            this.NgayBan.Name = "NgayBan";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // STT1
            // 
            this.STT1.HeaderText = "STT";
            this.STT1.MinimumWidth = 6;
            this.STT1.Name = "STT1";
            this.STT1.Width = 125;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 125;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 125;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.Width = 125;
            // 
            // VAT
            // 
            this.VAT.DataPropertyName = "VAT";
            this.VAT.HeaderText = "VAT";
            this.VAT.MinimumWidth = 6;
            this.VAT.Name = "VAT";
            this.VAT.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // frmTimKiemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.dgv_ChiTietHD);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.grb_ChiTietHD);
            this.Controls.Add(this.grb_ListHoaDon);
            this.Controls.Add(this.grb_TieuChi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemHD";
            this.Text = "TÌM KIẾM HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmTimKiemHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).EndInit();
            this.grb_ListHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.grb_TieuChi.ResumeLayout(false);
            this.grb_TieuChi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ChiTietHD;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox grb_ChiTietHD;
        private System.Windows.Forms.GroupBox grb_ListHoaDon;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.GroupBox grb_TieuChi;
        private System.Windows.Forms.ComboBox cmb_MaNV;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.ComboBox cmb_KhachHang;
        private System.Windows.Forms.ComboBox cmb_MaHD;
        private System.Windows.Forms.DateTimePicker dtp_DateTo;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.DateTimePicker dtp_DateFrom;
        private System.Windows.Forms.RadioButton rdb_NhanVien;
        private System.Windows.Forms.RadioButton rdb_KhachHang;
        private System.Windows.Forms.RadioButton rdb_MaHD;
        private System.Windows.Forms.RadioButton rdb_Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienHD;
    }
}