using System.Linq;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.Services
{
    public class StudentLoginService
    {
        public int? ValidateStudent(string input)
        {
            if (int.TryParse(input, out int studentId))
            {
                using (var context = new MyDbContext())
                {
                    var student = context.Students.FirstOrDefault(s => s.Id == studentId);
                    if (student != null)
                    {
                        return student.Id; 
                    }
                    else
                    {
                        MessageBox.Show("Student ID not found. Please enter a valid ID.");
                        return null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID. Please enter a number.");
                return null;
            }
        }
    }
}
