using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.Classes
{
    public static class FindSelectedBook
    {
        public static Book GetSelectedBook(DataGridView gridView, int rowIndex)
        {
            if (rowIndex < 0) return null;
            return gridView.Rows[rowIndex].DataBoundItem as Book;
        }

        public static void PopulateBookFields(Book selectedBook, TextBox nameBox, TextBox authBox, TextBox isbnBox)
        {
            if (selectedBook == null) return;

            nameBox.Text = selectedBook.Name;
            authBox.Text = selectedBook.Author;
            isbnBox.Text = selectedBook.ISBN.ToString();
        }
    }
}
