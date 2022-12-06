namespace QLBanHangDB.Forms
{
    partial class frmCapNhatPhieuNhap
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
            this.grb_ListHangNhap = new System.Windows.Forms.GroupBox();
            this.btn_XoaCTPN = new System.Windows.Forms.Button();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.dgv_HangNhap = new System.Windows.Forms.DataGridView();
            this.btn_SavePrint = new System.Windows.Forms.Button();
            this.txt_TongTienNhap = new System.Windows.Forms.TextBox();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_NgayNhap = new System.Windows.Forms.Label();
            this.txt_MaPN = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.cmb_NhanVien = new System.Windows.Forms.ComboBox();
            this.lbl_NhaCC = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_NgayNhap = new System.Windows.Forms.TextBox();
            this.txt_NhaCC = new System.Windows.Forms.TextBox();
            this.lbl_MaNhaCC = new System.Windows.Forms.Label();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.grb_PhieuNhap = new System.Windows.Forms.GroupBox();
            this.lbl_MaPN = new System.Windows.Forms.Label();
            this.lbl_MaHang = new System.Windows.Forms.Label();
            this.cmb_MaHang = new System.Windows.Forms.ComboBox();
            this.lbl_GiaNhap = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_ChietKhau = new System.Windows.Forms.Label();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_ChietKhau = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.lbl_TenHang = new System.Windows.Forms.Label();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.lbl_DVT = new System.Windows.Forms.Label();
            this.txt_DVT = new System.Windows.Forms.TextBox();
            this.grb_HangNhap = new System.Windows.Forms.GroupBox();
            this.grb_ListHangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangNhap)).BeginInit();
            this.grb_PhieuNhap.SuspendLayout();
            this.grb_HangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_ListHangNhap
            // 
            this.grb_ListHangNhap.Controls.Add(this.btn_XoaCTPN);
            this.grb_ListHangNhap.Controls.Add(this.btn_TroVe);
            this.grb_ListHangNhap.Controls.Add(this.dgv_HangNhap);
            this.grb_ListHangNhap.Controls.Add(this.btn_SavePrint);
            this.grb_ListHangNhap.Controls.Add(this.txt_TongTienNhap);
            this.grb_ListHangNhap.Controls.Add(this.lbl_TongTien);
            this.grb_ListHangNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListHangNhap.Location = new System.Drawing.Point(432, 265);
            this.grb_ListHangNhap.Name = "grb_ListHangNhap";
            this.grb_ListHangNhap.Size = new System.Drawing.Size(755, 434);
            this.grb_ListHangNhap.TabIndex = 5;
            this.grb_ListHangNhap.TabStop = false;
            this.grb_ListHangNhap.Text = "Danh sách hàng nhập";
            // 
            // btn_XoaCTPN
            // 
            this.btn_XoaCTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaCTPN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaCTPN.Location = new System.Drawing.Point(145, 365);
            this.btn_XoaCTPN.Name = "btn_XoaCTPN";
            this.btn_XoaCTPN.Size = new System.Drawing.Size(94, 39);
            this.btn_XoaCTPN.TabIndex = 52;
            this.btn_XoaCTPN.Text = "Delete";
            this.btn_XoaCTPN.UseVisualStyleBackColor = true;
            this.btn_XoaCTPN.Click += new System.EventHandler(this.btn_XoaCTPN_Click);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe.Location = new System.Drawing.Point(260, 365);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(94, 40);
            this.btn_TroVe.TabIndex = 51;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // dgv_HangNhap
            // 
            this.dgv_HangNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_HangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HangNhap.Location = new System.Drawing.Point(0, 26);
            this.dgv_HangNhap.Name = "dgv_HangNhap";
            this.dgv_HangNhap.RowHeadersWidth = 51;
            this.dgv_HangNhap.RowTemplate.Height = 24;
            this.dgv_HangNhap.Size = new System.Drawing.Size(755, 305);
            this.dgv_HangNhap.TabIndex = 50;
            this.dgv_HangNhap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HangNhap_RowEnter);
            // 
            // btn_SavePrint
            // 
            this.btn_SavePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SavePrint.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SavePrint.Location = new System.Drawing.Point(30, 365);
            this.btn_SavePrint.Name = "btn_SavePrint";
            this.btn_SavePrint.Size = new System.Drawing.Size(98, 39);
            this.btn_SavePrint.TabIndex = 49;
            this.btn_SavePrint.Text = "Lưu";
            this.btn_SavePrint.UseVisualStyleBackColor = true;
            this.btn_SavePrint.Click += new System.EventHandler(this.btn_SavePrint_Click);
            // 
            // txt_TongTienNhap
            // 
            this.txt_TongTienNhap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_TongTienNhap.Enabled = false;
            this.txt_TongTienNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTienNhap.Location = new System.Drawing.Point(577, 369);
            this.txt_TongTienNhap.Name = "txt_TongTienNhap";
            this.txt_TongTienNhap.Size = new System.Drawing.Size(149, 32);
            this.txt_TongTienNhap.TabIndex = 48;
            this.txt_TongTienNhap.Text = "0";
            this.txt_TongTienNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.Location = new System.Drawing.Point(398, 371);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(162, 24);
            this.lbl_TongTien.TabIndex = 47;
            this.lbl_TongTien.Text = "Tổng tiền nhập";
            // 
            // lbl_NgayNhap
            // 
            this.lbl_NgayNhap.AutoSize = true;
            this.lbl_NgayNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayNhap.Location = new System.Drawing.Point(52, 109);
            this.lbl_NgayNhap.Name = "lbl_NgayNhap";
            this.lbl_NgayNhap.Size = new System.Drawing.Size(79, 18);
            this.lbl_NgayNhap.TabIndex = 20;
            this.lbl_NgayNhap.Text = "Ngày nhập";
            // 
            // txt_MaPN
            // 
            this.txt_MaPN.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_MaPN.Enabled = false;
            this.txt_MaPN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPN.Location = new System.Drawing.Point(205, 25);
            this.txt_MaPN.Name = "txt_MaPN";
            this.txt_MaPN.Size = new System.Drawing.Size(149, 26);
            this.txt_MaPN.TabIndex = 21;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(488, 67);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(50, 18);
            this.lbl_DiaChi.TabIndex = 25;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_DiaChi.Enabled = false;
            this.txt_DiaChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(619, 65);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(472, 26);
            this.txt_DiaChi.TabIndex = 26;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(488, 110);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(92, 18);
            this.lbl_SDT.TabIndex = 27;
            this.lbl_SDT.Text = "Số điện thoại";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_SDT.Enabled = false;
            this.txt_SDT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(619, 108);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(165, 26);
            this.txt_SDT.TabIndex = 28;
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.Location = new System.Drawing.Point(52, 158);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(73, 18);
            this.lbl_MaNV.TabIndex = 30;
            this.lbl_MaNV.Text = "Nhân viên";
            // 
            // cmb_NhanVien
            // 
            this.cmb_NhanVien.FormattingEnabled = true;
            this.cmb_NhanVien.Location = new System.Drawing.Point(205, 149);
            this.cmb_NhanVien.Name = "cmb_NhanVien";
            this.cmb_NhanVien.Size = new System.Drawing.Size(186, 26);
            this.cmb_NhanVien.TabIndex = 31;
            // 
            // lbl_NhaCC
            // 
            this.lbl_NhaCC.AutoSize = true;
            this.lbl_NhaCC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhaCC.Location = new System.Drawing.Point(488, 28);
            this.lbl_NhaCC.Name = "lbl_NhaCC";
            this.lbl_NhaCC.Size = new System.Drawing.Size(98, 18);
            this.lbl_NhaCC.TabIndex = 32;
            this.lbl_NhaCC.Text = "Nhà cung cấp";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(488, 157);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(41, 18);
            this.lbl_Email.TabIndex = 34;
            this.lbl_Email.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Email.Enabled = false;
            this.txt_Email.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(619, 155);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(291, 26);
            this.txt_Email.TabIndex = 35;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_NgayNhap
            // 
            this.txt_NgayNhap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_NgayNhap.Enabled = false;
            this.txt_NgayNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayNhap.Location = new System.Drawing.Point(205, 107);
            this.txt_NgayNhap.Name = "txt_NgayNhap";
            this.txt_NgayNhap.Size = new System.Drawing.Size(149, 26);
            this.txt_NgayNhap.TabIndex = 36;
            // 
            // txt_NhaCC
            // 
            this.txt_NhaCC.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_NhaCC.Enabled = false;
            this.txt_NhaCC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhaCC.Location = new System.Drawing.Point(619, 25);
            this.txt_NhaCC.Name = "txt_NhaCC";
            this.txt_NhaCC.Size = new System.Drawing.Size(345, 26);
            this.txt_NhaCC.TabIndex = 37;
            // 
            // lbl_MaNhaCC
            // 
            this.lbl_MaNhaCC.AutoSize = true;
            this.lbl_MaNhaCC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNhaCC.Location = new System.Drawing.Point(52, 68);
            this.lbl_MaNhaCC.Name = "lbl_MaNhaCC";
            this.lbl_MaNhaCC.Size = new System.Drawing.Size(121, 18);
            this.lbl_MaNhaCC.TabIndex = 38;
            this.lbl_MaNhaCC.Text = "Mã nhà cung cấp";
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_MaNCC.Enabled = false;
            this.txt_MaNCC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNCC.Location = new System.Drawing.Point(205, 63);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(149, 26);
            this.txt_MaNCC.TabIndex = 39;
            this.txt_MaNCC.TextChanged += new System.EventHandler(this.txt_NhaCC_TextChanged);
            // 
            // grb_PhieuNhap
            // 
            this.grb_PhieuNhap.Controls.Add(this.txt_MaNCC);
            this.grb_PhieuNhap.Controls.Add(this.lbl_MaNhaCC);
            this.grb_PhieuNhap.Controls.Add(this.txt_NhaCC);
            this.grb_PhieuNhap.Controls.Add(this.txt_NgayNhap);
            this.grb_PhieuNhap.Controls.Add(this.txt_Email);
            this.grb_PhieuNhap.Controls.Add(this.lbl_Email);
            this.grb_PhieuNhap.Controls.Add(this.lbl_NhaCC);
            this.grb_PhieuNhap.Controls.Add(this.cmb_NhanVien);
            this.grb_PhieuNhap.Controls.Add(this.lbl_MaNV);
            this.grb_PhieuNhap.Controls.Add(this.txt_SDT);
            this.grb_PhieuNhap.Controls.Add(this.lbl_SDT);
            this.grb_PhieuNhap.Controls.Add(this.txt_DiaChi);
            this.grb_PhieuNhap.Controls.Add(this.lbl_DiaChi);
            this.grb_PhieuNhap.Controls.Add(this.txt_MaPN);
            this.grb_PhieuNhap.Controls.Add(this.lbl_NgayNhap);
            this.grb_PhieuNhap.Controls.Add(this.lbl_MaPN);
            this.grb_PhieuNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_PhieuNhap.Location = new System.Drawing.Point(12, 58);
            this.grb_PhieuNhap.Name = "grb_PhieuNhap";
            this.grb_PhieuNhap.Size = new System.Drawing.Size(1175, 201);
            this.grb_PhieuNhap.TabIndex = 3;
            this.grb_PhieuNhap.TabStop = false;
            this.grb_PhieuNhap.Text = "Thông tin phiếu nhập";
            this.grb_PhieuNhap.Enter += new System.EventHandler(this.grb_PhieuNhap_Enter);
            // 
            // lbl_MaPN
            // 
            this.lbl_MaPN.AutoSize = true;
            this.lbl_MaPN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaPN.Location = new System.Drawing.Point(52, 33);
            this.lbl_MaPN.Name = "lbl_MaPN";
            this.lbl_MaPN.Size = new System.Drawing.Size(104, 18);
            this.lbl_MaPN.TabIndex = 19;
            this.lbl_MaPN.Text = "Mã phiếu nhập";
            // 
            // lbl_MaHang
            // 
            this.lbl_MaHang.AutoSize = true;
            this.lbl_MaHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHang.Location = new System.Drawing.Point(20, 29);
            this.lbl_MaHang.Name = "lbl_MaHang";
            this.lbl_MaHang.Size = new System.Drawing.Size(65, 18);
            this.lbl_MaHang.TabIndex = 36;
            this.lbl_MaHang.Text = "Mã hàng";
            // 
            // cmb_MaHang
            // 
            this.cmb_MaHang.FormattingEnabled = true;
            this.cmb_MaHang.Location = new System.Drawing.Point(138, 26);
            this.cmb_MaHang.Name = "cmb_MaHang";
            this.cmb_MaHang.Size = new System.Drawing.Size(185, 26);
            this.cmb_MaHang.TabIndex = 36;
            this.cmb_MaHang.TextChanged += new System.EventHandler(this.cmb_MaHang_TextChanged);
            // 
            // lbl_GiaNhap
            // 
            this.lbl_GiaNhap.AutoSize = true;
            this.lbl_GiaNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaNhap.Location = new System.Drawing.Point(20, 145);
            this.lbl_GiaNhap.Name = "lbl_GiaNhap";
            this.lbl_GiaNhap.Size = new System.Drawing.Size(65, 18);
            this.lbl_GiaNhap.TabIndex = 37;
            this.lbl_GiaNhap.Text = "Giá nhập";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(20, 185);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 18);
            this.lbl_SoLuong.TabIndex = 38;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // lbl_ChietKhau
            // 
            this.lbl_ChietKhau.AutoSize = true;
            this.lbl_ChietKhau.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChietKhau.Location = new System.Drawing.Point(20, 232);
            this.lbl_ChietKhau.Name = "lbl_ChietKhau";
            this.lbl_ChietKhau.Size = new System.Drawing.Size(108, 18);
            this.lbl_ChietKhau.TabIndex = 39;
            this.lbl_ChietKhau.Text = "Chiết khấu (%)";
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GiaNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaNhap.Location = new System.Drawing.Point(138, 143);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(149, 26);
            this.txt_GiaNhap.TabIndex = 36;
            this.txt_GiaNhap.Leave += new System.EventHandler(this.txt_GiaNhap_Leave);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(139, 183);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(106, 26);
            this.txt_SoLuong.TabIndex = 40;
            this.txt_SoLuong.Leave += new System.EventHandler(this.txt_SoLuong_Leave);
            // 
            // txt_ChietKhau
            // 
            this.txt_ChietKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ChietKhau.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChietKhau.Location = new System.Drawing.Point(139, 230);
            this.txt_ChietKhau.Name = "txt_ChietKhau";
            this.txt_ChietKhau.Size = new System.Drawing.Size(74, 26);
            this.txt_ChietKhau.TabIndex = 41;
            this.txt_ChietKhau.TextChanged += new System.EventHandler(this.txt_ChietKhau_TextChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(23, 292);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(83, 42);
            this.btn_Them.TabIndex = 42;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(112, 292);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(84, 42);
            this.btn_Sua.TabIndex = 43;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(205, 292);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 42);
            this.btn_Xoa.TabIndex = 44;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(36, 375);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(101, 21);
            this.lbl_ThanhTien.TabIndex = 45;
            this.lbl_ThanhTien.Text = "Thành tiền";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(294, 292);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(86, 42);
            this.btn_Refresh.TabIndex = 24;
            this.btn_Refresh.Text = "Clear";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(167, 373);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(149, 28);
            this.txt_ThanhTien.TabIndex = 46;
            this.txt_ThanhTien.Text = "0";
            this.txt_ThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_TenHang
            // 
            this.lbl_TenHang.AutoSize = true;
            this.lbl_TenHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenHang.Location = new System.Drawing.Point(20, 70);
            this.lbl_TenHang.Name = "lbl_TenHang";
            this.lbl_TenHang.Size = new System.Drawing.Size(71, 18);
            this.lbl_TenHang.TabIndex = 47;
            this.lbl_TenHang.Text = "Tên hàng";
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_TenHang.Enabled = false;
            this.txt_TenHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHang.Location = new System.Drawing.Point(138, 68);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(242, 26);
            this.txt_TenHang.TabIndex = 48;
            // 
            // lbl_DVT
            // 
            this.lbl_DVT.AutoSize = true;
            this.lbl_DVT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DVT.Location = new System.Drawing.Point(20, 106);
            this.lbl_DVT.Name = "lbl_DVT";
            this.lbl_DVT.Size = new System.Drawing.Size(77, 18);
            this.lbl_DVT.TabIndex = 49;
            this.lbl_DVT.Text = "Đơn vị tính";
            // 
            // txt_DVT
            // 
            this.txt_DVT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_DVT.Enabled = false;
            this.txt_DVT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DVT.Location = new System.Drawing.Point(138, 104);
            this.txt_DVT.Name = "txt_DVT";
            this.txt_DVT.Size = new System.Drawing.Size(107, 26);
            this.txt_DVT.TabIndex = 50;
            // 
            // grb_HangNhap
            // 
            this.grb_HangNhap.Controls.Add(this.txt_DVT);
            this.grb_HangNhap.Controls.Add(this.lbl_DVT);
            this.grb_HangNhap.Controls.Add(this.txt_TenHang);
            this.grb_HangNhap.Controls.Add(this.lbl_TenHang);
            this.grb_HangNhap.Controls.Add(this.txt_ThanhTien);
            this.grb_HangNhap.Controls.Add(this.btn_Refresh);
            this.grb_HangNhap.Controls.Add(this.lbl_ThanhTien);
            this.grb_HangNhap.Controls.Add(this.btn_Xoa);
            this.grb_HangNhap.Controls.Add(this.btn_Sua);
            this.grb_HangNhap.Controls.Add(this.btn_Them);
            this.grb_HangNhap.Controls.Add(this.txt_ChietKhau);
            this.grb_HangNhap.Controls.Add(this.txt_SoLuong);
            this.grb_HangNhap.Controls.Add(this.txt_GiaNhap);
            this.grb_HangNhap.Controls.Add(this.lbl_ChietKhau);
            this.grb_HangNhap.Controls.Add(this.lbl_SoLuong);
            this.grb_HangNhap.Controls.Add(this.lbl_GiaNhap);
            this.grb_HangNhap.Controls.Add(this.cmb_MaHang);
            this.grb_HangNhap.Controls.Add(this.lbl_MaHang);
            this.grb_HangNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_HangNhap.Location = new System.Drawing.Point(12, 265);
            this.grb_HangNhap.Name = "grb_HangNhap";
            this.grb_HangNhap.Size = new System.Drawing.Size(403, 434);
            this.grb_HangNhap.TabIndex = 4;
            this.grb_HangNhap.TabStop = false;
            this.grb_HangNhap.Text = "Thông tin hàng nhập";
            // 
            // frmCapNhatPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.grb_ListHangNhap);
            this.Controls.Add(this.grb_HangNhap);
            this.Controls.Add(this.grb_PhieuNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCapNhatPhieuNhap";
            this.Text = "CẬP NHẬT PHIẾU NHẬP";
            this.Load += new System.EventHandler(this.frmCapNhatPhieuNhap_Load);
            this.grb_ListHangNhap.ResumeLayout(false);
            this.grb_ListHangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangNhap)).EndInit();
            this.grb_PhieuNhap.ResumeLayout(false);
            this.grb_PhieuNhap.PerformLayout();
            this.grb_HangNhap.ResumeLayout(false);
            this.grb_HangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ListHangNhap;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.DataGridView dgv_HangNhap;
        private System.Windows.Forms.Button btn_SavePrint;
        private System.Windows.Forms.TextBox txt_TongTienNhap;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Button btn_XoaCTPN;
        private System.Windows.Forms.Label lbl_NgayNhap;
        private System.Windows.Forms.TextBox txt_MaPN;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.ComboBox cmb_NhanVien;
        private System.Windows.Forms.Label lbl_NhaCC;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_NgayNhap;
        private System.Windows.Forms.TextBox txt_NhaCC;
        private System.Windows.Forms.Label lbl_MaNhaCC;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.GroupBox grb_PhieuNhap;
        private System.Windows.Forms.Label lbl_MaPN;
        private System.Windows.Forms.Label lbl_MaHang;
        private System.Windows.Forms.ComboBox cmb_MaHang;
        private System.Windows.Forms.Label lbl_GiaNhap;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_ChietKhau;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_ChietKhau;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label lbl_TenHang;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.Label lbl_DVT;
        private System.Windows.Forms.TextBox txt_DVT;
        private System.Windows.Forms.GroupBox grb_HangNhap;
    }
}