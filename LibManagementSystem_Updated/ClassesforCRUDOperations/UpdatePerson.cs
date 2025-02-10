using System;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.Classes
{
    public static class UpdateHelper
    {
        public static void UpdatePerson<T>(DataGridView gridView, DatabaseService<T> service, T selectedPerson, TextBox nameBox, TextBox contactBox, TextBox idBox) where T : Person
        {
            if (selectedPerson == null)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(contactBox.Text) || string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            selectedPerson.Name = nameBox.Text;
            selectedPerson.Contact = contactBox.Text;

            if (selectedPerson is Student student)
            {
                student.StudentID = idBox.Text;
            }
            else if (selectedPerson is Librarian librarian)
            {
                librarian.EmployeeID = idBox.Text;
            }

            service.Update(selectedPerson);
            MessageBox.Show($"{typeof(T).Name} updated successfully!");

            LoadDataIntoGrid.LoadIntoGrid(gridView, service);

            nameBox.Clear();
            contactBox.Clear();
            idBox.Clear();
        }
    }
}
