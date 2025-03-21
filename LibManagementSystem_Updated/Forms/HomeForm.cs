﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibManagementSystem_Updated.Forms;
using LibManagementSystem_Updated.Models;
using LibManagementSystem_Updated.Services;
using Microsoft.VisualBasic;

namespace LibManagementSystem_Updated
{
    public partial class HomeForm : BaseOpenForm
    {
        private StudentLoginService _studentLoginService;
        public HomeForm()
        {
            InitializeComponent();
            _studentLoginService = new StudentLoginService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new StudentsForm());
        }

        private void libbutton_Click(object sender, EventArgs e)
        {
            OpenForm(new LibrariansForm());
        }

        private void bookbutton_Click(object sender, EventArgs e)
        {
            OpenForm(new BooksForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBookIssue_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter student id: ", "Student Login", "", -1, -1);
            int? studentId = _studentLoginService.ValidateStudent(input);

            if (studentId.HasValue)
            {
                OpenForm(new BookIssueForm(studentId.Value));
            }
        }

        private void btnReviewBookIssue_Click(object sender, EventArgs e)
        {
            OpenForm(new ReviewBookIssue());
        }
    }
}
