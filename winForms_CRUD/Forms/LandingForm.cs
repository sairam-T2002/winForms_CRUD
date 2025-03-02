using Microsoft.Extensions.DependencyInjection;
using System.Data;
using winForms_CRUD.DAL;
using winForms_CRUD.Repositories.Interfaces;

namespace winForms_CRUD.Forms;

public partial class LandingForm : Form
{
    private readonly IServiceProvider _provider;
    private readonly IEmployeeRepo _repo;

    #region Constructor

    public LandingForm( ISQLite sqlite, IServiceProvider provider, IEmployeeRepo repo )
    {
        InitializeComponent();
        _provider = provider;
        _repo = repo;
        LoadTable();
    }

    #endregion

    #region Private Methods

    private async void LoadTable()
    {
        EmployeeTable.DataSource = await _repo.GetEmployees();
    }

    #endregion

    #region EvenHandlers

    private void AddEmployeeBtn_Click( object sender, EventArgs e )
    {
        var employeeForm = _provider.GetRequiredService<EmployeeForm>();
        if (employeeForm == null) return;

        if (employeeForm.ShowDialog() == DialogResult.OK)
        {
            LoadTable();
        }
    }

    #endregion


}
