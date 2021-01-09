using CuaHangTapHoa.WinForm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTapHoa.WinForm.DAO
{
	public class HangHoaDAO
	{
		private static HangHoaDAO _instance;

		public static HangHoaDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new HangHoaDAO();
				}
				return _instance;
			}
		}

		private HangHoaDAO() { }

		public List<HangHoaRead> GetAllHangHoa()
		{
			string query = "EXEC usp_HangHoa_GetAllActive";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			List<HangHoaRead> dsHangHoa = new List<HangHoaRead>();

			if (data.Rows.Count > 0)
			{
				foreach (DataRow row in data.Rows)
				{
					dsHangHoa.Add(new HangHoaRead(row));
				}
			}

			return dsHangHoa;
		}

		public List<HangHoaRead> GetAllHangHoaByLoaiHangHoa(int loaiHangHoaId)
		{
			string query = "EXEC usp_HangHoa_GetByCategory @LoaiHangHoaId";			

			DataTable data = DataProvider.Instance.ExecuteQuery(query, loaiHangHoaId);
			List<HangHoaRead> dsHangHoa = new List<HangHoaRead>();

			if (data.Rows.Count > 0)
			{
				foreach (DataRow row in data.Rows)
				{
					dsHangHoa.Add(new HangHoaRead(row));
				}
			}

			return dsHangHoa;
		}

		public List<HangHoaRead> SearchHangHoaByTenHangHoa(string tenHangHoa)
		{
			string query = "EXEC usp_HangHoa_SearchByName @TenHang";

			DataTable data = DataProvider.Instance.ExecuteQuery(query, tenHangHoa);
			List<HangHoaRead> dsHangHoa = new List<HangHoaRead>();

			if (data.Rows.Count > 0)
			{
				foreach (DataRow row in data.Rows)
				{
					dsHangHoa.Add(new HangHoaRead(row));
				}
			}

			return dsHangHoa;
		}
	}
}
