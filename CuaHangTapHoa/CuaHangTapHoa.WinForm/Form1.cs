using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTapHoa.WinForm
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			uFrmHangHoa uFrm = new uFrmHangHoa("Nước coca", "10.000", "coca");
			flpDanhSachHangHoa.Controls.Add(uFrm);
			uFrm = new uFrmHangHoa("Nước pepsi", "10.000", "pepsi");
			flpDanhSachHangHoa.Controls.Add(uFrm);
			uFrm = new uFrmHangHoa("Thuốc Seven", "13.000", "thuoc-seven");
			flpDanhSachHangHoa.Controls.Add(uFrm);
			uFrm = new uFrmHangHoa("Mì hảo hảo", "4.000", "mi-hao-hao");
			flpDanhSachHangHoa.Controls.Add(uFrm);
			uFrm = new uFrmHangHoa("Snack bí ngô", "5.000", "snack-bi-do");
			flpDanhSachHangHoa.Controls.Add(uFrm);

			uHangHoaItem uItem = new uHangHoaItem("Nước coca", 10000, "coca");
			flpSanPhamDaChon.Controls.Add(uItem);

			uItem = new uHangHoaItem("Nước pepsi", 10000, "pepsi");
			flpSanPhamDaChon.Controls.Add(uItem);

			uItem = new uHangHoaItem("Mì hảo hảo", 4000, "mi-hao-hao");
			flpSanPhamDaChon.Controls.Add(uItem);

			uItem = new uHangHoaItem("Snack bí ngô", 5000, "snack-bi-do");
			flpSanPhamDaChon.Controls.Add(uItem);

			uItem = new uHangHoaItem("Unknow", 1000);
			flpSanPhamDaChon.Controls.Add(uItem);

			InitHangHoaItemWidth();
		}

		void InitHangHoaItemWidth()
		{
			foreach (uHangHoaItem item in flpSanPhamDaChon.Controls)
			{
				item.Width = flpSanPhamDaChon.Width - 30;
			}
		}
	}
}
