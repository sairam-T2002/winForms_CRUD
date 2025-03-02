using System.Data;
using winForms_CRUD.DAL;
using winForms_CRUD.Models;
using winForms_CRUD.Repositories.Interfaces;

namespace winForms_CRUD.Repositories;

public class EmployeeRepo : IEmployeeRepo
{
    private readonly ISQLite _sqlite;

    public EmployeeRepo( ISQLite sqlite)
    {
        _sqlite = sqlite;
    }
    public async void CreateEmployeeTable()
    {
        try
        {
            string sql = @"CREATE TABLE IF NOT EXISTS employee (
                           id INTEGER PRIMARY KEY AUTOINCREMENT,
                           name TEXT NOT NULL,
                           designation TEXT NOT NULL,
                           dateofjoining TEXT NOT NULL,
                           salary REAL NOT NULL
                           );";
            await _sqlite.ExecuteNonQueryAsync(sql);
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
            string sql = @"INSERT INTO Employee (name, designation, dateofjoining, salary) VALUES 
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
}
