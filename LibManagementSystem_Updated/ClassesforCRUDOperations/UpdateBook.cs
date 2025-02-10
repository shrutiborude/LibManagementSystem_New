using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.Classes
{
    public static class UpdateBookHelper
    {
        public static void UpdateBook(DataGridView gridView, DatabaseService<Book> bookService, Book selectedBook, TextBox nameBox, TextBox authorBox, TextBox isbnBox)
        {
            if (selectedBook == null)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(authorBox.Text) || string.IsNullOrWhiteSpace(isbnBox.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!int.TryParse(isbnBox.Text.Trim(), out var isbn))
            {
                MessageBox.Show("ISBN must be valid number.");
                return;
            }

            selectedBook.Name = nameBox.Text;
            selectedBook.Author = authorBox.Text;
            selectedBook.ISBN = isbn;

            bookService.Update(selectedBook);
            MessageBox.Show("Book updated successfully.");
            LoadDataIntoGrid.LoadIntoGrid(gridView, bookService);

            nameBox.Clear();
            authorBox.Clear();
            isbnBox.Clear();

        }
    }
}
