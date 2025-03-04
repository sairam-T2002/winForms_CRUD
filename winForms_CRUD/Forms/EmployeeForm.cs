using winForms_CRUD.Models;
using winForms_CRUD.Repositories.Interfaces;

namespace winForms_CRUD.Forms;

public partial class EmployeeForm : Form
{
    private readonly IEmployeeRepo _repo;
    private int? _id;

    #region Constructor

    public EmployeeForm( IEmployeeRepo repo)
    {
        InitializeComponent();
        _repo = repo;
        DialogResult = DialogResult.Cancel;
    }

    #endregion

    #region Public Methods

    public void SetValues( Employee input )
    {
        _id = input.Id;
        nameTextBox.Text = input.Name;
        designationTextBox.Text = input.Designation;
        dateOfJoining.Text = input.DateOfJoining;
        salaryTextBox.Text = input.Salary.ToString();

        AddOrUpdate.Text = "Update";
        Text = $"Update Employee";
    }

    #endregion

    #region Private Methods

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
        if (!double.TryParse(salaryTextBox.Text, out double _))
        {
            MessageBox.Show("Please Enter Valid Salary", "Field Invalid");
            salaryTextBox.Focus();
            return false;
        }
        return true;
    }

    #endregion

    #region Event Handlers

    private async void AddOrUpdate_Click( object sender, EventArgs e )
    {
        if (!IsValid()) return;

        DialogResult = DialogResult.OK;

        var temp = new Employee
        {
            Id = _id ?? 0,
            Name = nameTextBox.Text,
            Designation = designationTextBox.Text,
            DateOfJoining = dateOfJoining.Text,
            Salary = double.Parse(salaryTextBox.Text)
        };
        if (_id == null)
            await _repo.InsertEmployee(temp);
        else
            await _repo.UpdateEmployee(temp);
        Close();
    }

    private void Cancel_Click( object sender, EventArgs e )
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    #endregion

}
