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

        public static void SaveBook(DataGridView gridView, DatabaseService<Book> bookService, TextBox nameBox, TextBox authorBox, TextBox isbnBox) 
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(authorBox.Text) || string.IsNullOrWhiteSpace(isbnBox.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!int.TryParse(isbnBox.Text, out int isbn))
            {
                MessageBox.Show("ISBN must be a number.");
                return;
            }

            var newBook = new Book
            {
                Name = nameBox.Text,
                Author = authorBox.Text,
                ISBN = isbn
            };

            bookService.Add(newBook);
            MessageBox.Show("Book added successfully!");

            LoadDataIntoGrid.LoadIntoGrid(gridView, bookService);

            nameBox.Clear();
            authorBox.Clear();
            isbnBox.Clear();

        }
    }
}
