using Dapper;
using DapperCRUD.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.Repositories
{
    public class CategoryRepository : BaseRepository, IBaseRepository<Category>
    {
        public int DeleteData(Category dataItem)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllData()
        {
            List<Category> dataItemList = new List<Category>();
            string Query = "SELECT * FROM [Dapper].[production].categories";
            dataItemList = connection.Query<Category>(Query).ToList();
            return dataItemList;
        }

        public Category GetDataById(int dataItemId)
        {
            Category dataItem = null;
            string Query = $"SELECT * FROM [Dapper].[production].categories where category_id = {dataItemId}";
            dataItem = connection.QueryFirstOrDefault<Category>(Query);
            return dataItem;
        }

        public int InsertData(Category dataItem)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(Category dataItem)
        {
            throw new NotImplementedException();
        }
    }
}
