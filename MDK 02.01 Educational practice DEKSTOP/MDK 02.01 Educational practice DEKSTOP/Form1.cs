using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDK_02._01_Educational_practice_DEKSTOP
{
    public partial class Form1 : Form
    {
        // Замените эту строку своей фактической строкой подключения к базе данных
        private string ConnectionString = @"Data Source=Prepod34;Initial Catalog=MDK 02.01 Educational practice DEKSTOP153;User ID=Student;Password=1;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            form.Show(); // Или form.ShowDialog(); в зависимости от ваших нужд.
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            OpenForm(new BooksForm(ConnectionString));
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeesForm(ConnectionString));
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            OpenForm(new ItemsForm(ConnectionString));
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomersForm(ConnectionString));
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            OpenForm(new AuthorsForm(ConnectionString));
        }

        private void btnEditors_Click(object sender, EventArgs e)
        {
            OpenForm(new EditorsForm(ConnectionString));
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            OpenForm(new TitleForm(ConnectionString));
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenForm(new OrdersForm(ConnectionString));
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            OpenForm(new RoomsForm(ConnectionString));
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            OpenForm(new PostsForm(ConnectionString));
        }
    }

    // Пример формы для таблицы Books.  Создайте аналогичные формы для других таблиц.
    public partial class BooksForm : Form
    {
        private string _connectionString;

        public BooksForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM books";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Предполагается, что у вас есть элемент DataGridView с именем dataGridViewBooks
                    dataGridViewBooks.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        // Добавьте обработчики событий для добавления, редактирования, удаления и т.д.
        // Пример:
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Код для добавления новой книги в базу данных.  Используйте SqlCommand, параметры и т.д.
        }
    }

    //Реализуйте для всех остальных
    public partial class EmployeesForm : Form
    {
        private string _connectionString;

        public EmployeesForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Employees";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Предполагается, что у вас есть элемент DataGridView с именем dataGridViewBooks
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
    }
    public partial class ItemsForm : Form
    {
        private string _connectionString;

        public ItemsForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM items";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Предполагается, что у вас есть элемент DataGridView с именем dataGridViewBooks
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
    }
    public partial class CustomersForm : Form
    {
        private string _connectionString;

        public CustomersForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM customers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Предполагается, что у вас есть элемент DataGridView с именем dataGridViewBooks
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
    }
    public partial class AuthorsForm : Form
    {
        private string _connectionString;

        public AuthorsForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM authors";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Предполагается, что у вас есть элемент DataGridView с именем dataGridViewBooks
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
    }
    public partial class EditorsForm : Form
    {
        private string _connectionString;

        public EditorsForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM editors";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Предполагается, что у вас есть элемент DataGridView с именем dataGridViewBooks
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
    }
    public partial class TitleForm : Form
    {
        private string _connectionString;

        public TitleForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM title";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Предполагается, что у вас есть элемент DataGridView с именем dataGridViewBooks
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
    }
    public partial class OrdersForm : Form
    {
        private string _connectionString;

        public OrdersForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM orders";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Предполагается, что у вас есть элемент DataGridView с именем dataGridViewBooks
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
    }
    public partial class RoomsForm : Form
    {
        private string _connectionString;

        public RoomsForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            //LoadData();
        }

        /*private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM orders";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Предполагается, что у вас есть элемент DataGridView с именем dataGridViewBooks
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }*/
    }
    public partial class PostsForm : Form
    {
        private string _connectionString;

        public PostsForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM posts";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Предполагается, что у вас есть элемент DataGridView с именем dataGridViewBooks
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
    }


}