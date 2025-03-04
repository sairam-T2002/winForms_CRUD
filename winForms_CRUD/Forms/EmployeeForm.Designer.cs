namespace winForms_CRUD.Forms;

partial class EmployeeForm
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
        label1 = new Label();
        nameTextBox = new TextBox();
        designationTextBox = new TextBox();
        label2 = new Label();
        label3 = new Label();
        salaryTextBox = new TextBox();
        label4 = new Label();
        dateOfJoining = new DateTimePicker();
        AddOrUpdate = new Button();
        Cancel = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(140, 43);
        label1.Name = "label1";
        label1.Size = new Size(42, 15);
        label1.TabIndex = 0;
        label1.Text = "Name:";
        // 
        // nameTextBox
        // 
        nameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        nameTextBox.Location = new Point(260, 37);
        nameTextBox.Margin = new Padding(3, 2, 3, 2);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(213, 23);
        nameTextBox.TabIndex = 1;
        // 
        // designationTextBox
        // 
        designationTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        designationTextBox.Location = new Point(260, 81);
        designationTextBox.Margin = new Padding(3, 2, 3, 2);
        designationTextBox.Name = "designationTextBox";
        designationTextBox.Size = new Size(213, 23);
        designationTextBox.TabIndex = 3;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(140, 86);
        label2.Name = "label2";
        label2.Size = new Size(73, 15);
        label2.TabIndex = 2;
        label2.Text = "Designation:";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(140, 130);
        label3.Name = "label3";
        label3.Size = new Size(91, 15);
        label3.TabIndex = 4;
        label3.Text = "Date Of Joining:";
        // 
        // salaryTextBox
        // 
        salaryTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        salaryTextBox.Location = new Point(260, 169);
        salaryTextBox.Margin = new Padding(3, 2, 3, 2);
        salaryTextBox.Name = "salaryTextBox";
        salaryTextBox.Size = new Size(213, 23);
        salaryTextBox.TabIndex = 7;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(140, 175);
        label4.Name = "label4";
        label4.Size = new Size(41, 15);
        label4.TabIndex = 6;
        label4.Text = "Salary:";
        // 
        // dateOfJoining
        // 
        dateOfJoining.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        dateOfJoining.Location = new Point(260, 126);
        dateOfJoining.Margin = new Padding(3, 2, 3, 2);
        dateOfJoining.Name = "dateOfJoining";
        dateOfJoining.Size = new Size(213, 23);
        dateOfJoining.TabIndex = 8;
        // 
        // AddOrUpdate
        // 
        AddOrUpdate.Anchor = AnchorStyles.Left;
        AddOrUpdate.Location = new Point(140, 216);
        AddOrUpdate.Margin = new Padding(3, 2, 3, 2);
        AddOrUpdate.Name = "AddOrUpdate";
        AddOrUpdate.Size = new Size(160, 32);
        AddOrUpdate.TabIndex = 10;
        AddOrUpdate.Text = "Add";
        AddOrUpdate.UseVisualStyleBackColor = true;
        AddOrUpdate.Click += AddOrUpdate_Click;
        // 
        // Cancel
        // 
        Cancel.Anchor = AnchorStyles.Right;
        Cancel.Location = new Point(313, 216);
        Cancel.Margin = new Padding(3, 2, 3, 2);
        Cancel.Name = "Cancel";
        Cancel.Size = new Size(160, 32);
        Cancel.TabIndex = 11;
        Cancel.Text = "Cancel";
        Cancel.UseVisualStyleBackColor = true;
        Cancel.Click += Cancel_Click;
        // 
        // EmployeeForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(619, 288);
        Controls.Add(Cancel);
        Controls.Add(AddOrUpdate);
        Controls.Add(dateOfJoining);
        Controls.Add(salaryTextBox);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(designationTextBox);
        Controls.Add(label2);
        Controls.Add(nameTextBox);
        Controls.Add(label1);
        Margin = new Padding(3, 2, 3, 2);
        Name = "EmployeeForm";
        Text = "Add Employee";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox nameTextBox;
    private TextBox designationTextBox;
    private Label label2;
    private Label label3;
    private TextBox salaryTextBox;
    private Label label4;
    private DateTimePicker dateOfJoining;
    private Button AddOrUpdate;
    private Button Cancel;
}