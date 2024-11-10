using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using StudentManagementSystem2._0.Presentation_Layer;
using StudentManagementSystem2._0.Business_Logic_Layer;

namespace StudentManagementSystem2._0.Data_Layer
{
    internal class Students
    {
        private string filePath;

        public Students(string path = "students.txt")
        {
            filePath = path;
        }

        // Retrieve all student records from the file
        public List<string> GetAllStudents()
        {
            return File.Exists(filePath) ? new List<string>(File.ReadAllLines(filePath)) : new List<string>();
        }

        // Save all student records to the file (overwrites existing content)
        public void SaveAllStudents(List<string> students)
        {
            File.WriteAllLines(filePath, students);
        }

        // Add a new student record to the file
        public void AddStudent(string studentData)
        {
            File.AppendAllText(filePath, studentData + Environment.NewLine);
        }
    }
}