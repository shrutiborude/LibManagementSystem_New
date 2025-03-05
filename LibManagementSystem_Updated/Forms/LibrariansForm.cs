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
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated
{
    public partial class LibrariansForm : Form
    {
        private readonly DatabaseService<Librarian> _librarianService;
        private Librarian selectedLibrarian; 

        public LibrariansForm()
        {
            InitializeComponent();
            //Changes 
            _librarianService = new DatabaseService<Librarian>(new MyDbContext());
        }

        private void LibrariansForm_Load_1(object sender, EventArgs e)
        {
            LoadDataIntoGrid.LoadIntoGrid(dataGridViewLibrarianForm, _librarianService);
        }

        private void btnLibSave_Click(object sender, EventArgs e)
        {
            SaveHelper.SavePerson<Librarian>(dataGridViewLibrarianForm, _librarianService, textBoxLibName, textBoxLibContact, textBoxLibID);
        }

        private void btnLibUpdate_Click(object sender, EventArgs e)
        {
            UpdateHelper.UpdatePerson<Librarian>(dataGridViewLibrarianForm, _librarianService, selectedLibrarian, textBoxLibName, textBoxLibContact, textBoxLibID);
        }

        private void btnLibDelete_Click(object sender, EventArgs e)
        {
            DeleteHelper.DeletePerson<Librarian>(dataGridViewLibrarianForm, _librarianService, selectedLibrarian);
        }

        
        private void dataGridViewLibrarianForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedLibrarian = PersonSelectionService<Librarian>.GetSelectedPerson(dataGridViewLibrarianForm, e.RowIndex);
            PersonSelectionService<Librarian>.PopulateTextFields(selectedLibrarian, textBoxLibName, textBoxLibID, textBoxLibContact);
            
        }
    }
}
