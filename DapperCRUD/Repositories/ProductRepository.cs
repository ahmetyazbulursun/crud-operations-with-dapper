using Dapper;
using DapperCRUD.Models.StoreProcedure;
using DapperCRUD.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.Repositories
{
    public class ProductRepository : BaseRepository, IBaseRepository<UpdateProductSP>
    {
        public int DeleteData(UpdateProductSP dataItem)
        {
            var SPParams = new { id = dataItem.product_id };
            return connection.Execute("DeleteProductById", SPParams, commandType: System.Data.CommandType.StoredProcedure);
        }

        public List<ProductListViewModel> GetAllDataList()
        {
            List<ProductListViewModel> dataItemList = new List<ProductListViewModel>();
            string Query = @"Select P.product_id, P.product_name, B.brand_name, C.category_name,
                             P.model_year, P.list_price From production.products P
                             Inner Join production.brands B on P.brand_id = B.brand_id
                             Inner Join production.categories C on P.category_id = c.category_id";
            dataItemList = connection.Query<ProductListViewModel>(Query).ToList();
            return dataItemList;
        }

        public int InsertData(UpdateProductSP dataItem)
        {
            var SPParams = new
            {
                product_name = dataItem.product_name,
                brand_id = dataItem.brand_id,
                category_id = dataItem.category_id,
                model_year = dataItem.model_year,
                list_price = dataItem.list_price
            };
            return connection.Execute("InsertProduct", SPParams, commandType: System.Data.CommandType.StoredProcedure);
        }

        public int UpdateData(UpdateProductSP dataItem)
        {
            return connection.Execute("UpdateProduct", dataItem, commandType: System.Data.CommandType.StoredProcedure);
        }







        public List<UpdateProductSP> GetAllData()
        {
            throw new NotImplementedException();
        }

        public UpdateProductSP GetDataById(int dataItemId)
        {
            UpdateProductSP dataItem = null;
            string Query = $"Select * From production.products Where product_id = {dataItemId}";
            dataItem = connection.QueryFirstOrDefault<UpdateProductSP>(Query);
            return dataItem;
        }
    }
}
