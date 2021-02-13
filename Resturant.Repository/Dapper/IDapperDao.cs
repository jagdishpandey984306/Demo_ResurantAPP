using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Resturant.Repository.Dapper
{
    public interface IDapperDao
    {
        List<T0> ExecuteQuery<T0>(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
        List<object> ExecuteQuery<T0, T1>(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
    }
}
