using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.MySql;

namespace lab14
{
    public partial class Form3 : Form
    {
        List<string> postIds = new List<string>();
        List<string> postTitles = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }
        string connectionString = "Data source=localhost;UserId=jak;Password=1234;database=MVS;Charset=cp1251";

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mVSDataSet.criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter.Fill(this.mVSDataSet.criminals);
            // TODO: This line of code loads data into the 'mVSDataSet.criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter.Fill(this.mVSDataSet.criminals);
            // TODO: This line of code loads data into the 'mVSDataSet.title' table. You can move, or remove it, as needed.
            this.titleTableAdapter.Fill(this.mVSDataSet.title);
            // TODO: This line of code loads data into the 'mVSDataSet.post' table. You can move, or remove it, as needed.
            this.postTableAdapter.Fill(this.mVSDataSet.post);
            // TODO: This line of code loads data into the 'mVSDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.mVSDataSet.employees);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            employeesTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString(), comboBox1.Text, textBox4.Text, textBox5.Text, textBox6.Text, 3, 5);
            employeesTableAdapter.Update(mVSDataSet);
            Form3_Load(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = connectionString;

            string commandString = "DELETE FROM employees WHERE code_employee " + "=" + listBox1.SelectedValue.ToString() + "";
            command.CommandText = commandString;
            command.Connection = connection;

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                reader.Close();
                MessageBox.Show("Успішне видалення!");
            }
            catch { }
            finally
            {
                connection.Close();
            }

            Form3_Load(sender, e);
            employeesTableAdapter.Update(mVSDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = connectionString;

            string commandString = "UPDATE employees SET surname = '" + textBox1.Text + "' WHERE code_employee " + "=" + listBox1.SelectedValue.ToString() + "";
            command.CommandText = commandString;
            command.Connection = connection;

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                reader.Close();
                MessageBox.Show("Успішне оновлення!");
            }
            catch { }
            finally
            {
                connection.Close();
            }

            Form3_Load(sender, e);
            employeesTableAdapter.Update(mVSDataSet);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.ConnectionString = connectionString;

                string commandString = "SELECT surname FROM criminals WHERE code_employee " + "=" + listBox1.SelectedValue.ToString() + "";
                //MessageBox.Show(listBox1.SelectedValue.ToString());
                command.CommandText = commandString;
                command.Connection = connection;
                MySqlDataAdapter da = new MySqlDataAdapter(command);


                try
                {
                    connection.Open();
                    //MySqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    listBox2.DataSource = dt;
                    listBox2.DisplayMember = "surname";
                    //reader.Close();
                    //MessageBox.Show("Успєх");
                }
                catch { }
                finally
                {
                    connection.Close();
                }

                //Form3_Load(sender, e);
                employeesTableAdapter.Update(mVSDataSet);
            }
            catch { }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            postBindingSource.Filter = "name_post='" + comboBox2.Text + "'";
        }
    }
}
