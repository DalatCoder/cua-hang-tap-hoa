using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTapHoa.WinForm.DTO
{
	public class LoaiHangHoa
	{
		public int Id { get; set; }
		public string TenLoai { get; set; }

		public LoaiHangHoa()
		{

		}

		public LoaiHangHoa(int id, string tenLoai)
		{
			Id = id;
			TenLoai = tenLoai;
		}

		public LoaiHangHoa(DataRow row)
		{
			Id = Convert.ToInt32(row["Id"].ToString());
			TenLoai = row["TenLoai"].ToString();
		}
	}
}
