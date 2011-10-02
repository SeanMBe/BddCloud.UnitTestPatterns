using System;
using System.Data.SqlClient;
using MavenThought.Commons;

namespace BddCloud.UnitTestPatterns.Common
{
    public class DependencyForDatabaseRepository : IDependencyForDatabaseRepository
    {
        private SqlConnection _connection;
        private const string _connectionString = "Data Source=localhost;Initial Catalog=TwitterStats;Integrated Security=SSPI;";

        public DependencyForDatabaseRepository()
        {
            _connection = new SqlConnection(_connectionString);            
        }

        public DateTime RecordTwitterOnlineStatus(bool isTwitterOnline)
        {
            var recordedAtThisTime = DateTime.Now;
            var sqlCommand = new SqlCommand(string.Format("insert into TwitterOnline VALUES (#{0}#, {1})", recordedAtThisTime, isTwitterOnline), _connection);
            sqlCommand.ExecuteNonQuery();
            return recordedAtThisTime;
        }

        public Pair<DateTime, bool> LastOnlineStatus
        {
            get
            {
                var sqlCommand = new SqlCommand(string.Format("select time, status from TwitterOnline order by date desc"), _connection);
                var dataReader = sqlCommand.ExecuteReader();
                var hasRecord = dataReader.Read();
                return hasRecord ? new Pair<DateTime, bool>((DateTime)dataReader.GetValue(0),(bool)dataReader.GetValue(1)) : null; 
            }
        }
    }
}