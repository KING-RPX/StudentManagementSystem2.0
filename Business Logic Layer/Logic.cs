using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using StudentManagementSystem2._0.Presentation_Layer;
using StudentManagementSystem2._0.Data_Layer;
using System.Security.Cryptography.X509Certificates;

namespace StudentManagementSystem2._0.Business_Logic_Layer
{
    public class StudentManager
    {
        private readonly Students dataAccess;

        public StudentManager()
        {
            dataAccess = new Students();
        }

        // Add a new student by formatting their data and saving it
        public void AddStudent(string studentID, string name, string age, string course)
        {
            string studentData = $"{studentID},{name},{age},{course}";
            dataAccess.AddStudent(studentData);
        }

        // Retrieve all students, split data into fields for easy use in the UI
        public List<string[]> GetAllStudents()
        {
            var studentDataList = dataAccess.GetAllStudents();
            return studentDataList.Select(data => data.Split(',')).ToList();
        }

        // Update an existing student by ID and save changes to the file
        public bool UpdateStudent(string studentID, string name, string age, string course)
        {
            var studentDataList = dataAccess.GetAllStudents();
            bool updated = false;

            // Locate and update student by ID
            for (int i = 0; i < studentDataList.Count; i++)
            {
                var fields = studentDataList[i].Split(',');
                if (fields[0] == studentID)
                {
                    studentDataList[i] = $"{studentID},{name},{age},{course}";
                    updated = true;
                    break;
                }
            }

            if (updated)
            {
                dataAccess.SaveAllStudents(studentDataList);  // Save updated data
            }
            return updated;
        }

        // Delete a student by ID
        public bool DeleteStudent(string studentID)
        {
            var studentDataList = dataAccess.GetAllStudents();
            var initialCount = studentDataList.Count;

            // Remove student by ID
            studentDataList = studentDataList.Where(data => data.Split(',')[0] != studentID).ToList();

            if (studentDataList.Count < initialCount)
            {
                dataAccess.SaveAllStudents(studentDataList);  // Save changes
                return true;
            }
            return false;
        }

        // Generate a summary of the student data
        public (int totalStudents, double averageAge) GenerateSummary()
        {
            var studentDataList = dataAccess.GetAllStudents();
            int totalStudents = studentDataList.Count;
            double averageAge = studentDataList
                .Select(data => int.Parse(data.Split(',')[2]))  // Get ages
                .DefaultIfEmpty(0)
                .Average();  // Calculate average

            return (totalStudents, averageAge);
        }
    }
}
