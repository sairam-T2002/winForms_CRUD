using Microsoft.Extensions.DependencyInjection;
using winForms_CRUD.Models;
using winForms_CRUD.Repositories.Interfaces;

namespace winForms_CRUD.Forms;

public partial class LandingForm : Form
{
    private readonly IServiceProvider _provider;
    private readonly IEmployeeRepo _repo;

    #region Constructor

    public LandingForm( IServiceProvider provider, IEmployeeRepo repo )
    {
        InitializeComponent();
        _provider = provider;
        _repo = repo;
        LoadTable();
        Utils.SetPlaceholder(Search, "Search by Name");
    }

    #endregion

    #region Private Methods

    private async void LoadTable()
    {
        EmployeeTable.DataSource = await _repo.GetEmployees();
        EmployeeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    #endregion

    #region Event Handlers

    private void AddEmployeeBtn_Click( object sender, EventArgs e )
    {
        var employeeForm = _provider.GetRequiredService<EmployeeForm>();
        if (employeeForm == null) return;

        employeeForm.StartPosition = FormStartPosition.Manual;
        employeeForm.Location = new Point( Location.X + (Width - employeeForm.Width) / 2, Location.Y + (Height - employeeForm.Height) / 2 );
        employeeForm.ShowDialog(this);

        if (employeeForm.DialogResult == DialogResult.OK) LoadTable();
    }

    private void EditEmployeeBtn_Click( object sender, EventArgs e )
    {
        if (EmployeeTable.CurrentRow != null)
        {
            var selectedRow = EmployeeTable.CurrentRow;
            var employee = new Employee
            {
                Id = Convert.ToInt32(selectedRow.Cells["id"].Value),
                Name = selectedRow.Cells["name"].Value.ToString()!,
                Designation = selectedRow.Cells["designation"].Value.ToString()!,
                DateOfJoining = selectedRow.Cells["dateofjoining"].Value.ToString()!,
                Salary = Convert.ToDouble(selectedRow.Cells["salary"].Value!),
            };
            var employeeForm = _provider.GetRequiredService<EmployeeForm>();
            if (employeeForm == null) return;

            employeeForm.SetValues(employee);

            employeeForm.StartPosition = FormStartPosition.Manual;
            employeeForm.Location = new Point( Location.X + (Width - employeeForm.Width) / 2, Location.Y + (Height - employeeForm.Height) / 2 );
            employeeForm.ShowDialog(this);

            if (employeeForm.DialogResult == DialogResult.OK) LoadTable();
        }
        else
        {
            MessageBox.Show("No row selected", "Warning");
        }
    }

    private async void DeleteEmployeeBtn_Click( object sender, EventArgs e )
    {
        if (EmployeeTable.CurrentRow != null)
        {
            var selectedRow = EmployeeTable.CurrentRow;
            int employeeId = Convert.ToInt32(selectedRow.Cells["id"].Value);

            if (await _repo.DeleteEmployee(employeeId)) LoadTable();
        }
        else
        {
            MessageBox.Show("No row selected", "Warning");
        }
    }

    private async void Search_KeyDown( object sender, KeyEventArgs e )
    {
        string searchText = Search.Text;
        EmployeeTable.DataSource = await _repo.GetEmployeesByName(searchText);
    }

    #endregion
}
