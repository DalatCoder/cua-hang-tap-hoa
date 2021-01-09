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

		public frmQuanLy()
		{
			InitializeComponent();
		}

		private void frmQuanLy_Load(object sender, EventArgs e)
		{
			dgvHangHoa.DataSource = dsHangHoaBinding;
			LoadDanhSachHangHoaAll();
			LoadDanhSachLoaiHangHoa();
			AddDataBindingHangHoa();

			InitThongKeBar();
			InitDataGridview();
		}

		void LoadDanhSachHangHoaAll()
		{
			dsHangHoaBinding.DataSource = HangHoaDAO.Instance.GetAllHangHoa();
		}

		void LoadDanhSachLoaiHangHoa()
		{
			cbHangHoaLoai.DataSource = LoaiHangHoaDAO.Instance.GetAllLoaiHangHoa();
			cbHangHoaLoai.DisplayMember = "TenLoai";
			cbHangHoaLoai.ValueMember = "Id";
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

			cbHHTimKiemTrangThai.SelectedIndex = -1;
			cbHangHoaTimKiemLoaiHang.SelectedIndex = -1;
			cbHangHoaSapXep.SelectedIndex = 0;
		}
	}
}
