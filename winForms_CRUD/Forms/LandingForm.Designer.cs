namespace winForms_CRUD.Forms;

partial class LandingForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        AddEmployeeBtn = new Button();
        label1 = new Label();
        EmployeeTable = new DataGridView();
        DeleteEmployeeBtn = new Button();
        EditEmployeeBtn = new Button();
        Search = new TextBox();
        ((System.ComponentModel.ISupportInitialize)EmployeeTable).BeginInit();
        SuspendLayout();
        // 
        // AddEmployeeBtn
        // 
        AddEmployeeBtn.Location = new Point(10, 42);
        AddEmployeeBtn.Margin = new Padding(3, 2, 3, 2);
        AddEmployeeBtn.Name = "AddEmployeeBtn";
        AddEmployeeBtn.Size = new Size(179, 32);
        AddEmployeeBtn.TabIndex = 0;
        AddEmployeeBtn.Text = "Add Employee";
        AddEmployeeBtn.UseVisualStyleBackColor = true;
        AddEmployeeBtn.Click += AddEmployeeBtn_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(10, 7);
        label1.Name = "label1";
        label1.Size = new Size(840, 33);
        label1.TabIndex = 1;
        label1.Text = "Employee Management";
        label1.TextAlign = ContentAlignment.TopCenter;
        // 
        // EmployeeTable
        // 
        EmployeeTable.AllowUserToAddRows = false;
        EmployeeTable.AllowUserToDeleteRows = false;
        EmployeeTable.AllowUserToResizeRows = false;
        EmployeeTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        EmployeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EmployeeTable.EditMode = DataGridViewEditMode.EditProgrammatically;
        EmployeeTable.Location = new Point(10, 128);
        EmployeeTable.Margin = new Padding(3, 2, 3, 2);
        EmployeeTable.MultiSelect = false;
        EmployeeTable.Name = "EmployeeTable";
        EmployeeTable.RowHeadersWidth = 51;
        EmployeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        EmployeeTable.ShowEditingIcon = false;
        EmployeeTable.Size = new Size(840, 327);
        EmployeeTable.TabIndex = 2;
        // 
        // DeleteEmployeeBtn
        // 
        DeleteEmployeeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        DeleteEmployeeBtn.Location = new Point(728, 42);
        DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
        DeleteEmployeeBtn.Size = new Size(122, 32);
        DeleteEmployeeBtn.TabIndex = 3;
        DeleteEmployeeBtn.Text = "Delete";
        DeleteEmployeeBtn.UseVisualStyleBackColor = true;
        DeleteEmployeeBtn.Click += DeleteEmployeeBtn_Click;
        // 
        // EditEmployeeBtn
        // 
        EditEmployeeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        EditEmployeeBtn.Location = new Point(600, 42);
        EditEmployeeBtn.Name = "EditEmployeeBtn";
        EditEmployeeBtn.Size = new Size(122, 32);
        EditEmployeeBtn.TabIndex = 4;
        EditEmployeeBtn.Text = "Edit";
        EditEmployeeBtn.UseVisualStyleBackColor = true;
        EditEmployeeBtn.Click += EditEmployeeBtn_Click;
        // 
        // Search
        // 
        Search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Search.Location = new Point(10, 89);
        Search.Name = "Search";
        Search.Size = new Size(330, 23);
        Search.TabIndex = 5;
        Search.KeyUp += Search_KeyDown;
        // 
        // LandingForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(862, 464);
        Controls.Add(Search);
        Controls.Add(EditEmployeeBtn);
        Controls.Add(DeleteEmployeeBtn);
        Controls.Add(EmployeeTable);
        Controls.Add(label1);
        Controls.Add(AddEmployeeBtn);
        Margin = new Padding(3, 2, 3, 2);
        Name = "LandingForm";
        Text = "Employee App";
        ((System.ComponentModel.ISupportInitialize)EmployeeTable).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button AddEmployeeBtn;
    private Label label1;
    private DataGridView EmployeeTable;
    private Button DeleteEmployeeBtn;
    private Button EditEmployeeBtn;
    private TextBox Search;
}