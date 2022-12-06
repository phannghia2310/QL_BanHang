namespace QLBanHangDB.Forms
{
    partial class frmAccount
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
            this.grb_Account = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_MaCV = new System.Windows.Forms.ComboBox();
            this.cmb_MaNV = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_PostitionID = new System.Windows.Forms.Label();
            this.lbl_EmployeeID = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.grb_ListAccount = new System.Windows.Forms.GroupBox();
            this.dgv_Account = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.grb_Account.SuspendLayout();
            this.grb_ListAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Account
            // 
            this.grb_Account.Controls.Add(this.btn_TimKiem);
            this.grb_Account.Controls.Add(this.btn_Refresh);
            this.grb_Account.Controls.Add(this.cmb_MaCV);
            this.grb_Account.Controls.Add(this.cmb_MaNV);
            this.grb_Account.Controls.Add(this.txt_Password);
            this.grb_Account.Controls.Add(this.txt_Username);
            this.grb_Account.Controls.Add(this.lbl_PostitionID);
            this.grb_Account.Controls.Add(this.lbl_EmployeeID);
            this.grb_Account.Controls.Add(this.lbl_Password);
            this.grb_Account.Controls.Add(this.lbl_Username);
            this.grb_Account.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Account.Location = new System.Drawing.Point(146, 128);
            this.grb_Account.Name = "grb_Account";
            this.grb_Account.Size = new System.Drawing.Size(868, 144);
            this.grb_Account.TabIndex = 0;
            this.grb_Account.TabStop = false;
            this.grb_Account.Text = "Thông tin tài khoản";
            this.grb_Account.Enter += new System.EventHandler(this.grb_Account_Enter);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(742, 31);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(92, 32);
            this.btn_TimKiem.TabIndex = 8;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(742, 85);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(92, 32);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_MaCV
            // 
            this.cmb_MaCV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_MaCV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaCV.FormattingEnabled = true;
            this.cmb_MaCV.Location = new System.Drawing.Point(504, 85);
            this.cmb_MaCV.Name = "cmb_MaCV";
            this.cmb_MaCV.Size = new System.Drawing.Size(155, 26);
            this.cmb_MaCV.TabIndex = 7;
            this.cmb_MaCV.Leave += new System.EventHandler(this.cmb_MaCV_Leave);
            // 
            // cmb_MaNV
            // 
            this.cmb_MaNV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_MaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaNV.FormattingEnabled = true;
            this.cmb_MaNV.Location = new System.Drawing.Point(504, 31);
            this.cmb_MaNV.Name = "cmb_MaNV";
            this.cmb_MaNV.Size = new System.Drawing.Size(155, 26);
            this.cmb_MaNV.TabIndex = 6;
            this.cmb_MaNV.Leave += new System.EventHandler(this.cmb_MaNV_Leave);
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(161, 85);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(198, 26);
            this.txt_Password.TabIndex = 5;
            // 
            // txt_Username
            // 
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(161, 34);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(198, 26);
            this.txt_Username.TabIndex = 4;
            // 
            // lbl_PostitionID
            // 
            this.lbl_PostitionID.AutoSize = true;
            this.lbl_PostitionID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PostitionID.Location = new System.Drawing.Point(390, 88);
            this.lbl_PostitionID.Name = "lbl_PostitionID";
            this.lbl_PostitionID.Size = new System.Drawing.Size(85, 18);
            this.lbl_PostitionID.TabIndex = 3;
            this.lbl_PostitionID.Text = "Mã chức vụ";
            // 
            // lbl_EmployeeID
            // 
            this.lbl_EmployeeID.AutoSize = true;
            this.lbl_EmployeeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeID.Location = new System.Drawing.Point(390, 36);
            this.lbl_EmployeeID.Name = "lbl_EmployeeID";
            this.lbl_EmployeeID.Size = new System.Drawing.Size(96, 18);
            this.lbl_EmployeeID.TabIndex = 2;
            this.lbl_EmployeeID.Text = "Mã nhân viên";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(27, 88);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(69, 18);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Mật khẩu";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(27, 36);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(109, 18);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Tên đăng nhập";
            // 
            // grb_ListAccount
            // 
            this.grb_ListAccount.Controls.Add(this.dgv_Account);
            this.grb_ListAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListAccount.Location = new System.Drawing.Point(146, 296);
            this.grb_ListAccount.Name = "grb_ListAccount";
            this.grb_ListAccount.Size = new System.Drawing.Size(868, 271);
            this.grb_ListAccount.TabIndex = 1;
            this.grb_ListAccount.TabStop = false;
            this.grb_ListAccount.Text = "Danh sách tài khoản";
            // 
            // dgv_Account
            // 
            this.dgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Account.Location = new System.Drawing.Point(0, 24);
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.RowHeadersWidth = 51;
            this.dgv_Account.RowTemplate.Height = 24;
            this.dgv_Account.Size = new System.Drawing.Size(868, 247);
            this.dgv_Account.TabIndex = 0;
            this.dgv_Account.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Account_RowEnter);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(370, 587);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 32);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(650, 589);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(92, 30);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(508, 587);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(92, 32);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1199, 750);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.grb_ListAccount);
            this.Controls.Add(this.grb_Account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccount";
            this.Text = "QUẢN LÝ TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.grb_Account.ResumeLayout(false);
            this.grb_Account.PerformLayout();
            this.grb_ListAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Account;
        private System.Windows.Forms.Label lbl_PostitionID;
        private System.Windows.Forms.Label lbl_EmployeeID;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.ComboBox cmb_MaCV;
        private System.Windows.Forms.ComboBox cmb_MaNV;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.GroupBox grb_ListAccount;
        private System.Windows.Forms.DataGridView dgv_Account;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}