using System.Linq;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.Services
{
    public class PendingRequestsService
    {
        public void LoadPendingRequests(DataGridView gridView)
        {
            using (var context = new MyDbContext())
            {
                var requests = context.IssuedBooks
                    .Where(b => !b.IsApproved) // Load only pending requests
                    .Select(b => new
                    {
                        b.Id,
                        StudentName = b.Student.Name,
                        BookName = b.Book.Name,
                        b.IssueDate
                    })
                    .ToList();

                if (requests.Count == 0)
                {
                    MessageBox.Show("No pending book requests.");
                }

                gridView.AutoGenerateColumns = true;
                gridView.DataSource = requests;
            }
        }
    }
}
