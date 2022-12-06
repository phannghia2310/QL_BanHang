namespace QLBanHangDB.Forms
{
    partial class frmDMChucVu
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
            this.grb_ListCV = new System.Windows.Forms.GroupBox();
            this.dgv_ChucVu = new System.Windows.Forms.DataGridView();
            this.grb_ChucVu = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TenCV = new System.Windows.Forms.TextBox();
            this.txt_MaCV = new System.Windows.Forms.TextBox();
            this.lbl_TenCV = new System.Windows.Forms.Label();
            this.lbl_MaCV = new System.Windows.Forms.Label();
            this.grb_ListCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChucVu)).BeginInit();
            this.grb_ChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(688, 596);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 39);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(526, 596);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 39);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(365, 596);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 39);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // grb_ListCV
            // 
            this.grb_ListCV.Controls.Add(this.dgv_ChucVu);
            this.grb_ListCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListCV.Location = new System.Drawing.Point(157, 283);
            this.grb_ListCV.Name = "grb_ListCV";
            this.grb_ListCV.Size = new System.Drawing.Size(859, 279);
            this.grb_ListCV.TabIndex = 10;
            this.grb_ListCV.TabStop = false;
            this.grb_ListCV.Text = "Danh sách chức vụ";
            // 
            // dgv_ChucVu
            // 
            this.dgv_ChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChucVu.Location = new System.Drawing.Point(0, 22);
            this.dgv_ChucVu.Name = "dgv_ChucVu";
            this.dgv_ChucVu.RowHeadersWidth = 51;
            this.dgv_ChucVu.RowTemplate.Height = 24;
            this.dgv_ChucVu.Size = new System.Drawing.Size(859, 257);
            this.dgv_ChucVu.TabIndex = 0;
            this.dgv_ChucVu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChucVu_RowEnter);
            // 
            // grb_ChucVu
            // 
            this.grb_ChucVu.Controls.Add(this.btn_Refresh);
            this.grb_ChucVu.Controls.Add(this.btn_TimKiem);
            this.grb_ChucVu.Controls.Add(this.txt_TenCV);
            this.grb_ChucVu.Controls.Add(this.txt_MaCV);
            this.grb_ChucVu.Controls.Add(this.lbl_TenCV);
            this.grb_ChucVu.Controls.Add(this.lbl_MaCV);
            this.grb_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ChucVu.Location = new System.Drawing.Point(157, 103);
            this.grb_ChucVu.Name = "grb_ChucVu";
            this.grb_ChucVu.Size = new System.Drawing.Size(859, 154);
            this.grb_ChucVu.TabIndex = 9;
            this.grb_ChucVu.TabStop = false;
            this.grb_ChucVu.Text = "Thông tin chức vụ";
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
            // txt_TenCV
            // 
            this.txt_TenCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenCV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenCV.Location = new System.Drawing.Point(189, 112);
            this.txt_TenCV.Name = "txt_TenCV";
            this.txt_TenCV.Size = new System.Drawing.Size(203, 26);
            this.txt_TenCV.TabIndex = 3;
            // 
            // txt_MaCV
            // 
            this.txt_MaCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaCV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaCV.Location = new System.Drawing.Point(189, 43);
            this.txt_MaCV.Name = "txt_MaCV";
            this.txt_MaCV.Size = new System.Drawing.Size(203, 26);
            this.txt_MaCV.TabIndex = 2;
            // 
            // lbl_TenCV
            // 
            this.lbl_TenCV.AutoSize = true;
            this.lbl_TenCV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenCV.Location = new System.Drawing.Point(81, 114);
            this.lbl_TenCV.Name = "lbl_TenCV";
            this.lbl_TenCV.Size = new System.Drawing.Size(91, 18);
            this.lbl_TenCV.TabIndex = 1;
            this.lbl_TenCV.Text = "Tên chức vụ";
            // 
            // lbl_MaCV
            // 
            this.lbl_MaCV.AutoSize = true;
            this.lbl_MaCV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaCV.Location = new System.Drawing.Point(81, 45);
            this.lbl_MaCV.Name = "lbl_MaCV";
            this.lbl_MaCV.Size = new System.Drawing.Size(85, 18);
            this.lbl_MaCV.TabIndex = 0;
            this.lbl_MaCV.Text = "Mã chức vụ";
            // 
            // frmDMChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grb_ListCV);
            this.Controls.Add(this.grb_ChucVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDMChucVu";
            this.Text = "DANH MỤC CHỨC VỤ";
            this.Load += new System.EventHandler(this.frmDMChucVu_Load);
            this.grb_ListCV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChucVu)).EndInit();
            this.grb_ChucVu.ResumeLayout(false);
            this.grb_ChucVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox grb_ListCV;
        private System.Windows.Forms.DataGridView dgv_ChucVu;
        private System.Windows.Forms.GroupBox grb_ChucVu;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TenCV;
        private System.Windows.Forms.TextBox txt_MaCV;
        private System.Windows.Forms.Label lbl_TenCV;
        private System.Windows.Forms.Label lbl_MaCV;
    }
}