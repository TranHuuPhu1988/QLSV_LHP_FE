namespace QLSV_LHP_dotNetEF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvLopHocPhan = new System.Windows.Forms.DataGridView();
            this.TenLopHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLopHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsXoaLopHocPhan = new System.Windows.Forms.ToolStripButton();
            this.tsSuaLopHocPhan = new System.Windows.Forms.ToolStripButton();
            this.tsThemHocPhan = new System.Windows.Forms.ToolStripButton();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.txtMonHoc = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenLHP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsSua = new System.Windows.Forms.ToolStripButton();
            this.tsXoaSinhVien = new System.Windows.Forms.ToolStripButton();
            this.tsRefrest = new System.Windows.Forms.ToolStripButton();
            this.dtgvSanhSachSV = new System.Windows.Forms.DataGridView();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiaoVienPhuTrach = new System.Windows.Forms.TextBox();
            this.txtSoLuongSinhVienDk = new System.Windows.Forms.TextBox();
            this.txtDinhMucSinhVien = new System.Windows.Forms.TextBox();
            this.txtMaLopHocPhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHocPhan)).BeginInit();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanhSachSV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(799, 394);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvLopHocPhan);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cbxMonHoc);
            this.panel2.Controls.Add(this.txtMonHoc);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 391);
            this.panel2.TabIndex = 0;
            // 
            // dtgvLopHocPhan
            // 
            this.dtgvLopHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLopHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenLopHocPhan,
            this.MaLopHocPhan});
            this.dtgvLopHocPhan.Location = new System.Drawing.Point(6, 89);
            this.dtgvLopHocPhan.Name = "dtgvLopHocPhan";
            this.dtgvLopHocPhan.Size = new System.Drawing.Size(248, 302);
            this.dtgvLopHocPhan.TabIndex = 3;
            this.dtgvLopHocPhan.DoubleClick += new System.EventHandler(this.dtgvLopHocPhan_DoubleClick);
            // 
            // TenLopHocPhan
            // 
            this.TenLopHocPhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLopHocPhan.DataPropertyName = "TenLopHocPhan";
            this.TenLopHocPhan.HeaderText = "TenLopHocPhan";
            this.TenLopHocPhan.Name = "TenLopHocPhan";
            // 
            // MaLopHocPhan
            // 
            this.MaLopHocPhan.DataPropertyName = "MaLopHocPhan";
            this.MaLopHocPhan.HeaderText = "MaLopHocPhan";
            this.MaLopHocPhan.Name = "MaLopHocPhan";
            this.MaLopHocPhan.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Location = new System.Drawing.Point(6, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 26);
            this.panel4.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsXoaLopHocPhan,
            this.tsSuaLopHocPhan,
            this.tsThemHocPhan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStrip1.Size = new System.Drawing.Size(248, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButton1.Size = new System.Drawing.Size(96, 23);
            this.toolStripButton1.Text = "Lớp Học Phần";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsXoaLopHocPhan
            // 
            this.tsXoaLopHocPhan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsXoaLopHocPhan.Image = ((System.Drawing.Image)(resources.GetObject("tsXoaLopHocPhan.Image")));
            this.tsXoaLopHocPhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXoaLopHocPhan.Name = "tsXoaLopHocPhan";
            this.tsXoaLopHocPhan.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tsXoaLopHocPhan.Size = new System.Drawing.Size(37, 23);
            this.tsXoaLopHocPhan.Text = "Xóa";
            this.tsXoaLopHocPhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsXoaLopHocPhan.Click += new System.EventHandler(this.tsXoaLopHocPhan_Click);
            // 
            // tsSuaLopHocPhan
            // 
            this.tsSuaLopHocPhan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSuaLopHocPhan.Image = ((System.Drawing.Image)(resources.GetObject("tsSuaLopHocPhan.Image")));
            this.tsSuaLopHocPhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSuaLopHocPhan.Name = "tsSuaLopHocPhan";
            this.tsSuaLopHocPhan.Size = new System.Drawing.Size(30, 23);
            this.tsSuaLopHocPhan.Text = "Sửa";
            this.tsSuaLopHocPhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsSuaLopHocPhan.Click += new System.EventHandler(this.tsSuaLopHocPhan_Click);
            // 
            // tsThemHocPhan
            // 
            this.tsThemHocPhan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsThemHocPhan.Image = ((System.Drawing.Image)(resources.GetObject("tsThemHocPhan.Image")));
            this.tsThemHocPhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThemHocPhan.Name = "tsThemHocPhan";
            this.tsThemHocPhan.Size = new System.Drawing.Size(42, 23);
            this.tsThemHocPhan.Text = "Thêm";
            this.tsThemHocPhan.Click += new System.EventHandler(this.tsThemHocPhan_Click);
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(103, 22);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(151, 21);
            this.cbxMonHoc.TabIndex = 1;
            this.cbxMonHoc.SelectedValueChanged += new System.EventHandler(this.cbxMonHoc_SelectedValueChanged);
            this.cbxMonHoc.Click += new System.EventHandler(this.cbxMonHoc_Click_1);
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.AutoSize = true;
            this.txtMonHoc.Location = new System.Drawing.Point(18, 25);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(79, 13);
            this.txtMonHoc.TabIndex = 0;
            this.txtMonHoc.Text = "Chọn Môn Học";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTenLHP);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.dtgvSanhSachSV);
            this.panel3.Controls.Add(this.txtGiaoVienPhuTrach);
            this.panel3.Controls.Add(this.txtSoLuongSinhVienDk);
            this.panel3.Controls.Add(this.txtDinhMucSinhVien);
            this.panel3.Controls.Add(this.txtMaLopHocPhan);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(276, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 391);
            this.panel3.TabIndex = 1;
            // 
            // txtTenLHP
            // 
            this.txtTenLHP.Location = new System.Drawing.Point(342, 42);
            this.txtTenLHP.Name = "txtTenLHP";
            this.txtTenLHP.Size = new System.Drawing.Size(161, 20);
            this.txtTenLHP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên Lớp Học Phần";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.toolStrip2);
            this.panel5.Location = new System.Drawing.Point(0, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(503, 28);
            this.panel5.TabIndex = 9;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsSua,
            this.tsXoaSinhVien,
            this.tsRefrest});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(503, 28);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 250, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(365, 25);
            this.toolStripLabel1.Text = "Danh Sách Sinh Viên";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tsSua
            // 
            this.tsSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSua.Image = ((System.Drawing.Image)(resources.GetObject("tsSua.Image")));
            this.tsSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSua.Name = "tsSua";
            this.tsSua.Size = new System.Drawing.Size(30, 25);
            this.tsSua.Text = "Sửa";
            this.tsSua.Click += new System.EventHandler(this.tsSua_Click);
            // 
            // tsXoaSinhVien
            // 
            this.tsXoaSinhVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsXoaSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("tsXoaSinhVien.Image")));
            this.tsXoaSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXoaSinhVien.Name = "tsXoaSinhVien";
            this.tsXoaSinhVien.Size = new System.Drawing.Size(31, 25);
            this.tsXoaSinhVien.Text = "Xóa";
            this.tsXoaSinhVien.Click += new System.EventHandler(this.tsXoaSinhVien_Click);
            // 
            // tsRefrest
            // 
            this.tsRefrest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRefrest.Image = ((System.Drawing.Image)(resources.GetObject("tsRefrest.Image")));
            this.tsRefrest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefrest.Name = "tsRefrest";
            this.tsRefrest.Size = new System.Drawing.Size(23, 25);
            this.tsRefrest.Text = "F5";
            this.tsRefrest.Click += new System.EventHandler(this.tsRefrest_Click);
            // 
            // dtgvSanhSachSV
            // 
            this.dtgvSanhSachSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanhSachSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSinhVien,
            this.HoDem,
            this.Ten,
            this.NgaySinh,
            this.QueQuan});
            this.dtgvSanhSachSV.Location = new System.Drawing.Point(0, 160);
            this.dtgvSanhSachSV.Name = "dtgvSanhSachSV";
            this.dtgvSanhSachSV.Size = new System.Drawing.Size(503, 231);
            this.dtgvSanhSachSV.TabIndex = 8;
            this.dtgvSanhSachSV.DoubleClick += new System.EventHandler(this.dtgvSanhSachSV_DoubleClick);
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSinhVien.DataPropertyName = "MaSinhVien";
            this.MaSinhVien.HeaderText = "MaSinhVien";
            this.MaSinhVien.Name = "MaSinhVien";
            // 
            // HoDem
            // 
            this.HoDem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoDem.DataPropertyName = "HoDem";
            this.HoDem.HeaderText = "HoDem";
            this.HoDem.Name = "HoDem";
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Ten";
            this.Ten.Name = "Ten";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // QueQuan
            // 
            this.QueQuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "QueQuan";
            this.QueQuan.Name = "QueQuan";
            // 
            // txtGiaoVienPhuTrach
            // 
            this.txtGiaoVienPhuTrach.Location = new System.Drawing.Point(155, 106);
            this.txtGiaoVienPhuTrach.Name = "txtGiaoVienPhuTrach";
            this.txtGiaoVienPhuTrach.Size = new System.Drawing.Size(168, 20);
            this.txtGiaoVienPhuTrach.TabIndex = 7;
            // 
            // txtSoLuongSinhVienDk
            // 
            this.txtSoLuongSinhVienDk.Location = new System.Drawing.Point(155, 73);
            this.txtSoLuongSinhVienDk.Name = "txtSoLuongSinhVienDk";
            this.txtSoLuongSinhVienDk.Size = new System.Drawing.Size(168, 20);
            this.txtSoLuongSinhVienDk.TabIndex = 6;
            // 
            // txtDinhMucSinhVien
            // 
            this.txtDinhMucSinhVien.Location = new System.Drawing.Point(155, 42);
            this.txtDinhMucSinhVien.Name = "txtDinhMucSinhVien";
            this.txtDinhMucSinhVien.Size = new System.Drawing.Size(168, 20);
            this.txtDinhMucSinhVien.TabIndex = 5;
            // 
            // txtMaLopHocPhan
            // 
            this.txtMaLopHocPhan.Location = new System.Drawing.Point(155, 4);
            this.txtMaLopHocPhan.Name = "txtMaLopHocPhan";
            this.txtMaLopHocPhan.Size = new System.Drawing.Size(168, 20);
            this.txtMaLopHocPhan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giáo Viên Phụ Trách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng Sinh Viên Đk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Định Mức Sinh Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp Học Phần";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 25);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHocPhan)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanhSachSV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvLopHocPhan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsXoaLopHocPhan;
        private System.Windows.Forms.ToolStripButton tsSuaLopHocPhan;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.Label txtMonHoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsSua;
        private System.Windows.Forms.ToolStripButton tsXoaSinhVien;
        private System.Windows.Forms.DataGridView dtgvSanhSachSV;
        private System.Windows.Forms.TextBox txtGiaoVienPhuTrach;
        private System.Windows.Forms.TextBox txtSoLuongSinhVienDk;
        private System.Windows.Forms.TextBox txtDinhMucSinhVien;
        private System.Windows.Forms.TextBox txtMaLopHocPhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLopHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLopHocPhan;
        private System.Windows.Forms.TextBox txtTenLHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton tsThemHocPhan;
        private System.Windows.Forms.ToolStripButton tsRefrest;
    }
}

