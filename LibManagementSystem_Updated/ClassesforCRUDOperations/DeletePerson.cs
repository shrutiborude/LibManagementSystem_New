using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManagementSystem_Updated.Classes
{
    public class DeleteHelper
    {
        public static void DeletePerson<T>(DataGridView gridView, DatabaseService<T> service, T selectedPerson)where T : class
        {
            if (selectedPerson == null)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to Delete the Entry?", "Confirm Deletion", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                service.Delete(selectedPerson);
                MessageBox.Show($"{typeof(T).Name} deleted successfully!");

                LoadDataIntoGrid.LoadIntoGrid(gridView, service);
            }

           
        }
    }
}
