using System;
using System.Linq;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;
using LibManagementSystem_Updated.IssueBookClasses;

namespace LibManagementSystem_Updated.Services
{
    public class AcceptRequestService
    {
        public void AcceptRequest(DataGridView dataGridView)
        {

            if (dataGridView.SelectedRows.Count > 0)
            {

                int requestId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);

                using (var context = new MyDbContext())
                {
                    var request = context.IssuedBooks.Find(requestId);
                    if (request != null)
                    {
                        request.IsApproved = true;
                        request.RequestStatus = "Accepted";
                        context.SaveChanges();
                        MessageBox.Show("Book request approved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Request not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a request to approve.");
                return;

            }
        }
    }
}
