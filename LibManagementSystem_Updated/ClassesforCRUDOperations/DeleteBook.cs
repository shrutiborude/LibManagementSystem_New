using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.Classes
{
    public class DeleteBookHelper
    {
        public static void DeleteBook(DataGridView gridView, DatabaseService<Book> service, Book selectedBook)
        {
            if (selectedBook == null)
            {
                MessageBox.Show("Please select a Book to delete.");
                return;
            }

            var confiirm = MessageBox.Show("Are you sure you want to delete this book? ", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confiirm == DialogResult.Yes)
            {
                service.Delete(selectedBook);
                MessageBox.Show("Book deleted successfully");

                LoadDataIntoGrid.LoadIntoGrid(gridView, service);
            }

        }
    }
}
