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
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(178, 69);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 0;
        label1.Text = "Name:";
        // 
        // nameTextBox
        // 
        nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        nameTextBox.Location = new Point(316, 62);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(250, 27);
        nameTextBox.TabIndex = 1;
        // 
        // designationTextBox
        // 
        designationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        designationTextBox.Location = new Point(316, 120);
        designationTextBox.Name = "designationTextBox";
        designationTextBox.Size = new Size(250, 27);
        designationTextBox.TabIndex = 3;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(178, 127);
        label2.Name = "label2";
        label2.Size = new Size(92, 20);
        label2.TabIndex = 2;
        label2.Text = "Designation:";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(178, 185);
        label3.Name = "label3";
        label3.Size = new Size(115, 20);
        label3.TabIndex = 4;
        label3.Text = "Date Of Joining:";
        // 
        // salaryTextBox
        // 
        salaryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        salaryTextBox.Location = new Point(316, 238);
        salaryTextBox.Name = "salaryTextBox";
        salaryTextBox.Size = new Size(250, 27);
        salaryTextBox.TabIndex = 7;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(178, 245);
        label4.Name = "label4";
        label4.Size = new Size(52, 20);
        label4.TabIndex = 6;
        label4.Text = "Salary:";
        // 
        // dateOfJoining
        // 
        dateOfJoining.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dateOfJoining.Location = new Point(316, 180);
        dateOfJoining.Name = "dateOfJoining";
        dateOfJoining.Size = new Size(250, 27);
        dateOfJoining.TabIndex = 8;
        // 
        // AddOrUpdate
        // 
        AddOrUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        AddOrUpdate.Location = new Point(178, 300);
        AddOrUpdate.Name = "AddOrUpdate";
        AddOrUpdate.Size = new Size(183, 29);
        AddOrUpdate.TabIndex = 10;
        AddOrUpdate.Text = "Add";
        AddOrUpdate.UseVisualStyleBackColor = true;
        AddOrUpdate.Click += AddOrUpdate_Click;
        // 
        // Cancel
        // 
        Cancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        Cancel.Location = new Point(383, 300);
        Cancel.Name = "Cancel";
        Cancel.Size = new Size(183, 29);
        Cancel.TabIndex = 11;
        Cancel.Text = "Cancel";
        Cancel.UseVisualStyleBackColor = true;
        Cancel.Click += Cancel_Click;
        // 
        // EmployeeForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(714, 384);
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