using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibManagementSystem_Updated.Models;
using System.Windows.Forms;

namespace LibManagementSystem_Updated.IssueBookClasses
{
    public class IssueBookService
    {
        public void RequestIssue(int IdofStudent, int bookId, DataGridView gridView)
        {

            //if (gridView.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Please select a book to issue.");
            //    return;
            //}

            using (var context = new MyDbContext())
            {

                var existingRequest = context.IssuedBooks
                    .FirstOrDefault(i => i.StudentId == IdofStudent && i.BookId == bookId && !i.IsApproved);

                if (existingRequest != null)
                {
                    MessageBox.Show("You have already requested this book. Please wait for librarian approval.");
                    return;
                }

                var newRequest = new IssuedBook
                {
                    StudentId = IdofStudent,
                    BookId = bookId,
                    IssueDate = DateTime.Now,
                    RequestStatus = "Pending",
                    IsApproved = false,
                };

                context.IssuedBooks.Add(newRequest);
                context.SaveChanges();

                MessageBox.Show("Book issue request sent successfully!");
                
            }

        }
    }
}
