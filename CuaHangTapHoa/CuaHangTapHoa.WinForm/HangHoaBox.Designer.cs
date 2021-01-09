namespace CuaHangTapHoa.WinForm
{
	partial class uFrmHangHoa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uFrmHangHoa));
			this.txtTieuDe = new System.Windows.Forms.TextBox();
			this.txtSoTien = new System.Windows.Forms.TextBox();
			this.pbHinhMinhHoa = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbHinhMinhHoa)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTieuDe
			// 
			this.txtTieuDe.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTieuDe.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtTieuDe.Enabled = false;
			this.txtTieuDe.Location = new System.Drawing.Point(3, 90);
			this.txtTieuDe.Multiline = true;
			this.txtTieuDe.Name = "txtTieuDe";
			this.txtTieuDe.ReadOnly = true;
			this.txtTieuDe.Size = new System.Drawing.Size(94, 30);
			this.txtTieuDe.TabIndex = 0;
			this.txtTieuDe.Text = "Đây là nước ngọt đóng chai coca cola";
			this.txtTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSoTien
			// 
			this.txtSoTien.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtSoTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSoTien.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtSoTien.Enabled = false;
			this.txtSoTien.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoTien.Location = new System.Drawing.Point(3, 67);
			this.txtSoTien.Name = "txtSoTien";
			this.txtSoTien.ReadOnly = true;
			this.txtSoTien.ShortcutsEnabled = false;
			this.txtSoTien.Size = new System.Drawing.Size(94, 21);
			this.txtSoTien.TabIndex = 1;
			this.txtSoTien.Text = "20.000";
			this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pbHinhMinhHoa
			// 
			this.pbHinhMinhHoa.Image = ((System.Drawing.Image)(resources.GetObject("pbHinhMinhHoa.Image")));
			this.pbHinhMinhHoa.Location = new System.Drawing.Point(3, 3);
			this.pbHinhMinhHoa.Name = "pbHinhMinhHoa";
			this.pbHinhMinhHoa.Size = new System.Drawing.Size(94, 64);
			this.pbHinhMinhHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbHinhMinhHoa.TabIndex = 2;
			this.pbHinhMinhHoa.TabStop = false;
			// 
			// uFrmHangHoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.pbHinhMinhHoa);
			this.Controls.Add(this.txtSoTien);
			this.Controls.Add(this.txtTieuDe);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "uFrmHangHoa";
			this.Size = new System.Drawing.Size(100, 120);
			((System.ComponentModel.ISupportInitialize)(this.pbHinhMinhHoa)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTieuDe;
		private System.Windows.Forms.TextBox txtSoTien;
		private System.Windows.Forms.PictureBox pbHinhMinhHoa;
	}
}
