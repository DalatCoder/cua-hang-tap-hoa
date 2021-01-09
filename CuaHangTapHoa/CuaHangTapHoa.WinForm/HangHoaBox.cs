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
	public partial class uFrmHangHoa : UserControl
	{
		public uFrmHangHoa(string tieuDe, string soTien, string anhMinhHoa = "default")
		{
			InitializeComponent();
			txtSoTien.Text = soTien;
			txtTieuDe.Text = tieuDe;
			var imagePath = DirectoryUtils.GetPathTo("data", "hang-hoa", anhMinhHoa) + ".jpg";
			pbHinhMinhHoa.ImageLocation = imagePath;
		}
	}
}
