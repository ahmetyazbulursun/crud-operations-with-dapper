﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.Repositories
{
    public interface IBaseRepository<T>
    {
        int InsertData(T dataItem);
        int UpdateData(T dataItem);
        int DeleteData(T dataItem);
        List<T> GetAllData();
        T GetDataById(int dataItemId);
    }
}
