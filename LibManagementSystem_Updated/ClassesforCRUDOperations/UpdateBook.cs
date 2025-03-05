using System.Linq;
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

            if (isbnBox.Text.Length != 13 || !isbnBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("ISBN number must be exactly 13 digits and numeric.");
                return;
            }

            var existingPerson = bookService.GetAll().FirstOrDefault(p => p.ISBN == isbnBox.Text && p.Id != selectedBook.Id);
            if (existingPerson != null)
            {
                MessageBox.Show("Contact number must be unique. Please enter a different number.");
                return;
            }

            selectedBook.Name = nameBox.Text;
            selectedBook.Author = authorBox.Text;
            selectedBook.ISBN = isbnBox.Text;

            bookService.Update(selectedBook);
            MessageBox.Show("Book updated successfully.");
            LoadDataIntoGrid.LoadIntoGrid(gridView, bookService);

            nameBox.Clear();
            authorBox.Clear();
            isbnBox.Clear();

        }
    }
}
