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
using LibManagementSystem_Updated.IssueBookClasses;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated.Forms
{
    public partial class BookIssueForm : Form
    {
        private LoadIssueBookService _loadIssueBookService;
        private IssueBookService _issueBookService;
        public BookIssueForm()
        {
            InitializeComponent();
            _loadIssueBookService = new LoadIssueBookService();
            _issueBookService = new IssueBookService();
            LoadBooks();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadBooks()
        {
            _loadIssueBookService.LoadBooks(dataGridView1);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            int studentId = 16;
            //int studentId = 17;

            _issueBookService.RequestIssue(studentId, bookId, dataGridView1);
        }


    }
}
