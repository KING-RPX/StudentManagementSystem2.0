using StudentManagementSystem2._0.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem2._0
{
    public partial class Form1 : Form
    {
        private readonly StudentManager studentManager = new StudentManager();

        public Form1()
        {
            InitializeComponent();
        }

        // Load all students into the DataGridView (called on form load or update button click)
        private void LoadStudents()
        {
            dataGridViewStudents.Rows.Clear();
            foreach (var student in studentManager.GetAllStudents())
            {
                dataGridViewStudents.Rows.Add(student);
            }
        }

        // Add a student when the 'Add Student' button is clicked
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                studentManager.AddStudent(txtStudentID.Text, txtName.Text, txtAge.Text, txtCourse.Text);
                LoadStudents();  // Update the DataGridView
                ClearInputs();   // Clear input fields
                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Show error message
                MessageBox.Show("Failed to add student. Please check input fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update an existing student when the 'Update Student' button is clicked
        private void btnUpdateStudents_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool updated = studentManager.UpdateStudent(txtStudentID.Text, txtName.Text, txtAge.Text, txtCourse.Text);
                if (updated) LoadStudents();  // Update the DataGridView if successful
                ClearInputs();  // Clear input fields after updating
                                // Show success message
                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Show error message if update failed
                MessageBox.Show("Failed to update student. Student ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete a student when the 'Delete Student' button is clicked
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                string studentId = dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString();
                bool deleted = studentManager.DeleteStudent(studentId);
                if (deleted) LoadStudents();  // Update the DataGridView if successful
                ClearInputs();  // Clear input fields after deleting
                MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Show error message if deletion failed
                MessageBox.Show("Failed to delete student. Student ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Generate and display the summary (total students and average age)
        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            var (totalStudents, averageAge) = studentManager.GenerateSummary();
            lblStudentCount.Text = $"Total Students: {totalStudents}";
            lblAverageAge.Text = $"Average Age: {averageAge:F2}";
        }

        // Helper method to validate input fields
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("All fields must be filled.", "Validation Error");
                return false;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 0)
            {
                MessageBox.Show("Age must be a valid number.", "Validation Error");
                return false;
            }

            return true;
        }


        // Clear the input fields after performing actions
        private void ClearInputs()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCourse.Clear();
        }

        // Event handlers for text change events (can be used for real-time validation or other purposes)
        private void txtStudentID_TextChanged(object sender, EventArgs e) 
        { 

        }
        private void txtCourse_TextChanged(object sender, EventArgs e) 
        {

        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtAge_TextChanged(object sender, EventArgs e) 
        { 

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents(); 
            
        }

        // Placeholder click event handlers for labels 
        private void lblStudentCount_Click(object sender, EventArgs e) 
        {

        }
        private void lblAverageAge_Click(object sender, EventArgs e)
        {
            
        }
        private void lblage_Click(object sender, EventArgs e)
        {
            
        }
        private void lblname_Click(object sender, EventArgs e) 
        { 

        }
        private void lblCourse_Click(object sender, EventArgs e)
        {

        }
        private void lblstudentid_Click(object sender, EventArgs e) 
        {
        
        }

        // Event handler for the DataGridView cell click (can be used to load data into input fields for updating)
        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtStudentID.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAge.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCourse.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
    }
}
