using System.Data;

namespace winForms_CRUD.DAL.Interfaces;

public interface IDAL : IDisposable
{
    int ExecuteNonQuery( string query, Dictionary<string, object?>? parameters = null );
    Task<int> ExecuteNonQueryAsync( string query, Dictionary<string, object?>? parameters = null );
    T? ExecuteScalar<T>( string query, Dictionary<string, object?>? parameters = null );
    Task<T> ExecuteScalarAsync<T>( string query, Dictionary<string, object?>? parameters = null );
    DataSet ExecuteQuery( string query, Dictionary<string, object?>? parameters = null );
    Task<DataSet> ExecuteQueryAsync( string query, Dictionary<string, object?>? parameters = null );
}
