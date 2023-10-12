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
using System.Windows.Forms.VisualStyles;

namespace Security_Layer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form1_Load() called..."); text_Count.Text = "Startup..."; try
            {
                /* 
                System.Diagnostics.Debug.WriteLine("within the try"); 
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");                 connection.Open(); 
                txtMessageText.Text = "Connection Successful";                 connection.Close(); 
                */
                var datasource = @"DESKTOP-PH51JNI\SQLEXPRESS"; var database = "Northwind";
                var thisUsername = Form1.username; var thisPassword = Form1.password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                text_Count.Text = "Connection Successful on Startup"; conn.Close();

            }

            catch (Exception ex)
            {
                text_Count.Text = "Error, " + ex;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string currentTable = "";
            if (Form1.username == "User_Sales")
            {
                // Allow access to Orders and Customers table
                if (radio_Customer.Checked)
                {
                    currentTable = "Customers";
                }
                else if (radio_Order.Checked)
                {
                    currentTable = "Orders";
                }
                else
                {
                    dataGridView.DataSource = null;
                    MessageBox.Show("You do not have access to this table.");
                }
            }
            else if (Form1.username == "User_HR")
            {
                // Allow access to Employee table
                if (radio_Employee.Checked)
                {
                    currentTable = "Employees";
                }
                else
                {
                    dataGridView.DataSource = null;
                    MessageBox.Show("You do not have access to this table.");
                }
            }
            else if (Form1.username == "User_CEO")
            {
                // Allow access to Orders, Customers, and Employee tables
                if (radio_Customer.Checked)
                {
                    currentTable = "Customers";
                }
                else if (radio_Employee.Checked)
                {
                    currentTable = "Employees";
                }
                else if (radio_Order.Checked)
                {
                    currentTable = "Orders";
                }
                else
                {
                    dataGridView.DataSource = null;
                    MessageBox.Show("You do not have access to this table.");
                }
            }



            try
            {
                SqlCommand command = new SqlCommand();
                //SqlConnection connection = new SqlConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True");
                var datasource = @"DESKTOP-PH51JNI\SQLEXPRESS";
                var database = "Northwind";
                var thisUsername = Form1.username;
                var thisPassword = Form1.password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                dataGridView.Text = "Retrieving Records..."; command.Connection = conn;
                command.CommandText = "select * from " + currentTable;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); da.Fill(dt);

                dataGridView.DataSource = dt;
                dataGridView.Text = "Retrieval Successful!"; conn.Close();
            }
            catch (Exception ex)
            {
                dataGridView.Text = "Error, " + ex;
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PH51JNI\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True"); 
            connection.Open();
            text_Count.Text = "Inserting Record..."; command.Connection = connection;
            command.CommandText = "insert into Customers (CustomerID, CompanyName) values('" + textID.Text + "','" + text_Comapany.Text + "')"; command.ExecuteNonQuery();
            text_Count.Text = "Record Inserted..."; connection.Close();
        }



        private void button_Count_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PH51JNI\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True"); connection.Open();
            text_Count.Text = "Counting Records..."; command.Connection = connection;
            command.CommandText = "select count(*) from Customers"; int count = (int)command.ExecuteScalar(); text_Count.Text = "Number of records: " + count; connection.Close();
        }

        private void radio_Customer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}