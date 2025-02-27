using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.Classes
{
    public static class SaveBookHelper
    {
        
        public static bool SaveBook(DataGridView gridView, DatabaseService<Book> bookService, TextBox nameBox, TextBox authorBox, TextBox isbnBox) 
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(authorBox.Text) || string.IsNullOrWhiteSpace(isbnBox.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return false;
            }

            if (isbnBox.Text.Length != 13 || !isbnBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("ISBN number must be exactly 13 digits and numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (bookService.GetAll().Any(p => p.ISBN == isbnBox.Text))
            {
                MessageBox.Show("IBN number must be unique!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            var newBook = new Book
            {
                Name = nameBox.Text,
                Author = authorBox.Text,
                ISBN = isbnBox.Text
            };

            bookService.Add(newBook);
            MessageBox.Show("Book added successfully!");


            LoadDataIntoGrid.LoadIntoGrid(gridView, bookService);

            nameBox.Clear();
            authorBox.Clear();
            isbnBox.Clear();

            return true;

        }
    }
}
