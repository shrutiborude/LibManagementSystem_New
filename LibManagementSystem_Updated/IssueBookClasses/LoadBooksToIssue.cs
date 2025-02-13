using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.IssueBookClasses
{
    public class LoadIssueBookService
    {
        //public List<Book> getAllBooks()
        //{
        //    using (var context = new MyDbContext())
        //    {
        //        return context.Books.ToList();
        //    } 
        //}

        public void LoadBooks(DataGridView gridview)
        {
            using (var context = new MyDbContext())
            {
                var books = context.Books
                    .Select(book => new
                    {
                        book.Id,
                        book.Name,
                        book.Author,
                        //book.Genre,
                        //book.PublishedYear,
                        RequestStatus = context.IssuedBooks
                            .Where(ib => ib.BookId == book.Id)
                            .OrderByDescending(ib => ib.IssueDate) // Get latest request status
                            .Select(ib => ib.RequestStatus)
                            .FirstOrDefault() ?? "Available" // If no request, show as Available
                    })
                    .ToList();

                if (books.Count == 0)
                {
                    MessageBox.Show("No books found in the database.");
                }

                gridview.AutoGenerateColumns = true;
                gridview.DataSource = books;
            }
        }

    }
}
