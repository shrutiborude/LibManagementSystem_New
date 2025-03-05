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
        public void LoadBooks(DataGridView gridview, int studentId)
        {
            using (var context = new MyDbContext())
            {
                var books = context.Books
                    .Select(book => new
                    {
                        book.Id,
                        book.Name,
                        book.Author,
                        Requeststatus = context.IssuedBooks
                            .Where(br => br.BookId == book.Id && br.StudentId == studentId)
                            .Select(br => br.RequestStatus)
                            .FirstOrDefault() ?? "Available"


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
