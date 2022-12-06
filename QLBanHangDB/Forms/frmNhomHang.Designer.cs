namespace QLBanHangDB.Forms
{
    partial class frmNhomHang
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
            this.grb_ListNhomH = new System.Windows.Forms.GroupBox();
            this.dgv_NhomHang = new System.Windows.Forms.DataGridView();
            this.grb_NhomHang = new System.Windows.Forms.GroupBox();
            this.cmb_MaNganhH = new System.Windows.Forms.ComboBox();
            this.lbl_MaNganhH = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TenNhomH = new System.Windows.Forms.TextBox();
            this.txt_MaNhomH = new System.Windows.Forms.TextBox();
            this.lbl_TenNganhH = new System.Windows.Forms.Label();
            this.lbl_MaNhomH = new System.Windows.Forms.Label();
            this.grb_ListNhomH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhomHang)).BeginInit();
            this.grb_NhomHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(690, 609);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 39);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(528, 609);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 39);
            this.btn_Sua.TabIndex = 22;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(367, 609);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 39);
            this.btn_Them.TabIndex = 21;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // grb_ListNhomH
            // 
            this.grb_ListNhomH.Controls.Add(this.dgv_NhomHang);
            this.grb_ListNhomH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListNhomH.Location = new System.Drawing.Point(159, 296);
            this.grb_ListNhomH.Name = "grb_ListNhomH";
            this.grb_ListNhomH.Size = new System.Drawing.Size(859, 279);
            this.grb_ListNhomH.TabIndex = 20;
            this.grb_ListNhomH.TabStop = false;
            this.grb_ListNhomH.Text = "Danh sách nhóm hàng";
            // 
            // dgv_NhomHang
            // 
            this.dgv_NhomHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhomHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhomHang.Location = new System.Drawing.Point(0, 23);
            this.dgv_NhomHang.Name = "dgv_NhomHang";
            this.dgv_NhomHang.RowHeadersWidth = 51;
            this.dgv_NhomHang.RowTemplate.Height = 24;
            this.dgv_NhomHang.Size = new System.Drawing.Size(859, 257);
            this.dgv_NhomHang.TabIndex = 0;
            this.dgv_NhomHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhomHang_RowEnter);
            // 
            // grb_NhomHang
            // 
            this.grb_NhomHang.Controls.Add(this.cmb_MaNganhH);
            this.grb_NhomHang.Controls.Add(this.lbl_MaNganhH);
            this.grb_NhomHang.Controls.Add(this.btn_Refresh);
            this.grb_NhomHang.Controls.Add(this.btn_TimKiem);
            this.grb_NhomHang.Controls.Add(this.txt_TenNhomH);
            this.grb_NhomHang.Controls.Add(this.txt_MaNhomH);
            this.grb_NhomHang.Controls.Add(this.lbl_TenNganhH);
            this.grb_NhomHang.Controls.Add(this.lbl_MaNhomH);
            this.grb_NhomHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_NhomHang.Location = new System.Drawing.Point(159, 116);
            this.grb_NhomHang.Name = "grb_NhomHang";
            this.grb_NhomHang.Size = new System.Drawing.Size(859, 154);
            this.grb_NhomHang.TabIndex = 19;
            this.grb_NhomHang.TabStop = false;
            this.grb_NhomHang.Text = "Thông tin nhóm hàng";
            // 
            // cmb_MaNganhH
            // 
            this.cmb_MaNganhH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_MaNganhH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaNganhH.FormattingEnabled = true;
            this.cmb_MaNganhH.Location = new System.Drawing.Point(498, 36);
            this.cmb_MaNganhH.Name = "cmb_MaNganhH";
            this.cmb_MaNganhH.Size = new System.Drawing.Size(142, 26);
            this.cmb_MaNganhH.TabIndex = 7;
            // 
            // lbl_MaNganhH
            // 
            this.lbl_MaNganhH.AutoSize = true;
            this.lbl_MaNganhH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNganhH.Location = new System.Drawing.Point(366, 36);
            this.lbl_MaNganhH.Name = "lbl_MaNganhH";
            this.lbl_MaNganhH.Size = new System.Drawing.Size(110, 18);
            this.lbl_MaNganhH.TabIndex = 6;
            this.lbl_MaNganhH.Text = "Mã ngành hàng";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(704, 95);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(704, 34);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(102, 34);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TenNhomH
            // 
            this.txt_TenNhomH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNhomH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNhomH.Location = new System.Drawing.Point(168, 95);
            this.txt_TenNhomH.Name = "txt_TenNhomH";
            this.txt_TenNhomH.Size = new System.Drawing.Size(157, 26);
            this.txt_TenNhomH.TabIndex = 3;
            // 
            // txt_MaNhomH
            // 
            this.txt_MaNhomH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNhomH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNhomH.Location = new System.Drawing.Point(168, 34);
            this.txt_MaNhomH.Name = "txt_MaNhomH";
            this.txt_MaNhomH.Size = new System.Drawing.Size(157, 26);
            this.txt_MaNhomH.TabIndex = 2;
            // 
            // lbl_TenNganhH
            // 
            this.lbl_TenNganhH.AutoSize = true;
            this.lbl_TenNganhH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNganhH.Location = new System.Drawing.Point(41, 97);
            this.lbl_TenNganhH.Name = "lbl_TenNganhH";
            this.lbl_TenNganhH.Size = new System.Drawing.Size(113, 18);
            this.lbl_TenNganhH.TabIndex = 1;
            this.lbl_TenNganhH.Text = "Tên nhóm hàng";
            // 
            // lbl_MaNhomH
            // 
            this.lbl_MaNhomH.AutoSize = true;
            this.lbl_MaNhomH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNhomH.Location = new System.Drawing.Point(41, 36);
            this.lbl_MaNhomH.Name = "lbl_MaNhomH";
            this.lbl_MaNhomH.Size = new System.Drawing.Size(107, 18);
            this.lbl_MaNhomH.TabIndex = 0;
            this.lbl_MaNhomH.Text = "Mã nhóm hàng";
            // 
            // frmNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grb_ListNhomH);
            this.Controls.Add(this.grb_NhomHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhomHang";
            this.Text = "DANH MỤC NHÓM HÀNG";
            this.Load += new System.EventHandler(this.frmNhomHang_Load);
            this.grb_ListNhomH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhomHang)).EndInit();
            this.grb_NhomHang.ResumeLayout(false);
            this.grb_NhomHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox grb_ListNhomH;
        private System.Windows.Forms.DataGridView dgv_NhomHang;
        private System.Windows.Forms.GroupBox grb_NhomHang;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TenNhomH;
        private System.Windows.Forms.TextBox txt_MaNhomH;
        private System.Windows.Forms.Label lbl_TenNganhH;
        private System.Windows.Forms.Label lbl_MaNhomH;
        private System.Windows.Forms.ComboBox cmb_MaNganhH;
        private System.Windows.Forms.Label lbl_MaNganhH;
    }
}