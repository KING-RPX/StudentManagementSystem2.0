namespace StudentManagementSystem2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnGenerateSummary = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.btnUpdateStudents = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.BackColor = System.Drawing.Color.Transparent;
            this.lblstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblstudentid.Location = new System.Drawing.Point(70, 83);
            this.lblstudentid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(86, 18);
            this.lblstudentid.TabIndex = 0;
            this.lblstudentid.Text = "Student ID";
            this.lblstudentid.Click += new System.EventHandler(this.lblstudentid_Click);
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.BackColor = System.Drawing.Color.Transparent;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblage.Location = new System.Drawing.Point(70, 190);
            this.lblage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(36, 18);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "Age";
            this.lblage.Click += new System.EventHandler(this.lblage_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblname.Location = new System.Drawing.Point(70, 154);
            this.lblname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 18);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCourse.Location = new System.Drawing.Point(70, 118);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(63, 18);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course";
            this.lblCourse.Click += new System.EventHandler(this.lblCourse_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(168, 76);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(148, 24);
            this.txtStudentID.TabIndex = 4;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(168, 108);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(148, 24);
            this.txtCourse.TabIndex = 5;
            this.txtCourse.TextChanged += new System.EventHandler(this.txtCourse_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 143);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 24);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(168, 180);
            this.txtAge.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(148, 24);
            this.txtAge.TabIndex = 7;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(75, 392);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(164, 46);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(75, 442);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(164, 46);
            this.btnDeleteStudent.TabIndex = 9;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnGenerateSummary
            // 
            this.btnGenerateSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSummary.Location = new System.Drawing.Point(561, 475);
            this.btnGenerateSummary.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(312, 91);
            this.btnGenerateSummary.TabIndex = 10;
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = true;
            this.btnGenerateSummary.Click += new System.EventHandler(this.btnGenerateSummary_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Age,
            this.Course});
            this.dataGridViewStudents.Location = new System.Drawing.Point(496, 35);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(641, 374);
            this.dataGridViewStudents.TabIndex = 11;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentCount.Location = new System.Drawing.Point(920, 490);
            this.lblStudentCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(115, 18);
            this.lblStudentCount.TabIndex = 12;
            this.lblStudentCount.Text = "Student Count";
            this.lblStudentCount.Click += new System.EventHandler(this.lblStudentCount_Click);
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAverageAge.Location = new System.Drawing.Point(920, 547);
            this.lblAverageAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(101, 18);
            this.lblAverageAge.TabIndex = 13;
            this.lblAverageAge.Text = "Average Age";
            this.lblAverageAge.Click += new System.EventHandler(this.lblAverageAge_Click);
            // 
            // btnUpdateStudents
            // 
            this.btnUpdateStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudents.Location = new System.Drawing.Point(262, 392);
            this.btnUpdateStudents.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnUpdateStudents.Name = "btnUpdateStudents";
            this.btnUpdateStudents.Size = new System.Drawing.Size(164, 46);
            this.btnUpdateStudents.TabIndex = 14;
            this.btnUpdateStudents.Text = "Update ";
            this.btnUpdateStudents.UseVisualStyleBackColor = true;
            this.btnUpdateStudents.Click += new System.EventHandler(this.btnUpdateStudents_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(262, 442);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 46);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateStudents);
            this.Controls.Add(this.lblAverageAge);
            this.Controls.Add(this.lblStudentCount);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.btnGenerateSummary);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblstudentid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnGenerateSummary;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Button btnUpdateStudents;
        private System.Windows.Forms.Button btnExit;
    }
}

