using winForms_CRUD.Models;
using winForms_CRUD.Repositories.Interfaces;

namespace winForms_CRUD.Forms;

public partial class EmployeeForm : Form
{
    private readonly IEmployeeRepo _repo;
    public EmployeeForm( IEmployeeRepo repo)
    {
        InitializeComponent();
        _repo = repo;
        DialogResult = DialogResult.Cancel;
    }

    private bool IsValid()
    {
        if (string.IsNullOrEmpty(nameTextBox.Text))
        {
            MessageBox.Show("Please Enter Name","Field Empty");
            nameTextBox.Focus();
            return false;
        }
        if (string.IsNullOrEmpty(designationTextBox.Text))
        {
            MessageBox.Show("Please Enter Designation", "Field Empty");
            designationTextBox.Focus();
            return false;
        }
        if (string.IsNullOrEmpty(dateOfJoining.Text))
        {
            MessageBox.Show("Please Enter Date Of Joining", "Field Empty");
            dateOfJoining.Focus();
            return false;
        }
        if (string.IsNullOrEmpty(salaryTextBox.Text))
        {
            MessageBox.Show("Please Enter Salary", "Field Empty");
            salaryTextBox.Focus();
            return false;
        }
        return true;
    }

    private async void AddOrUpdate_Click( object sender, EventArgs e )
    {
        if (!IsValid()) return;

        DialogResult = DialogResult.OK;

        var temp = new Employee
        {
            Name = nameTextBox.Text,
            Designation = designationTextBox.Text,
            DateOfJoining = dateOfJoining.Text,
            Salary = double.Parse(salaryTextBox.Text)
        };

        await _repo.InsertEmployee(temp);
        Close();
    }

    private void Cancel_Click( object sender, EventArgs e )
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
