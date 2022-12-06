namespace QLBanHangDB.Forms
{
    partial class frmHangSX
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
            this.grb_ListHangSX = new System.Windows.Forms.GroupBox();
            this.dgv_HangSX = new System.Windows.Forms.DataGridView();
            this.grb_HangSX = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TenHangSX = new System.Windows.Forms.TextBox();
            this.txt_MaHangSX = new System.Windows.Forms.TextBox();
            this.lbl_TenHangSX = new System.Windows.Forms.Label();
            this.lbl_MaHangSX = new System.Windows.Forms.Label();
            this.grb_ListHangSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangSX)).BeginInit();
            this.grb_HangSX.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(685, 600);
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
            this.btn_Sua.Location = new System.Drawing.Point(523, 600);
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
            this.btn_Them.Location = new System.Drawing.Point(362, 600);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 39);
            this.btn_Them.TabIndex = 21;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // grb_ListHangSX
            // 
            this.grb_ListHangSX.Controls.Add(this.dgv_HangSX);
            this.grb_ListHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListHangSX.Location = new System.Drawing.Point(154, 287);
            this.grb_ListHangSX.Name = "grb_ListHangSX";
            this.grb_ListHangSX.Size = new System.Drawing.Size(859, 279);
            this.grb_ListHangSX.TabIndex = 20;
            this.grb_ListHangSX.TabStop = false;
            this.grb_ListHangSX.Text = "Danh sách hãng sản xuất";
            // 
            // dgv_HangSX
            // 
            this.dgv_HangSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HangSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HangSX.Location = new System.Drawing.Point(0, 22);
            this.dgv_HangSX.Name = "dgv_HangSX";
            this.dgv_HangSX.RowHeadersWidth = 51;
            this.dgv_HangSX.RowTemplate.Height = 24;
            this.dgv_HangSX.Size = new System.Drawing.Size(859, 257);
            this.dgv_HangSX.TabIndex = 0;
            this.dgv_HangSX.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HangSX_RowEnter);
            // 
            // grb_HangSX
            // 
            this.grb_HangSX.Controls.Add(this.btn_Refresh);
            this.grb_HangSX.Controls.Add(this.btn_TimKiem);
            this.grb_HangSX.Controls.Add(this.txt_TenHangSX);
            this.grb_HangSX.Controls.Add(this.txt_MaHangSX);
            this.grb_HangSX.Controls.Add(this.lbl_TenHangSX);
            this.grb_HangSX.Controls.Add(this.lbl_MaHangSX);
            this.grb_HangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_HangSX.Location = new System.Drawing.Point(154, 107);
            this.grb_HangSX.Name = "grb_HangSX";
            this.grb_HangSX.Size = new System.Drawing.Size(859, 154);
            this.grb_HangSX.TabIndex = 19;
            this.grb_HangSX.TabStop = false;
            this.grb_HangSX.Text = "Thông tin hãng sản xuất";
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
            // txt_TenHangSX
            // 
            this.txt_TenHangSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenHangSX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHangSX.Location = new System.Drawing.Point(228, 112);
            this.txt_TenHangSX.Name = "txt_TenHangSX";
            this.txt_TenHangSX.Size = new System.Drawing.Size(203, 26);
            this.txt_TenHangSX.TabIndex = 3;
            // 
            // txt_MaHangSX
            // 
            this.txt_MaHangSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHangSX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHangSX.Location = new System.Drawing.Point(228, 43);
            this.txt_MaHangSX.Name = "txt_MaHangSX";
            this.txt_MaHangSX.Size = new System.Drawing.Size(203, 26);
            this.txt_MaHangSX.TabIndex = 2;
            // 
            // lbl_TenHangSX
            // 
            this.lbl_TenHangSX.AutoSize = true;
            this.lbl_TenHangSX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenHangSX.Location = new System.Drawing.Point(81, 114);
            this.lbl_TenHangSX.Name = "lbl_TenHangSX";
            this.lbl_TenHangSX.Size = new System.Drawing.Size(133, 18);
            this.lbl_TenHangSX.TabIndex = 1;
            this.lbl_TenHangSX.Text = "Tên hãng sản xuất";
            // 
            // lbl_MaHangSX
            // 
            this.lbl_MaHangSX.AutoSize = true;
            this.lbl_MaHangSX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHangSX.Location = new System.Drawing.Point(81, 45);
            this.lbl_MaHangSX.Name = "lbl_MaHangSX";
            this.lbl_MaHangSX.Size = new System.Drawing.Size(127, 18);
            this.lbl_MaHangSX.TabIndex = 0;
            this.lbl_MaHangSX.Text = "Mã hãng sản xuất";
            // 
            // frmHangSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grb_ListHangSX);
            this.Controls.Add(this.grb_HangSX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHangSX";
            this.Text = "DANH MỤC HÃNG SẢN XUẤT";
            this.Load += new System.EventHandler(this.frmHangSX_Load);
            this.grb_ListHangSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangSX)).EndInit();
            this.grb_HangSX.ResumeLayout(false);
            this.grb_HangSX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox grb_ListHangSX;
        private System.Windows.Forms.DataGridView dgv_HangSX;
        private System.Windows.Forms.GroupBox grb_HangSX;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TenHangSX;
        private System.Windows.Forms.TextBox txt_MaHangSX;
        private System.Windows.Forms.Label lbl_TenHangSX;
        private System.Windows.Forms.Label lbl_MaHangSX;
    }
}