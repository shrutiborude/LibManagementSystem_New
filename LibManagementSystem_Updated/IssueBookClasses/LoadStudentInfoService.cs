using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using LibManagementSystem_Updated.Models;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace LibManagementSystem_Updated.IssueBookClasses
{
    public class LoadStudentInfoService
    {
        public void LoadStdInfo(int _studentId, Label labelStdName, Label labelStdId)
        {
            using (var context = new MyDbContext())
            {
                var student = context.Students.FirstOrDefault(s => s.Id == _studentId);
                if (student != null)
                {
                    labelStdName.Text = $"Name: {student.Name}";
                    labelStdId.Text = $"Student ID: {student.Id}";
                }
            }
        }
    }
}
