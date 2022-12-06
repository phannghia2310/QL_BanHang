namespace QLBanHangDB.Forms
{
    partial class frmTimKiemPN
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
            this.grb_TieuChi = new System.Windows.Forms.GroupBox();
            this.cmb_MaNV = new System.Windows.Forms.ComboBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.cmb_NhaCC = new System.Windows.Forms.ComboBox();
            this.cmb_MaPN = new System.Windows.Forms.ComboBox();
            this.dtp_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_To = new System.Windows.Forms.Label();
            this.dtp_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.rdb_NhanVien = new System.Windows.Forms.RadioButton();
            this.rdb_NhaCC = new System.Windows.Forms.RadioButton();
            this.rdb_MaPN = new System.Windows.Forms.RadioButton();
            this.rdb_Ngay = new System.Windows.Forms.RadioButton();
            this.grb_ListPhieuNhap = new System.Windows.Forms.GroupBox();
            this.dgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.grb_ChiTietPN = new System.Windows.Forms.GroupBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_ChiTietPN = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_TieuChi.SuspendLayout();
            this.grb_ListPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPN)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_TieuChi
            // 
            this.grb_TieuChi.Controls.Add(this.cmb_MaNV);
            this.grb_TieuChi.Controls.Add(this.txt_SDT);
            this.grb_TieuChi.Controls.Add(this.lbl_SDT);
            this.grb_TieuChi.Controls.Add(this.txt_DiaChi);
            this.grb_TieuChi.Controls.Add(this.lbl_DiaChi);
            this.grb_TieuChi.Controls.Add(this.cmb_NhaCC);
            this.grb_TieuChi.Controls.Add(this.cmb_MaPN);
            this.grb_TieuChi.Controls.Add(this.dtp_DateTo);
            this.grb_TieuChi.Controls.Add(this.lbl_To);
            this.grb_TieuChi.Controls.Add(this.dtp_DateFrom);
            this.grb_TieuChi.Controls.Add(this.rdb_NhanVien);
            this.grb_TieuChi.Controls.Add(this.rdb_NhaCC);
            this.grb_TieuChi.Controls.Add(this.rdb_MaPN);
            this.grb_TieuChi.Controls.Add(this.rdb_Ngay);
            this.grb_TieuChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TieuChi.Location = new System.Drawing.Point(132, 22);
            this.grb_TieuChi.Name = "grb_TieuChi";
            this.grb_TieuChi.Size = new System.Drawing.Size(907, 234);
            this.grb_TieuChi.TabIndex = 0;
            this.grb_TieuChi.TabStop = false;
            this.grb_TieuChi.Text = "Tiêu chí tìm kiếm";
            // 
            // cmb_MaNV
            // 
            this.cmb_MaNV.FormattingEnabled = true;
            this.cmb_MaNV.Location = new System.Drawing.Point(204, 186);
            this.cmb_MaNV.Name = "cmb_MaNV";
            this.cmb_MaNV.Size = new System.Drawing.Size(193, 26);
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
            this.txt_DiaChi.Size = new System.Drawing.Size(639, 26);
            this.txt_DiaChi.TabIndex = 20;
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
            // cmb_NhaCC
            // 
            this.cmb_NhaCC.FormattingEnabled = true;
            this.cmb_NhaCC.Location = new System.Drawing.Point(204, 105);
            this.cmb_NhaCC.Name = "cmb_NhaCC";
            this.cmb_NhaCC.Size = new System.Drawing.Size(290, 26);
            this.cmb_NhaCC.TabIndex = 8;
            this.cmb_NhaCC.SelectedIndexChanged += new System.EventHandler(this.cmb_NhaCC_SelectedIndexChanged);
            // 
            // cmb_MaPN
            // 
            this.cmb_MaPN.FormattingEnabled = true;
            this.cmb_MaPN.Location = new System.Drawing.Point(204, 67);
            this.cmb_MaPN.Name = "cmb_MaPN";
            this.cmb_MaPN.Size = new System.Drawing.Size(127, 26);
            this.cmb_MaPN.TabIndex = 7;
            // 
            // dtp_DateTo
            // 
            this.dtp_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateTo.Location = new System.Drawing.Point(407, 25);
            this.dtp_DateTo.Name = "dtp_DateTo";
            this.dtp_DateTo.Size = new System.Drawing.Size(127, 26);
            this.dtp_DateTo.TabIndex = 6;
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(358, 28);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(26, 18);
            this.lbl_To.TabIndex = 5;
            this.lbl_To.Text = "To";
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
            // rdb_NhaCC
            // 
            this.rdb_NhaCC.AutoSize = true;
            this.rdb_NhaCC.Location = new System.Drawing.Point(67, 105);
            this.rdb_NhaCC.Name = "rdb_NhaCC";
            this.rdb_NhaCC.Size = new System.Drawing.Size(119, 22);
            this.rdb_NhaCC.TabIndex = 2;
            this.rdb_NhaCC.TabStop = true;
            this.rdb_NhaCC.Text = "Nhà cung cấp";
            this.rdb_NhaCC.UseVisualStyleBackColor = true;
            // 
            // rdb_MaPN
            // 
            this.rdb_MaPN.AutoSize = true;
            this.rdb_MaPN.Location = new System.Drawing.Point(67, 67);
            this.rdb_MaPN.Name = "rdb_MaPN";
            this.rdb_MaPN.Size = new System.Drawing.Size(125, 22);
            this.rdb_MaPN.TabIndex = 1;
            this.rdb_MaPN.TabStop = true;
            this.rdb_MaPN.Text = "Mã phiếu nhập";
            this.rdb_MaPN.UseVisualStyleBackColor = true;
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
            // grb_ListPhieuNhap
            // 
            this.grb_ListPhieuNhap.Controls.Add(this.dgv_PhieuNhap);
            this.grb_ListPhieuNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListPhieuNhap.Location = new System.Drawing.Point(132, 262);
            this.grb_ListPhieuNhap.Name = "grb_ListPhieuNhap";
            this.grb_ListPhieuNhap.Size = new System.Drawing.Size(907, 201);
            this.grb_ListPhieuNhap.TabIndex = 1;
            this.grb_ListPhieuNhap.TabStop = false;
            this.grb_ListPhieuNhap.Text = "Danh sách phiếu nhập";
            // 
            // dgv_PhieuNhap
            // 
            this.dgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NgayNhap,
            this.MaPN,
            this.MaNCC,
            this.MaNV,
            this.TongTienNhap});
            this.dgv_PhieuNhap.Location = new System.Drawing.Point(0, 26);
            this.dgv_PhieuNhap.Name = "dgv_PhieuNhap";
            this.dgv_PhieuNhap.RowHeadersWidth = 51;
            this.dgv_PhieuNhap.RowTemplate.Height = 24;
            this.dgv_PhieuNhap.Size = new System.Drawing.Size(907, 175);
            this.dgv_PhieuNhap.TabIndex = 0;
            this.dgv_PhieuNhap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuNhap_RowEnter);
            // 
            // grb_ChiTietPN
            // 
            this.grb_ChiTietPN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ChiTietPN.Location = new System.Drawing.Point(132, 469);
            this.grb_ChiTietPN.Name = "grb_ChiTietPN";
            this.grb_ChiTietPN.Size = new System.Drawing.Size(907, 198);
            this.grb_ChiTietPN.TabIndex = 2;
            this.grb_ChiTietPN.TabStop = false;
            this.grb_ChiTietPN.Text = "Chi tiết phiếu nhập";
            // 
            // btn_Return
            // 
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(651, 688);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(97, 39);
            this.btn_Return.TabIndex = 29;
            this.btn_Return.Text = "Trở về";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(513, 688);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(98, 39);
            this.btn_Update.TabIndex = 27;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(378, 688);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(98, 39);
            this.btn_TimKiem.TabIndex = 26;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dgv_ChiTietPN
            // 
            this.dgv_ChiTietPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.MaHang,
            this.TenHang,
            this.GiaNhap,
            this.SoLuong,
            this.DVT,
            this.ChietKhau,
            this.ThanhTien});
            this.dgv_ChiTietPN.Location = new System.Drawing.Point(132, 495);
            this.dgv_ChiTietPN.Name = "dgv_ChiTietPN";
            this.dgv_ChiTietPN.RowHeadersWidth = 51;
            this.dgv_ChiTietPN.RowTemplate.Height = 24;
            this.dgv_ChiTietPN.Size = new System.Drawing.Size(907, 172);
            this.dgv_ChiTietPN.TabIndex = 0;
            this.dgv_ChiTietPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietPN_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 142;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 143;
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "MaPN";
            this.MaPN.HeaderText = "Mã phiếu nhập";
            this.MaPN.MinimumWidth = 6;
            this.MaPN.Name = "MaPN";
            this.MaPN.Width = 145;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà CC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 142;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 143;
            // 
            // TongTienNhap
            // 
            this.TongTienNhap.DataPropertyName = "TongTienNhap";
            this.TongTienNhap.HeaderText = "Tổng tiền nhập";
            this.TongTienNhap.MinimumWidth = 6;
            this.TongTienNhap.Name = "TongTienNhap";
            this.TongTienNhap.Width = 142;
            // 
            // STT1
            // 
            this.STT1.HeaderText = "STT";
            this.STT1.MinimumWidth = 6;
            this.STT1.Name = "STT1";
            this.STT1.Width = 107;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 107;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 106;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 107;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 107;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.Width = 107;
            // 
            // ChietKhau
            // 
            this.ChietKhau.DataPropertyName = "ChietKhau";
            this.ChietKhau.HeaderText = "Chiết khấu";
            this.ChietKhau.MinimumWidth = 6;
            this.ChietKhau.Name = "ChietKhau";
            this.ChietKhau.Width = 106;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 107;
            // 
            // frmTimKiemPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.dgv_ChiTietPN);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.grb_ChiTietPN);
            this.Controls.Add(this.grb_ListPhieuNhap);
            this.Controls.Add(this.grb_TieuChi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM PHIẾU NHẬP";
            this.Load += new System.EventHandler(this.frmTimKemPN_Load);
            this.grb_TieuChi.ResumeLayout(false);
            this.grb_TieuChi.PerformLayout();
            this.grb_ListPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_TieuChi;
        private System.Windows.Forms.ComboBox cmb_NhaCC;
        private System.Windows.Forms.ComboBox cmb_MaPN;
        private System.Windows.Forms.DateTimePicker dtp_DateTo;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.DateTimePicker dtp_DateFrom;
        private System.Windows.Forms.RadioButton rdb_NhanVien;
        private System.Windows.Forms.RadioButton rdb_NhaCC;
        private System.Windows.Forms.RadioButton rdb_MaPN;
        private System.Windows.Forms.RadioButton rdb_Ngay;
        private System.Windows.Forms.GroupBox grb_ListPhieuNhap;
        private System.Windows.Forms.GroupBox grb_ChiTietPN;
        private System.Windows.Forms.ComboBox cmb_MaNV;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.DataGridView dgv_PhieuNhap;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_ChiTietPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChietKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}