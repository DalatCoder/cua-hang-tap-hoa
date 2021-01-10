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
	public partial class frmQuanLy : Form
	{
		BindingSource dsHangHoaBinding = new BindingSource();
		List<HangHoaRead> dsHangHoa = new List<HangHoaRead>();

		public frmQuanLy()
		{
			InitializeComponent();
		}

		private void frmQuanLy_Load(object sender, EventArgs e)
		{
			dgvHangHoa.DataSource = dsHangHoaBinding;
			LoadDanhSachHangHoaAll();
			LoadDanhSachLoaiHangHoa();
			LoadDanhSachDonViTinh();
			AddDataBindingHangHoa();

			InitThongKeBar();
			InitDataGridview();
		}

		void LoadDanhSachHangHoaAll()
		{
			dsHangHoa = HangHoaDAO.Instance.GetAllHangHoa();
			dsHangHoaBinding.DataSource = dsHangHoa;
		}

		void LoadDanhSachHangHoaByName(string keyword)
		{
			dsHangHoa = HangHoaDAO.Instance.SearchHangHoaByTenHangHoa(keyword);
			dsHangHoaBinding.DataSource = dsHangHoa;
		}

		void LoadDanhSachLoaiHangHoa()
		{
			cbHangHoaLoai.DataSource = LoaiHangHoaDAO.Instance.GetAllLoaiHangHoa();
			cbHangHoaLoai.DisplayMember = "TenLoai";
			cbHangHoaLoai.ValueMember = "Id";
		}

		void LoadDanhSachDonViTinh()
		{
			cbHangHoaDVT.DataSource = DonViTinhDAO.Instance.GetAllDonViTinh();
			cbHangHoaDVT.DisplayMember = "TenDonViTinh";
			cbHangHoaDVT.ValueMember = "Id";
		}

		void AddDataBindingHangHoa()
		{
			txtHangHoaID.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "Id", true, DataSourceUpdateMode.Never));
			txtHangHoaMoTa.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "MoTa", true, DataSourceUpdateMode.Never));
			txtHangHoaTen.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "TenHang", true, DataSourceUpdateMode.Never));
			nmHangHoaGiaBan.DataBindings.Add(new Binding("Value", dgvHangHoa.DataSource, "GiaBan", true, DataSourceUpdateMode.Never));
			nmHangHoaLoiNhuan.DataBindings.Add(new Binding("Value", dgvHangHoa.DataSource, "LoiNhuan", true, DataSourceUpdateMode.Never));
			nmHangHoaGiaVon.DataBindings.Add(new Binding("Value", dgvHangHoa.DataSource, "GiaVon", true, DataSourceUpdateMode.Never));
			nmHangHoaSoLuongTonKho.DataBindings.Add(new Binding("Value", dgvHangHoa.DataSource, "TonKho", true, DataSourceUpdateMode.Never));
			pbHangHoa.DataBindings.Add(new Binding("ImageLocation", dgvHangHoa.DataSource, "FullImagePath", true, DataSourceUpdateMode.Never));
			cbHangHoaLoai.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "TenLoai", true, DataSourceUpdateMode.Never));
			cbHangHoaDVT.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "DonViTinh", true, DataSourceUpdateMode.Never));
			rdHangHoaActive.DataBindings.Add(new Binding("Checked", dgvHangHoa.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
			//rdHangHoaInactive.DataBindings.Add(new Binding("Checked", dgvHangHoa.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
		}

		void InitDataGridview()
		{
			var hideColumns = new List<String>()
			{
				"FullImagePath",
				"TrangThai",
				"GiaVon",
				"GiaBan",
				"HinhAnh",
				"MoTa",
				"GiaVonStr",
			};

			hideColumns.ForEach(str => dgvHangHoa.Columns[str].Visible = false);
		}

		void InitThongKeBar()
		{
			List<LoaiHangHoa> dsLoaiHangHoa = LoaiHangHoaDAO.Instance.GetAllLoaiHangHoa();

			dsLoaiHangHoa.Insert(0, new LoaiHangHoa() { Id = 0, TenLoai = "Tất cả" });
			cbHangHoaTimKiemLoaiHang.DataSource = dsLoaiHangHoa;
			cbHangHoaTimKiemLoaiHang.DisplayMember = "TenLoai";
			cbHangHoaTimKiemLoaiHang.ValueMember = "Id";

			List<DonViTinh> dsDonViTinh = DonViTinhDAO.Instance.GetAllDonViTinh();

			dsDonViTinh.Insert(0, new DonViTinh() { Id = 0, TenDonViTinh = "Tất cả" });
			cbHHTimKiemDVT.DataSource = dsDonViTinh;
			cbHHTimKiemDVT.DisplayMember = "TenDonViTinh";
			cbHHTimKiemDVT.ValueMember = "Id";

			cbHHTimKiemTrangThai.SelectedIndex = -1;
			cbHangHoaTimKiemLoaiHang.SelectedIndex = -1;
			cbHHTimKiemDVT.SelectedIndex = -1;
			cbHangHoaSapXep.SelectedIndex = -1;
		}

		private void cbHangHoaSapXep_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbHangHoaSapXep.SelectedIndex < 0) return;

			if(cbHangHoaSapXep.SelectedItem.ToString().Equals("Lợi nhuận"))
			{
				dsHangHoaBinding.DataSource = dsHangHoa.OrderByDescending(item => item.LoiNhuan);
			}
			else if (cbHangHoaSapXep.SelectedItem.ToString().Equals("Số lượng tồn"))
			{
				dsHangHoaBinding.DataSource = dsHangHoa.OrderByDescending(item => item.TonKho);
			}
			else if (cbHangHoaSapXep.SelectedItem.ToString().Equals("Giá bán"))
			{
				dsHangHoaBinding.DataSource = dsHangHoa.OrderByDescending(item => item.GiaBan);
			}
		}

		private void txtTimKiemHangHoa_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtTimKiemHangHoa.Text;		
			LoadDanhSachHangHoaByName(keyword);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LoadDanhSachHangHoaAll();
		}

		private void cbHangHoaTimKiemLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbHangHoaTimKiemLoaiHang.SelectedIndex < 0) return;

			LoaiHangHoa selectedCategory = cbHangHoaTimKiemLoaiHang.SelectedItem as LoaiHangHoa;
			string tenLoai = selectedCategory.TenLoai;

			if (tenLoai.Equals("Tất cả"))
			{
				dsHangHoaBinding.DataSource = dsHangHoa;
				return;
			}

			try
			{
				dsHangHoaBinding.DataSource = dsHangHoa.Where(item => item.TenLoai.Equals(tenLoai));
			} catch
			{
				dsHangHoaBinding.DataSource = new List<HangHoaRead>();
			}
		}

		private void cbHHTimKiemDVT_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbHHTimKiemDVT.SelectedIndex < 0) return;

			DonViTinh selectedCategory = cbHHTimKiemDVT.SelectedItem as DonViTinh;
			string tenDVT = selectedCategory.TenDonViTinh;

			if (tenDVT.Equals("Tất cả"))
			{
				dsHangHoaBinding.DataSource = dsHangHoa;
				return;
			}

			try
			{
				dsHangHoaBinding.DataSource = dsHangHoa.Where(item => item.DonViTinh.Equals(tenDVT));
			}
			catch
			{
				dsHangHoaBinding.DataSource = new List<HangHoaRead>();
			}
		}

		private void cbHHTimKiemTrangThai_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbHHTimKiemTrangThai.SelectedIndex < 0) return;

			string trangThai = cbHHTimKiemTrangThai.SelectedItem.ToString();

			try
			{
				if (trangThai.Equals("Tất cả"))
				{
					dsHangHoaBinding.DataSource = dsHangHoa;
				}
				else if (trangThai.Equals("Còn hàng"))
				{
					dsHangHoaBinding.DataSource = dsHangHoa.Where(item => item.TonKho > 0);
				}
				else if (trangThai.Equals("Hết hàng"))
				{
					dsHangHoaBinding.DataSource = dsHangHoa.Where(item => item.TonKho == 0);
				}
				else if (trangThai.Equals("Ngừng buôn bán"))
				{
					dsHangHoaBinding.DataSource = dsHangHoa.Where(item => item.TrangThai == false);
				}
			} catch
			{
				dsHangHoaBinding.DataSource = new List<HangHoaRead>();
			}
		}
	}
}
