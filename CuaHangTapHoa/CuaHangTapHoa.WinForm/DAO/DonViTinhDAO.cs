using CuaHangTapHoa.WinForm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTapHoa.WinForm.DAO
{
	public class DonViTinhDAO
	{
		private static DonViTinhDAO _instance;

		public static DonViTinhDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new DonViTinhDAO();
				}
				return _instance;
			}
		}

		private DonViTinhDAO() { }

		public List<DonViTinh> GetAllDonViTinh()
		{
			string query = "EXEC usp_DonViTinh_GetAll";
			List<DonViTinh> donViTinhs = new List<DonViTinh>();

			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in data.Rows)
			{
				donViTinhs.Add(new DonViTinh(row));
			}

			return donViTinhs;
		}
	}
}
