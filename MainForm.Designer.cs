using System.Windows.Forms;

namespace Learning_c_sharp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtID;
        private TextBox txtEmp_Id;
        private DataGridView dataGridView1;
        private Label lblName;
        private Label lblAge;
        private Label lblEmpId;

        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmp_Id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(30, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";

            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(150, 10);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(100, 20);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age:";

            // 
            // lblEmpId
            // 
            this.lblEmpId.Location = new System.Drawing.Point(30, 50);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(100, 20);
            this.lblEmpId.TabIndex = 10;
            this.lblEmpId.Text = "Employee ID:";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;

            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(150, 30);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 4;

            // 
            // txtEmp_Id
            // 
            this.txtEmp_Id.Location = new System.Drawing.Point(30, 70);
            this.txtEmp_Id.Name = "txtEmp_Id";
            this.txtEmp_Id.Size = new System.Drawing.Size(100, 20);
            this.txtEmp_Id.TabIndex = 6;

            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(30, 150);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(210, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 150);
            this.dataGridView1.TabIndex = 7;

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmp_Id);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Name = "MainForm";
            this.Text = "CRUD Example";
            this.Load += new System.EventHandler(this.MainForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
    }
