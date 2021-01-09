using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTapHoa.WinForm.DTO
{
	public class HangHoaRead
	{
		public int Id { get; set; }
		public string TenHang { get; set; }
		public string TenLoai { get; set; }
		public string DonViTinh { get; set; }
		public decimal GiaVon { get; set; }
		public decimal GiaBan { get; set; }
		public int TonKho { get; set; }
		public string HinhAnh { get; set; }
		public string MoTa { get; set; }
		public bool TrangThai { get; set; }

		public decimal LoiNhuan => GiaBan - GiaVon; 
		public string GiaBanStr => GiaBan.ToString("###,###,###");
		public string GiaVonStr => GiaVon.ToString("###,###,###");
		
		public HangHoaRead()
		{

		}

		public HangHoaRead(int id, string tenHang, string tenLoai, string donViTinh, decimal giaVon, decimal giaBan, int tonKho, string hinhAnh, string moTa, bool trangThai)
		{
			Id = id;
			TenHang = tenHang;
			TenLoai = tenLoai;
			DonViTinh = donViTinh;
			GiaVon = giaVon;
			GiaBan = giaBan;
			TonKho = tonKho;
			HinhAnh = hinhAnh;
			MoTa = moTa;
			TrangThai = trangThai;
		}

		public HangHoaRead(DataRow row)
		{
			Id = Convert.ToInt32(row["Id"].ToString());
			TenHang = row["TenHang"].ToString();
			TenLoai = row["TenLoai"].ToString();
			DonViTinh = row["TenDonViTinh"].ToString();
			GiaVon = Convert.ToDecimal(row["GiaVon"].ToString());
			GiaBan = Convert.ToDecimal(row["GiaBan"].ToString());
			TonKho = Convert.ToInt32(row["TonKho"].ToString());
			HinhAnh = row["HinhAnh"].ToString();
			MoTa = row["MoTa"].ToString() ?? "";
			TrangThai = Convert.ToBoolean(row["TrangThai"].ToString());
		}
	}
}
