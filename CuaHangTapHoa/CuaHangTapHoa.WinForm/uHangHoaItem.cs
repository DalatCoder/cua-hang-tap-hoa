using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangTapHoa.WinForm.Utils;
using CuaHangTapHoa.WinForm.DTO;

namespace CuaHangTapHoa.WinForm
{
	public partial class uHangHoaItem : UserControl
	{
		private readonly HangHoaRead hangHoa;
		public int HangHoaId => hangHoa.Id;

		public string TongTienStr { get => (nmSoLuong.Value * nmGiaBan.Value).ToString(); }

		public uHangHoaItem(HangHoaRead hangHoa)
		{
			InitializeComponent();

			this.hangHoa = hangHoa;

			txtTieuDe.Text = hangHoa.TenHang;
			nmGiaBan.Value = hangHoa.GiaBan;
			nmSoLuong.Value = 1;
			txtTongTien.Text = TongTienStr;

			var imagePath = DirectoryUtils.GetPathTo("data", "hang-hoa", hangHoa.HinhAnh) + ".jpg";
			pbHinhMinhHoa.ImageLocation = imagePath;
		}

		public void AddSoLuong(int soLuong)
		{
			nmSoLuong.Value += soLuong;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			this.Parent.Controls.Remove(this);
		}

		private void nmSoLuong_ValueChanged(object sender, EventArgs e)
		{
			txtTongTien.Text = TongTienStr;
		}

		private void nmGiaBan_ValueChanged(object sender, EventArgs e)
		{
			txtTongTien.Text = TongTienStr;
		}
	}
}
