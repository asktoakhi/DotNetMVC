using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;


namespace Core.Dapper
{
    public interface IDapperContext :IDisposable
    {
        T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        T GetDynamic<T>(Expression<Func<T, bool>> predicate);
        List<T> GetAllDynamic<T>(Expression<Func<T, bool>> predicate);
        int Insert<T>(T obj);
        bool Update<T>(T obj);
        bool Delete<T>(T obj);
        T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>> GetMultiple<T1, T2, T3, T4, T5, T6>(string sql, DynamicParameters parameters,
                                   Func<GridReader, IEnumerable<T1>> func1,
                                   Func<GridReader, IEnumerable<T2>> func2,
                                   Func<GridReader, IEnumerable<T3>> func3,
                                   Func<GridReader, IEnumerable<T4>> func4,
                                   Func<GridReader, IEnumerable<T5>> func5,
                                   Func<GridReader, IEnumerable<T6>> func6
            );
        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>> GetMultiple<T1, T2, T3, T4>(string sql, DynamicParameters parameters,
                                   Func<GridReader, IEnumerable<T1>> func1,
                                   Func<GridReader, IEnumerable<T2>> func2,
                                   Func<GridReader, IEnumerable<T3>> func3,
                                   Func<GridReader, IEnumerable<T4>> func4
            );
        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>> GetMultiple<T1, T2, T3, T4, T5>(string sql, DynamicParameters parameters,
                                   Func<GridReader, IEnumerable<T1>> func1,
                                   Func<GridReader, IEnumerable<T2>> func2,
                                   Func<GridReader, IEnumerable<T3>> func3,
                                   Func<GridReader, IEnumerable<T4>> func4,
                                   Func<GridReader, IEnumerable<T5>> func5
            );
    }
}
