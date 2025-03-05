using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LibManagementSystem_Updated.Classes;
using LibManagementSystem_Updated.Models;


namespace LibManagementSystem_Updated
{
    public partial class StudentsForm : Form
    {
            private readonly DatabaseService<Student> _studentService;
            private Student selectedStudent; 

            public StudentsForm()
            {
                InitializeComponent();
                //Changes
                _studentService = new DatabaseService<Student>(new MyDbContext());
            }

            private void StudentsForm_Load(object sender, EventArgs e)
            {
                LoadDataIntoGrid.LoadIntoGrid(dataGridViewStudentForm, _studentService);
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                SaveHelper.SavePerson<Student>(dataGridViewStudentForm, _studentService, textBoxStudName, textBoxStudContact, textBoxStudID);
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                UpdateHelper.UpdatePerson(dataGridViewStudentForm, _studentService, selectedStudent, textBoxStudName, textBoxStudContact, textBoxStudID);
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                DeleteHelper.DeletePerson<Student>(dataGridViewStudentForm, _studentService, selectedStudent);
                
            }

            private void dataGridViewStudentForm_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                selectedStudent = PersonSelectionService<Student>.GetSelectedPerson(dataGridViewStudentForm, e.RowIndex);
                PersonSelectionService<Student>.PopulateTextFields(selectedStudent, textBoxStudName, textBoxStudID, textBoxStudContact);

            }
        }
    }
