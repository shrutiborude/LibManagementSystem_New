using System;
using System.Linq;
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

            if (contactBox.Text.Length != 10 || !contactBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Contact number must be exactly 10 digits and numeric.");
                return;
            }

            var existingPerson = service.GetAll().FirstOrDefault(p => p.Contact == contactBox.Text && p.Id != selectedPerson.Id);
            if (existingPerson != null)
            {
                MessageBox.Show("Contact number must be unique. Please enter a different number.");
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
