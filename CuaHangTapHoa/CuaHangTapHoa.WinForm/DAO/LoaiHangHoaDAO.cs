using CuaHangTapHoa.WinForm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTapHoa.WinForm.DAO
{
	public class LoaiHangHoaDAO
	{
		private static LoaiHangHoaDAO _instance;

		public static LoaiHangHoaDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new LoaiHangHoaDAO();
				}
				return _instance;
			}
		}

		private LoaiHangHoaDAO() { }

		public List<LoaiHangHoa> GetAllLoaiHangHoa()
		{
			string query = "EXEC usp_LoaiHangHoa_GetAll";
			List<LoaiHangHoa> loaiHangHoas = new List<LoaiHangHoa>();

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in data.Rows)
			{
				loaiHangHoas.Add(new LoaiHangHoa(row));
			}

			return loaiHangHoas;
		}
	}
}
