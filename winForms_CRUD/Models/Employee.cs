namespace winForms_CRUD.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Designation { get; set; } = string.Empty;
    public string DateOfJoining { get; set; } = string.Empty;
    public double Salary { get; set; }
}
