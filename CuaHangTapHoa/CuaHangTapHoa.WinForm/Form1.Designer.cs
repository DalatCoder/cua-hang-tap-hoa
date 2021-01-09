namespace CuaHangTapHoa.WinForm
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flpDanhSachHangHoa = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbLoaiHangHoa = new System.Windows.Forms.ComboBox();
			this.txtTimKiemHangHoa = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDanhSachKH = new System.Windows.Forms.Button();
			this.btnThemKH = new System.Windows.Forms.Button();
			this.txtTenKH = new System.Windows.Forms.ComboBox();
			this.txtTimKiemKH = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.flpSanPhamDaChon = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.chứcNăngToolStripMenuItem.Text = "Chức năng";
			// 
			// tàiKhoảnToolStripMenuItem
			// 
			this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
			this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
			// 
			// quảnLýToolStripMenuItem
			// 
			this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
			this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
			this.quảnLýToolStripMenuItem.Text = "Quản lý hàng hóa";
			// 
			// thốngKêToolStripMenuItem
			// 
			this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
			this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.thốngKêToolStripMenuItem.Text = "Thống kê";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.flpDanhSachHangHoa);
			this.groupBox1.Location = new System.Drawing.Point(0, 372);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1125, 308);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách hàng hóa";
			// 
			// flpDanhSachHangHoa
			// 
			this.flpDanhSachHangHoa.AutoScroll = true;
			this.flpDanhSachHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpDanhSachHangHoa.Location = new System.Drawing.Point(3, 24);
			this.flpDanhSachHangHoa.Name = "flpDanhSachHangHoa";
			this.flpDanhSachHangHoa.Size = new System.Drawing.Size(1119, 281);
			this.flpDanhSachHangHoa.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.cbLoaiHangHoa);
			this.groupBox2.Controls.Add(this.txtTimKiemHangHoa);
			this.groupBox2.Location = new System.Drawing.Point(3, 319);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(634, 56);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tìm kiếm nhanh hàng hóa";
			// 
			// cbLoaiHangHoa
			// 
			this.cbLoaiHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbLoaiHangHoa.FormattingEnabled = true;
			this.cbLoaiHangHoa.Location = new System.Drawing.Point(328, 21);
			this.cbLoaiHangHoa.Name = "cbLoaiHangHoa";
			this.cbLoaiHangHoa.Size = new System.Drawing.Size(288, 28);
			this.cbLoaiHangHoa.TabIndex = 1;
			this.cbLoaiHangHoa.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHangHoa_SelectedIndexChanged);
			// 
			// txtTimKiemHangHoa
			// 
			this.txtTimKiemHangHoa.Location = new System.Drawing.Point(12, 21);
			this.txtTimKiemHangHoa.Name = "txtTimKiemHangHoa";
			this.txtTimKiemHangHoa.Size = new System.Drawing.Size(288, 28);
			this.txtTimKiemHangHoa.TabIndex = 0;
			this.txtTimKiemHangHoa.TextChanged += new System.EventHandler(this.txtTimKiemHangHoa_TextChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.btnDanhSachKH);
			this.groupBox3.Controls.Add(this.btnThemKH);
			this.groupBox3.Controls.Add(this.txtTenKH);
			this.groupBox3.Controls.Add(this.txtTimKiemKH);
			this.groupBox3.Location = new System.Drawing.Point(646, 27);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(476, 100);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông tin khách hàng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Tìm kiếm nhanh:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên khách hàng:";
			// 
			// btnDanhSachKH
			// 
			this.btnDanhSachKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDanhSachKH.BackgroundImage")));
			this.btnDanhSachKH.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnDanhSachKH.FlatAppearance.BorderSize = 0;
			this.btnDanhSachKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDanhSachKH.Location = new System.Drawing.Point(370, 24);
			this.btnDanhSachKH.Name = "btnDanhSachKH";
			this.btnDanhSachKH.Size = new System.Drawing.Size(32, 32);
			this.btnDanhSachKH.TabIndex = 3;
			this.btnDanhSachKH.UseVisualStyleBackColor = true;
			// 
			// btnThemKH
			// 
			this.btnThemKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemKH.BackgroundImage")));
			this.btnThemKH.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnThemKH.FlatAppearance.BorderSize = 0;
			this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemKH.Location = new System.Drawing.Point(413, 23);
			this.btnThemKH.Name = "btnThemKH";
			this.btnThemKH.Size = new System.Drawing.Size(32, 32);
			this.btnThemKH.TabIndex = 2;
			this.btnThemKH.UseVisualStyleBackColor = true;
			// 
			// txtTenKH
			// 
			this.txtTenKH.FormattingEnabled = true;
			this.txtTenKH.Location = new System.Drawing.Point(143, 62);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(327, 28);
			this.txtTenKH.TabIndex = 2;
			// 
			// txtTimKiemKH
			// 
			this.txtTimKiemKH.Location = new System.Drawing.Point(143, 27);
			this.txtTimKiemKH.Name = "txtTimKiemKH";
			this.txtTimKiemKH.Size = new System.Drawing.Size(218, 28);
			this.txtTimKiemKH.TabIndex = 2;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.flpSanPhamDaChon);
			this.groupBox4.Location = new System.Drawing.Point(3, 27);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(637, 286);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Danh sách sản phẩm đã chọn";
			// 
			// flpSanPhamDaChon
			// 
			this.flpSanPhamDaChon.AllowDrop = true;
			this.flpSanPhamDaChon.AutoScroll = true;
			this.flpSanPhamDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpSanPhamDaChon.Location = new System.Drawing.Point(3, 24);
			this.flpSanPhamDaChon.Name = "flpSanPhamDaChon";
			this.flpSanPhamDaChon.Size = new System.Drawing.Size(631, 259);
			this.flpSanPhamDaChon.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.btnHuy);
			this.panel1.Controls.Add(this.btnThanhToan);
			this.panel1.Location = new System.Drawing.Point(652, 326);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 49);
			this.panel1.TabIndex = 5;
			// 
			// btnHuy
			// 
			this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHuy.Location = new System.Drawing.Point(296, 3);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(168, 43);
			this.btnHuy.TabIndex = 1;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThanhToan.Location = new System.Drawing.Point(3, 3);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(168, 43);
			this.btnThanhToan.TabIndex = 0;
			this.btnThanhToan.Text = "Thanh toán";
			this.btnThanhToan.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.panel3);
			this.groupBox5.Controls.Add(this.panel2);
			this.groupBox5.Location = new System.Drawing.Point(649, 135);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(479, 178);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Chi tiết đơn hàng";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtGhiChu);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(6, 71);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(467, 98);
			this.panel3.TabIndex = 3;
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.BackColor = System.Drawing.Color.White;
			this.txtGhiChu.Location = new System.Drawing.Point(89, 9);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(369, 80);
			this.txtGhiChu.TabIndex = 1;
			this.txtGhiChu.Text = "Đây là ghi chú";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Ghi chú:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtTongTien);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(6, 27);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(464, 38);
			this.panel2.TabIndex = 2;
			// 
			// txtTongTien
			// 
			this.txtTongTien.BackColor = System.Drawing.Color.White;
			this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTongTien.Location = new System.Drawing.Point(196, 8);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(252, 21);
			this.txtTongTien.TabIndex = 1;
			this.txtTongTien.Text = "120.000";
			this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tổng tiền:";
			// 
			// frmMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1124, 681);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý cửa hàng tạp hóa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnThanhToan;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ComboBox cbLoaiHangHoa;
		private System.Windows.Forms.TextBox txtTimKiemHangHoa;
		private System.Windows.Forms.Button btnThemKH;
		private System.Windows.Forms.ComboBox txtTenKH;
		private System.Windows.Forms.TextBox txtTimKiemKH;
		private System.Windows.Forms.Button btnDanhSachKH;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
		private System.Windows.Forms.FlowLayoutPanel flpDanhSachHangHoa;
		private System.Windows.Forms.FlowLayoutPanel flpSanPhamDaChon;
	}
}

