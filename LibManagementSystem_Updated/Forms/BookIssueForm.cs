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
        private LoadStudentInfoService _loadStudentInfoService;

        private int _studentId;


        public BookIssueForm(int studentId)
        {
            InitializeComponent();
            _loadIssueBookService = new LoadIssueBookService();
            _issueBookService = new IssueBookService();
            _loadStudentInfoService = new LoadStudentInfoService();
            _studentId = studentId;
            LoadStudentInfo();
            LoadBooks();

        }

        private void LoadStudentInfo()
        {
            _loadStudentInfoService.LoadStdInfo(_studentId, labelStdName, labelStdId);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadBooks()
        {
            _loadIssueBookService.LoadBooks(dataGridView1, _studentId);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book before issuing.");
                return;
            }

            int bookId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            _issueBookService.RequestIssue(_studentId, bookId, dataGridView1);
            LoadBooks();
        }


    }
}
