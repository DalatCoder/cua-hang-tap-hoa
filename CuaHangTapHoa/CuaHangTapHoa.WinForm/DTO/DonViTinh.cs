using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTapHoa.WinForm.DTO
{
	public class DonViTinh
	{
		public int Id { get; set; }
		public string TenDonViTinh { get; set; }

		public DonViTinh()
		{

		}

		public DonViTinh(int id, string tenDonViTinh)
		{
			Id = id;
			TenDonViTinh = tenDonViTinh;
		}

		public DonViTinh(DataRow row)
		{
			Id = Convert.ToInt32(row["Id"].ToString());
			TenDonViTinh = row["TenDonViTinh"].ToString();
		}
	}
}
