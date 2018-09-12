using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace DapperWrapper
{
    public class SqlExecutor : IDbExecutor
    {
        readonly IDbConnection _dbConnection;

        public SqlExecutor(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public int Execute(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _dbConnection.Execute(
                sql,
                param,
                transaction,
                commandTimeout,
                commandType);
        }

        public Task<int> ExecuteAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _dbConnection.ExecuteAsync(
                sql,
                param,
                transaction,
                commandTimeout,
                commandType);
        }

        public IEnumerable<dynamic> Query(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _dbConnection.Query(
                sql,
                param,
                transaction,
                buffered,
                commandTimeout,
                commandType);
        }

        public Task<IEnumerable<dynamic>> QueryAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _dbConnection.QueryAsync(
                sql,
                param,
                transaction,
                commandTimeout,
                commandType);
        }

        public IEnumerable<T> Query<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _dbConnection.Query<T>(
                sql,
                param,
                transaction,
                buffered,
                commandTimeout,
                commandType);
        }

        public Task<IEnumerable<T>> QueryAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _dbConnection.QueryAsync<T>(
                sql,
                param,
                transaction,
                commandTimeout,
                commandType);
        }

        public void Dispose()
        {
            _dbConnection.Dispose();
        }
    }
}