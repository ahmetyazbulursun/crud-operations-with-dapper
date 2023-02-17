using DapperCRUD.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperCRUD.Repositories
{
    public class BrandRepository : BaseRepository, IBaseRepository<Brand>
    {
        public int DeleteData(Brand dataItem)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAllData()
        {
            List<Brand> dataItemList = new List<Brand>();
            string Query = "SELECT * FROM [Dapper].[production].[brands]";
            dataItemList = connection.Query<Brand>(Query).ToList();
            return dataItemList;
        }

        public Brand GetDataById(int dataItemId)
        {
            Brand dataItem = null;
            string Query = $"SELECT * FROM [Dapper].[production].[brands] where brand_id = {dataItemId}";
            dataItem = connection.QueryFirstOrDefault<Brand>(Query);
            return dataItem;
        }

        public int InsertData(Brand dataItem)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(Brand dataItem)
        {
            throw new NotImplementedException();
        }
    }
}
