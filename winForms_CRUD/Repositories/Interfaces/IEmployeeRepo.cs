using System.Data;
using winForms_CRUD.Models;

namespace winForms_CRUD.Repositories.Interfaces;

public interface IEmployeeRepo
{
    void CreateEmployeeTable();
    Task<bool> InsertEmployee( Employee employee );
    Task<bool> UpdateEmployee( Employee employee );
    Task<bool> DeleteEmployee( int id );
    Task<DataTable> GetEmployees();
    Task<DataTable> GetEmployeesByName( string searchText );
}
