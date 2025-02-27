using Effort;
using LibManagementSystem_Updated.Classes;
using LibManagementSystem_Updated.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace TestLibManag
{
    [TestClass]
    public class SaveHelperClass
    {
        private DatabaseService<Student> _studentService;
        private DatabaseService<Book> _bookService;
        private MyDbContext _dbContext;
        private DataGridView _dataGridView;
        private TextBox _nameBox, _contactBox, _idBox, _isbnBox, _authBox;

        [TestInitialize]
        public void Setup()
        {
            // Create an Effort in-memory database connection
            DbConnection connection = DbConnectionFactory.CreatePersistent("TestDatabase");


            // Use this connection for our MyDbContext
            _dbContext = new MyDbContext(connection);


            // Inject the DbContext into the service
            _studentService = new DatabaseService<Student>(_dbContext);
            _bookService = new DatabaseService<Book>(_dbContext);


            // Initialize UI elements
            _dataGridView = new DataGridView();
            _nameBox = new TextBox();
            _contactBox = new TextBox();
            _idBox = new TextBox();
            _isbnBox = new TextBox();
            _authBox = new TextBox();
        }

        [TestMethod]
        public void SavePerson_Should_Add_New_Student()
        {
            // Arrange
            _nameBox.Text = "Arya";
            _contactBox.Text = "6666666666";
            _idBox.Text = "121";
            Console.WriteLine($"Contact: {_contactBox.Text}");

            // Act
            SaveHelper.SavePerson(_dataGridView, _studentService, _nameBox, _contactBox, _idBox);

            // Retrieve the saved student
            var savedStudent = _studentService.GetAll().FirstOrDefault(s => s.Name == "Arya");
            Console.WriteLine($"Actual Contact: {savedStudent?.Contact}");


            // Assert
            Assert.IsNotNull(savedStudent, "Student should be saved");
            //Assert.AreEqual(_contactBox.Text, savedStudent.Contact, "Contact number not saved correctly");
            Assert.AreEqual("6666666666", savedStudent.Contact, "Contact number not saved correctly");

        }

        [TestMethod]
        public void Save_Book_Should_Add_New_Book()
        {
            _nameBox.Text = "Deadly";
            _authBox.Text = "Henry";
            _isbnBox.Text = "1234567890123";

            SaveBookHelper.SaveBook(_dataGridView, _bookService, _nameBox, _authBox, _isbnBox);

            var savedBook = _bookService.GetAll().FirstOrDefault(b => b.Name == "Deadly");

            Assert.IsNotNull(savedBook, "Book not added");
            Assert.AreEqual("1234567890123", savedBook.ISBN, "ISBN not added");


        }

        [TestMethod]
        public void SaveBook_Should_Fail_When_Empty_Entries()
        {
            _nameBox.Text = "";
            _authBox.Text = "";
            _isbnBox.Text = "";

            // Act
            bool result = SaveBookHelper.SaveBook(_dataGridView, _bookService, _nameBox, _authBox, _isbnBox);
            Console.WriteLine(result);
            Assert.IsFalse(result, "Book should not be saved when fields are empty");
        }


        [TestCleanup]
        public void Cleanup()
        {
            _dbContext.Dispose(); // Dispose of the database after each test
        }
    }
}

//using System;
//using System.Data.Common;
//using System.Linq;
//using System.Windows.Forms;
//using Effort;
//using LibManagementSystem_Updated.Classes;
//using LibManagementSystem_Updated.Models;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace TestLibMan
//{
//    [TestClass]
//    public class SaveHelperClass
//    {
//        DatabaseService<Book> _bookService;
//        private MyDbContext _dbContext;
//        private DataGridView _dataGridView;
//        private TextBox _nameBox, _authBox, _isbnBox;

//        [TestInitialize]
//        public void Setup()
//        {
//            DbConnection connection = DbConnectionFactory.CreatePersistent("TestDatabase");

//            _dbContext = new MyDbContext(connection);

//            _bookService = new DatabaseService<Book>(_dbContext);

//            _dataGridView = new DataGridView();
//            _nameBox = new TextBox();
//            _authBox = new TextBox();
//            _isbnBox = new TextBox();
//        }

//        [TestMethod]
//        public void SaveBook_Should_Fail_When_Empty_Entries()
//        {
//            _nameBox.Text = "";
//            _authBox.Text = "";
//            _isbnBox.Text = "";

//            // Act
//            bool result = SaveBookHelper.SaveBook(_dataGridView, _bookService, _nameBox, _authBox, _isbnBox);
//            Console.WriteLine(result);
//            Assert.IsFalse(result, "Book should not be saved when fields are empty");

//            // Assert
//            var savedBook = _bookService.GetAll().FirstOrDefault();
//            Assert.IsNull(savedBook, "Book should not be saved when fields are empty");
//        }

//        [TestCleanup]
//        public void Cleanup() 
//        {
//            _dbContext.Dispose();
//        }
//    }
//}
