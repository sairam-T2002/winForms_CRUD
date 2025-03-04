using System.Data;
using System.Data.SQLite;
using winForms_CRUD.DAL.Interfaces;

namespace winForms_CRUD.DAL
{
    public class SQLiteWrapper : IDAL
    {
        private readonly string _connectionString;
        private readonly string _dbPath;

        public SQLiteWrapper()
        {
            _dbPath = $"{AppDomain.CurrentDomain.BaseDirectory}App_Data\\appData.sqlite";
            _connectionString = $"Data Source={_dbPath};Version=3;";
            EnsureFileExist();
        }

        private void EnsureFileExist()
        {
            string directory = Path.GetDirectoryName(_dbPath) ?? "";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            if (!File.Exists(_dbPath))
            {
                SQLiteConnection.CreateFile(_dbPath);
            }
        }

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(_connectionString);
        }

        public int ExecuteNonQuery( string query, Dictionary<string, object?>? parameters = null )
        {
            using var connection = GetConnection();
            connection.Open();
            using var command = new SQLiteCommand(query, connection);
            AddParameters(command, parameters);
            return command.ExecuteNonQuery();
        }

        public async Task<int> ExecuteNonQueryAsync( string query, Dictionary<string, object?>? parameters = null )
        {
            using var connection = GetConnection();
            await connection.OpenAsync();
            using var command = new SQLiteCommand(query, connection);
            AddParameters(command, parameters);
            return await command.ExecuteNonQueryAsync();
        }

        public T? ExecuteScalar<T>( string query, Dictionary<string, object?>? parameters = null )
        {
            using var connection = GetConnection();
            connection.Open();
            using var command = new SQLiteCommand(query, connection);
            AddParameters(command, parameters);
            return (T)command.ExecuteScalar()!;
        }

        public async Task<T> ExecuteScalarAsync<T>( string query, Dictionary<string, object?>? parameters = null )
        {
            using var connection = GetConnection();
            await connection.OpenAsync();
            using var command = new SQLiteCommand(query, connection);
            AddParameters(command, parameters);
            return (T)(await command.ExecuteScalarAsync())!;
        }

        public DataSet ExecuteQuery( string query, Dictionary<string, object?>? parameters = null )
        {
            using var connection = GetConnection();
            connection.Open();
            using var command = new SQLiteCommand(query, connection);
            AddParameters(command, parameters);
            using var adapter = new SQLiteDataAdapter(command);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }

        public async Task<DataSet> ExecuteQueryAsync( string query, Dictionary<string, object?>? parameters = null )
        {
            using var connection = GetConnection();
            await connection.OpenAsync();
            using var command = new SQLiteCommand(query, connection);
            AddParameters(command, parameters);
            using var adapter = new SQLiteDataAdapter(command);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }

        private void AddParameters( SQLiteCommand command, Dictionary<string, object?>? parameters )
        {
            if (parameters == null) return;
            foreach (var param in parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }
        }

        public void Dispose()
        {
            // No explicit resources to dispose
        }
    }
}
