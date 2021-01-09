using CuaHangTapHoa.WinForm.DAO;
using CuaHangTapHoa.WinForm.DTO;
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
			LoadLoaiHangHoa();
			// LoadHangHoa();
		}

		void LoadLoaiHangHoa()
		{
			List<LoaiHangHoa> dsLoaiHangHoa = LoaiHangHoaDAO.Instance.GetAllLoaiHangHoa();
			dsLoaiHangHoa.Insert(0, new LoaiHangHoa() { Id = 0, TenLoai = "Tất cả" });
			cbLoaiHangHoa.DataSource = dsLoaiHangHoa;
			cbLoaiHangHoa.DisplayMember = "TenLoai";
			cbLoaiHangHoa.ValueMember = "Id";
		}

		void LoadHangHoa()
		{
			List<HangHoaRead> dsHangHoa = HangHoaDAO.Instance.GetAllHangHoa();
			RenderDanhSachHangHoa(dsHangHoa);
		}

		void RenderDanhSachHangHoa(List<HangHoaRead> dsHangHoa)
		{
			flpDanhSachHangHoa.Controls.Clear();
			foreach (HangHoaRead hangHoa in dsHangHoa)
			{
				uFrmHangHoa box = new uFrmHangHoa(hangHoa.TenHang, hangHoa.GiaBanStr, hangHoa.HinhAnh);
				box.Tag = hangHoa;
				box.Click += HangHoaItem_click;
				flpDanhSachHangHoa.Controls.Add(box);
			}
		}

		private void HangHoaItem_click(object sender, EventArgs e)
		{
			uFrmHangHoa frm = sender as uFrmHangHoa;
			HangHoaRead clickedHangHoa = frm.Tag as HangHoaRead;

			AddHangHoaDuocChon(clickedHangHoa);
		}

		void AddHangHoaDuocChon(HangHoaRead hangHoa)
		{
			foreach (uHangHoaItem item in flpSanPhamDaChon.Controls)
			{
				if (item.HangHoaId == hangHoa.Id)
				{
					item.AddSoLuong(1);
					return;
				}
			}

			uHangHoaItem newItem = new uHangHoaItem(hangHoa);
			newItem.Width = flpSanPhamDaChon.Width - 30;
			flpSanPhamDaChon.Controls.Add(newItem);
		}

		private void cbLoaiHangHoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoaiHangHoa selectedItem = cbLoaiHangHoa.SelectedItem as LoaiHangHoa;
			if (selectedItem == null) return;

			if (selectedItem.Id == 0)
			{
				LoadHangHoa();
				return;
			}

			var dsHangHoa = HangHoaDAO.Instance.GetAllHangHoaByLoaiHangHoa(selectedItem.Id);
			RenderDanhSachHangHoa(dsHangHoa);
		}
	}
}
