namespace CuaHangTapHoa.WinForm
{
	partial class uHangHoaItem
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uHangHoaItem));
			this.txtTieuDe = new System.Windows.Forms.TextBox();
			this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
			this.nmGiaBan = new System.Windows.Forms.NumericUpDown();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.cbBanLe = new System.Windows.Forms.CheckBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.ttTrangThai = new System.Windows.Forms.ToolTip(this.components);
			this.pbHinhMinhHoa = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmGiaBan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbHinhMinhHoa)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTieuDe
			// 
			this.txtTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTieuDe.BackColor = System.Drawing.Color.White;
			this.txtTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTieuDe.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtTieuDe.Enabled = false;
			this.txtTieuDe.ForeColor = System.Drawing.Color.Black;
			this.txtTieuDe.Location = new System.Drawing.Point(43, 12);
			this.txtTieuDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTieuDe.Multiline = true;
			this.txtTieuDe.Name = "txtTieuDe";
			this.txtTieuDe.ReadOnly = true;
			this.txtTieuDe.Size = new System.Drawing.Size(316, 21);
			this.txtTieuDe.TabIndex = 1;
			this.txtTieuDe.Text = "Đây là nước ngọt đóng chai coca cola";
			// 
			// nmSoLuong
			// 
			this.nmSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nmSoLuong.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmSoLuong.Location = new System.Drawing.Point(392, 9);
			this.nmSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmSoLuong.Name = "nmSoLuong";
			this.nmSoLuong.Size = new System.Drawing.Size(52, 25);
			this.nmSoLuong.TabIndex = 2;
			this.nmSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmSoLuong.ValueChanged += new System.EventHandler(this.nmSoLuong_ValueChanged);
			// 
			// nmGiaBan
			// 
			this.nmGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nmGiaBan.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmGiaBan.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nmGiaBan.Location = new System.Drawing.Point(450, 9);
			this.nmGiaBan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.nmGiaBan.Name = "nmGiaBan";
			this.nmGiaBan.Size = new System.Drawing.Size(104, 25);
			this.nmGiaBan.TabIndex = 3;
			this.nmGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nmGiaBan.ThousandsSeparator = true;
			this.nmGiaBan.Value = new decimal(new int[] {
            123000,
            0,
            0,
            0});
			this.nmGiaBan.ValueChanged += new System.EventHandler(this.nmGiaBan_ValueChanged);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.BackColor = System.Drawing.Color.White;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(697, 4);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(32, 32);
			this.btnDelete.TabIndex = 0;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtTongTien
			// 
			this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTongTien.BackColor = System.Drawing.Color.White;
			this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTongTien.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtTongTien.Enabled = false;
			this.txtTongTien.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTongTien.Location = new System.Drawing.Point(560, 11);
			this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTongTien.Multiline = true;
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(93, 21);
			this.txtTongTien.TabIndex = 4;
			this.txtTongTien.Text = "123.000";
			this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// cbBanLe
			// 
			this.cbBanLe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbBanLe.AutoSize = true;
			this.cbBanLe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbBanLe.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbBanLe.Location = new System.Drawing.Point(365, 16);
			this.cbBanLe.Name = "cbBanLe";
			this.cbBanLe.Size = new System.Drawing.Size(12, 11);
			this.cbBanLe.TabIndex = 5;
			this.ttTrangThai.SetToolTip(this.cbBanLe, "Khách hàng mua lẻ số lượng");
			this.cbBanLe.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.BackColor = System.Drawing.Color.White;
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(659, 4);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(32, 32);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.UseVisualStyleBackColor = false;
			// 
			// pbHinhMinhHoa
			// 
			this.pbHinhMinhHoa.Image = ((System.Drawing.Image)(resources.GetObject("pbHinhMinhHoa.Image")));
			this.pbHinhMinhHoa.InitialImage = null;
			this.pbHinhMinhHoa.Location = new System.Drawing.Point(5, 5);
			this.pbHinhMinhHoa.Name = "pbHinhMinhHoa";
			this.pbHinhMinhHoa.Size = new System.Drawing.Size(32, 32);
			this.pbHinhMinhHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbHinhMinhHoa.TabIndex = 7;
			this.pbHinhMinhHoa.TabStop = false;
			// 
			// uHangHoaItem
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pbHinhMinhHoa);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.cbBanLe);
			this.Controls.Add(this.txtTongTien);
			this.Controls.Add(this.nmGiaBan);
			this.Controls.Add(this.nmSoLuong);
			this.Controls.Add(this.txtTieuDe);
			this.Controls.Add(this.btnDelete);
			this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "uHangHoaItem";
			this.Size = new System.Drawing.Size(736, 42);
			((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmGiaBan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbHinhMinhHoa)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtTieuDe;
		private System.Windows.Forms.NumericUpDown nmSoLuong;
		private System.Windows.Forms.NumericUpDown nmGiaBan;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.CheckBox cbBanLe;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.ToolTip ttTrangThai;
		private System.Windows.Forms.PictureBox pbHinhMinhHoa;
	}
}
