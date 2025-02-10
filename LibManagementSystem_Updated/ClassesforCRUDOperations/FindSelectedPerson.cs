using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.Classes
{
    public static class PersonSelectionService<T> where T : Person
    {
        public static T GetSelectedPerson(DataGridView gridView, int rowIndex)
        {
            if (rowIndex < 0) return null;

            return gridView.Rows[rowIndex].DataBoundItem as T;
        }

        public static void PopulateTextFields(T selectedPerson, TextBox nameBox, TextBox idBox, TextBox contactBox)
        {
            if (selectedPerson == null) return;

            nameBox.Text = selectedPerson.Name;
            contactBox.Text = selectedPerson.Contact;

            if (selectedPerson is Student student)
            {
                idBox.Text = student.StudentID;
            }
            else if (selectedPerson is Librarian librarian)
            {
                idBox.Text = librarian.EmployeeID;
            }
        }
    }
}
