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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        SqlConnectionStringBuilder SqlConnBuild = new SqlConnectionStringBuilder();
        string User = null, Password = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string User = "Rus";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == User && textBox2.Text == Password)
            {
                User = textBox1.Text;
                Password = textBox2.Text;
                SqlConnBuild.DataSource = @"DESKTOP-OHQR73G";
                SqlConnBuild.InitialCatalog = "MyDB";
                SqlConnBuild.UserID = User;
                SqlConnBuild.Password = Password;
                // Создание подключения
                SqlConnection connection = new SqlConnection(SqlConnBuild.ConnectionString);
                try
                {
                    // Открываем подключение
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                        MessageBox.Show("Подключение открыто");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // закрываем подключение
                    connection.Close();
                    MessageBox.Show("Подключение закрыто...");
                }

            }            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Password = "123";
        }
    }
}
