namespace QLBanHangDB.Forms
{
    partial class frmNganhHang
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
            this.grb_ListNganhH = new System.Windows.Forms.GroupBox();
            this.dgv_NganhHang = new System.Windows.Forms.DataGridView();
            this.grb_NganhHang = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TenNganhH = new System.Windows.Forms.TextBox();
            this.txt_MaNganhH = new System.Windows.Forms.TextBox();
            this.lbl_TenNganhH = new System.Windows.Forms.Label();
            this.lbl_MaNganhH = new System.Windows.Forms.Label();
            this.grb_ListNganhH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NganhHang)).BeginInit();
            this.grb_NganhHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(691, 606);
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
            this.btn_Sua.Location = new System.Drawing.Point(529, 606);
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
            this.btn_Them.Location = new System.Drawing.Point(368, 606);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 39);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // grb_ListNganhH
            // 
            this.grb_ListNganhH.Controls.Add(this.dgv_NganhHang);
            this.grb_ListNganhH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListNganhH.Location = new System.Drawing.Point(160, 293);
            this.grb_ListNganhH.Name = "grb_ListNganhH";
            this.grb_ListNganhH.Size = new System.Drawing.Size(859, 279);
            this.grb_ListNganhH.TabIndex = 15;
            this.grb_ListNganhH.TabStop = false;
            this.grb_ListNganhH.Text = "Danh sách ngành hàng";
            // 
            // dgv_NganhHang
            // 
            this.dgv_NganhHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NganhHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NganhHang.Location = new System.Drawing.Point(0, 22);
            this.dgv_NganhHang.Name = "dgv_NganhHang";
            this.dgv_NganhHang.RowHeadersWidth = 51;
            this.dgv_NganhHang.RowTemplate.Height = 24;
            this.dgv_NganhHang.Size = new System.Drawing.Size(859, 257);
            this.dgv_NganhHang.TabIndex = 0;
            this.dgv_NganhHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NganhHang_RowEnter);
            // 
            // grb_NganhHang
            // 
            this.grb_NganhHang.Controls.Add(this.btn_Refresh);
            this.grb_NganhHang.Controls.Add(this.btn_TimKiem);
            this.grb_NganhHang.Controls.Add(this.txt_TenNganhH);
            this.grb_NganhHang.Controls.Add(this.txt_MaNganhH);
            this.grb_NganhHang.Controls.Add(this.lbl_TenNganhH);
            this.grb_NganhHang.Controls.Add(this.lbl_MaNganhH);
            this.grb_NganhHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_NganhHang.Location = new System.Drawing.Point(160, 113);
            this.grb_NganhHang.Name = "grb_NganhHang";
            this.grb_NganhHang.Size = new System.Drawing.Size(859, 154);
            this.grb_NganhHang.TabIndex = 14;
            this.grb_NganhHang.TabStop = false;
            this.grb_NganhHang.Text = "Thông tin ngành hàng";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(654, 97);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(654, 36);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(102, 34);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TenNganhH
            // 
            this.txt_TenNganhH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNganhH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNganhH.Location = new System.Drawing.Point(208, 112);
            this.txt_TenNganhH.Name = "txt_TenNganhH";
            this.txt_TenNganhH.Size = new System.Drawing.Size(203, 26);
            this.txt_TenNganhH.TabIndex = 3;
            // 
            // txt_MaNganhH
            // 
            this.txt_MaNganhH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNganhH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNganhH.Location = new System.Drawing.Point(208, 43);
            this.txt_MaNganhH.Name = "txt_MaNganhH";
            this.txt_MaNganhH.Size = new System.Drawing.Size(203, 26);
            this.txt_MaNganhH.TabIndex = 2;
            // 
            // lbl_TenNganhH
            // 
            this.lbl_TenNganhH.AutoSize = true;
            this.lbl_TenNganhH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNganhH.Location = new System.Drawing.Point(81, 114);
            this.lbl_TenNganhH.Name = "lbl_TenNganhH";
            this.lbl_TenNganhH.Size = new System.Drawing.Size(116, 18);
            this.lbl_TenNganhH.TabIndex = 1;
            this.lbl_TenNganhH.Text = "Tên ngành hàng";
            // 
            // lbl_MaNganhH
            // 
            this.lbl_MaNganhH.AutoSize = true;
            this.lbl_MaNganhH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNganhH.Location = new System.Drawing.Point(81, 45);
            this.lbl_MaNganhH.Name = "lbl_MaNganhH";
            this.lbl_MaNganhH.Size = new System.Drawing.Size(110, 18);
            this.lbl_MaNganhH.TabIndex = 0;
            this.lbl_MaNganhH.Text = "Mã ngành hàng";
            // 
            // frmNganhHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grb_ListNganhH);
            this.Controls.Add(this.grb_NganhHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNganhHang";
            this.Text = "DANH MỤC NGÀNH HÀNG";
            this.Load += new System.EventHandler(this.frmNganhHang_Load);
            this.grb_ListNganhH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NganhHang)).EndInit();
            this.grb_NganhHang.ResumeLayout(false);
            this.grb_NganhHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox grb_ListNganhH;
        private System.Windows.Forms.DataGridView dgv_NganhHang;
        private System.Windows.Forms.GroupBox grb_NganhHang;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TenNganhH;
        private System.Windows.Forms.TextBox txt_MaNganhH;
        private System.Windows.Forms.Label lbl_TenNganhH;
        private System.Windows.Forms.Label lbl_MaNganhH;
    }
}