using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Learning_c_sharp
{
    public partial class MainForm : Form
    {
        private static string connectionString = "Server=localhost;Database=c_sharp_learning;Uid=root;Pwd=;";
        private List<Employee> employees;

        public MainForm()
        {
            InitializeComponent();
            employees = new List<Employee>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadEmployeesFromDatabase();
            dataGridView1.DataSource = employees;
        }

        private void LoadEmployeesFromDatabase()
        {
            employees.Clear();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT Emp_Id, Name, Age FROM Employees";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee
                            {
                                Emp_Id = reader["Emp_Id"].ToString(),
                                Name = reader["Name"].ToString(),
                                Age = Convert.ToInt32(reader["Age"])
                            });
                        }
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var empId = txtEmp_Id.Text;
            var name = txtName.Text;
            var age = int.Parse(txtAge.Text);

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "INSERT INTO Employees (Emp_Id, Name, Age) VALUES (@Emp_Id, @Name, @Age)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Emp_Id", empId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.ExecuteNonQuery();
                }
            }

            // Reload data and refresh the DataGridView
            LoadEmployeesFromDatabase();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;

            // Show success message
            MessageBox.Show("Employee successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var empId = txtEmp_Id.Text;
            var name = txtName.Text;
            var age = int.TryParse(txtAge.Text, out var result) ? result : 0;

            // Check if empId is provided
            if (string.IsNullOrEmpty(empId))
            {
                MessageBox.Show("Employee ID is required to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (age == 0)
            {
                MessageBox.Show("Please provide a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "UPDATE Employees SET Name = @Name, Age = @Age WHERE Emp_Id = @Emp_Id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Emp_Id", empId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.ExecuteNonQuery();
                }
            }

            // Reload data and refresh the DataGridView
            LoadEmployeesFromDatabase();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;

            // Show success message
            MessageBox.Show("Employee details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var empId = txtEmp_Id.Text;

            // Check if empId is provided
            if (string.IsNullOrEmpty(empId))
            {
                MessageBox.Show("Employee ID is required to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "DELETE FROM Employees WHERE Emp_Id = @Emp_Id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Emp_Id", empId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Reload data and refresh the DataGridView
            LoadEmployeesFromDatabase();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;

            // Show success message
            MessageBox.Show("Employee successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }

    public class Employee
    {
        public string Emp_Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
