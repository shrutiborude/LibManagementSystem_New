using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;
using LibManagementSystem_Updated.ReviewIssueRequestclasses;
using LibManagementSystem_Updated.Services;

namespace LibManagementSystem_Updated.Forms
{
    public partial class ReviewBookIssue : Form
    {
        private AcceptRequestService acceptrequest;
        private RejectRequestService rejectrequest;
        private PendingRequestsService loadPendingRequests;
        public ReviewBookIssue()
        {
            InitializeComponent();
            acceptrequest = new AcceptRequestService();
            rejectrequest = new RejectRequestService();
            loadPendingRequests = new PendingRequestsService();

            LoadRequests();
        }

        private void LoadRequests()
        {
            loadPendingRequests.LoadPendingRequests(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            acceptrequest.AcceptRequest(dataGridView1);
            LoadRequests();
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            rejectrequest.RejectRequest(dataGridView1);
            LoadRequests() ;
        }
    }
}
