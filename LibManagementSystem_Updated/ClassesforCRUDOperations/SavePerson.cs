using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.Classes
{
    public static class SaveHelper
    {
        public static void SavePerson<T>(DataGridView gridView, DatabaseService<T> service, TextBox nameBox, TextBox contactBox, TextBox idBox) where T : Person, new()
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(contactBox.Text) || string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (contactBox.Text.Length != 10 || !contactBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Contact number must be exactly 10 digits and numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (service.GetAll().Any(p => p.Contact == contactBox.Text))
            {
                MessageBox.Show("Contact number must be unique!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newPerson = new T
            {
                Name = nameBox.Text,
                Contact = contactBox.Text
            };

            var idProperty = typeof(T).GetProperty(typeof(T) == typeof(Student) ? "StudentID" : "EmployeeID");
            if (idProperty != null)
            {
                idProperty.SetValue(newPerson, idBox.Text);
            }

            service.Add(newPerson);
            MessageBox.Show($"{typeof(T).Name} added successfully!");

            LoadDataIntoGrid.LoadIntoGrid(gridView, service);

            nameBox.Clear();
            contactBox.Clear();
            idBox.Clear();
        }

    }

}

//using System;
//using System.Linq;
//using System.Windows.Forms;
//using LibManagementSystem_Updated.Models;

//namespace LibManagementSystem_Updated.Classes
//{
//    public static class SaveHelper
//    {
//        public static void SavePerson<T>(DataGridView gridView, DatabaseService<T> service, TextBox nameBox, TextBox contactBox, TextBox idBox) where T : Person, new()
//        {
//            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(contactBox.Text) || string.IsNullOrWhiteSpace(idBox.Text))
//            {
//                MessageBox.Show("Please fill all fields.");
//                return;
//            }

//            if (contactBox.Text.Length != 10 || !contactBox.Text.All(char.IsDigit))
//            {
//                MessageBox.Show("Contact number must be exactly 10 digits and numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (service.GetAll().Any(p => p.Contact == contactBox.Text))
//            {
//                MessageBox.Show("Contact number must be unique!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var newPerson = new T
//            {
//                Name = nameBox.Text,
//                Contact = contactBox.Text
//            };

//            var idProperty = typeof(T).GetProperty(typeof(T) == typeof(Student) ? "StudentID" : "EmployeeID");
//            if (idProperty != null)
//            {
//                idProperty.SetValue(newPerson, idBox.Text); 
//            }

//            service.Add(newPerson);
//            MessageBox.Show($"{typeof(T).Name} added successfully!");

//            LoadDataIntoGrid.LoadIntoGrid(gridView, service);

//            nameBox.Clear();
//            contactBox.Clear();
//            idBox.Clear();
//        }


//    }
//}
