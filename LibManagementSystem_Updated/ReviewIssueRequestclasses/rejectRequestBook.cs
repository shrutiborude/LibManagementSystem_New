using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.ReviewIssueRequestclasses
{
    public class RejectRequestService
    {
        public void RejectRequest(DataGridView gridView)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int requestId = (int)gridView.SelectedRows[0].Cells["Id"].Value;
                using (var context = new MyDbContext())
                {
                    var request = context.IssuedBooks.Find(requestId);
                    if (request != null)
                    {
                        request.IsApproved = false;
                        context.IssuedBooks.Remove(request);
                        context.SaveChanges();
                        MessageBox.Show("Book request rejected and removed.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a request to reject.");
            }
        }

    }
}
