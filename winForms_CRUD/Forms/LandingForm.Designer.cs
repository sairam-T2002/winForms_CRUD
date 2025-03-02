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
        ((System.ComponentModel.ISupportInitialize)EmployeeTable).BeginInit();
        SuspendLayout();
        // 
        // AddEmployeeBtn
        // 
        AddEmployeeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        AddEmployeeBtn.Location = new Point(12, 56);
        AddEmployeeBtn.Name = "AddEmployeeBtn";
        AddEmployeeBtn.Size = new Size(748, 42);
        AddEmployeeBtn.TabIndex = 0;
        AddEmployeeBtn.Text = "Add Employee";
        AddEmployeeBtn.UseVisualStyleBackColor = true;
        AddEmployeeBtn.Click += AddEmployeeBtn_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(748, 44);
        label1.TabIndex = 1;
        label1.Text = "Employee Management";
        label1.TextAlign = ContentAlignment.TopCenter;
        // 
        // EmployeeTable
        // 
        EmployeeTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        EmployeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EmployeeTable.Location = new Point(12, 113);
        EmployeeTable.MultiSelect = false;
        EmployeeTable.Name = "EmployeeTable";
        EmployeeTable.RowHeadersWidth = 51;
        EmployeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        EmployeeTable.Size = new Size(748, 325);
        EmployeeTable.TabIndex = 2;
        // 
        // LandingForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(772, 450);
        Controls.Add(EmployeeTable);
        Controls.Add(label1);
        Controls.Add(AddEmployeeBtn);
        Name = "LandingForm";
        Text = "Employee App";
        ((System.ComponentModel.ISupportInitialize)EmployeeTable).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button AddEmployeeBtn;
    private Label label1;
    private DataGridView EmployeeTable;
}