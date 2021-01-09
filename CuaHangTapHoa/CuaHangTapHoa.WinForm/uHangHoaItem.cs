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

namespace CuaHangTapHoa.WinForm
{
	public partial class uHangHoaItem : UserControl
	{
		public uHangHoaItem(string tenHang, decimal giaTienBanDau, string anhMinhHoa = "default")
		{
			InitializeComponent();
			txtTieuDe.Text = tenHang;
			nmGiaBan.Value = giaTienBanDau;
			var imagePath = DirectoryUtils.GetPathTo("data", "hang-hoa", anhMinhHoa) + ".jpg";
			pbHinhMinhHoa.ImageLocation = imagePath;
		}
	}
}
