using System.Data;
using winForms_CRUD.DAL.Interfaces;
using winForms_CRUD.Models;
using winForms_CRUD.Repositories.Interfaces;

namespace winForms_CRUD.Repositories;

public class EmployeeRepo : IEmployeeRepo
{
    private readonly IDAL _sqlite;

    public EmployeeRepo( IDAL sqlite )
    {
        _sqlite = sqlite;
        CreateEmployeeTable();
    }
    public void CreateEmployeeTable()
    {
        try
        {
            string sql = @"CREATE TABLE IF NOT EXISTS employee (
                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                           Name TEXT NOT NULL,
                           Designation TEXT NOT NULL,
                           DateOfJoining TEXT NOT NULL,
                           Salary REAL NOT NULL
                           );";
            _sqlite.ExecuteNonQuery(sql);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, $"Exception in {nameof(CreateEmployeeTable)} Method");
        }
    }

    public async Task<bool> InsertEmployee(Employee employee)
    {
        try
        {
            string sql = @"INSERT INTO Employee (Name, Designation, DateOfJoining, Salary) VALUES 
                           (@Name, @Designation, @DateOfJoining, @Salary);";
            var dbParameters = new Dictionary<string, object?> 
            {
                {"@Name",employee.Name },
                {"@Designation",employee.Designation },
                {"@DateOfJoining",employee.DateOfJoining },
                {"@Salary",employee.Salary },
            };
            
            return await _sqlite.ExecuteNonQueryAsync(sql, dbParameters) == 1;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, $"Exception in {nameof(InsertEmployee)}");
            return false;
        }
    }

    public async Task<bool> UpdateEmployee( Employee employee )
    {
        try
        {
            string sql = @"UPDATE Employee SET Name = @Name, Designation = @Designation,
                           DateOfJoining = @DateOfJoining, Salary = @Salary WHERE Id = @Id";
            var dbParameters = new Dictionary<string, object?>
            {
                {"@Id",employee.Id },
                {"@Name",employee.Name },
                {"@Designation",employee.Designation },
                {"@DateOfJoining",employee.DateOfJoining },
                {"@Salary",employee.Salary },
            };

            return await _sqlite.ExecuteNonQueryAsync(sql, dbParameters) == 1;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, $"Exception in {nameof(UpdateEmployee)}");
            return false;
        }
    }

    public async Task<bool> DeleteEmployee( int id )
    {
        try
        {
            string sql = @"DELETE FROM Employee WHERE Id = @Id";
            var dbParameters = new Dictionary<string, object?> { {"@Id", id }, };

            return await _sqlite.ExecuteNonQueryAsync(sql, dbParameters) == 1;
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, $"Exception in {nameof(DeleteEmployee)}");
            return false;
        }
    }

    public async Task<DataTable> GetEmployees()
    {
        var output = new DataTable();
        try
        {
            string sql = "SELECT * FROM Employee;";
            return (await _sqlite.ExecuteQueryAsync(sql)).Tables[0];
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, $"Exception in {nameof(GetEmployees)}");
            return output;
        }
    }

    public async Task<DataTable> GetEmployeesByName( string searchText )
    {
        var output = new DataTable();
        try
        {
            string sql = "SELECT * FROM Employee WHERE Name LIKE @SearchText;";
            var dbParameters = new Dictionary<string, object?> { { "@SearchText", $"%{searchText}%" }, };
            return (await _sqlite.ExecuteQueryAsync(sql, dbParameters)).Tables[0];
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, $"Exception in {nameof(GetEmployeesByName)}");
            return output;
        }
    }
}
