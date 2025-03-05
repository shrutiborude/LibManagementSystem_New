using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibManagementSystem_Updated.Classes;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated
{
    public partial class BooksForm : Form
    {
        private readonly DatabaseService<Book> _bookService;
        private Book selectedBook;

        public BooksForm()
        {
            InitializeComponent();
            _bookService = new DatabaseService<Book>(new MyDbContext());
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBook = FindSelectedBook.GetSelectedBook(dataGridViewBook, e.RowIndex);
            FindSelectedBook.PopulateBookFields(selectedBook, textBoxBookName, textBoxAuthorName, textBoxISBN);
        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
             SaveBookHelper.SaveBook(dataGridViewBook, _bookService, textBoxBookName, textBoxAuthorName, textBoxISBN);
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            Console.WriteLine(selectedBook.Name);
            UpdateBookHelper.UpdateBook(dataGridViewBook, _bookService, selectedBook, textBoxBookName, textBoxAuthorName, textBoxISBN);
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBookHelper.DeleteBook(dataGridViewBook, _bookService, selectedBook);
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoGrid.LoadIntoGrid<Book>(dataGridViewBook, _bookService);

        }


    }
}
