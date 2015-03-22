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
    public partial class Form2 : Form
    {
        string check = "";
        public Form2()
        {
            InitializeComponent();
        }
        string connectionString = "Data source=localhost;UserId=jak;Password=1234;database=MVS;Charset=cp1251";

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mVSDataSet.criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter.Fill(this.mVSDataSet.criminals);
            check = "surame";
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            this.comboBox2.Items.AddRange(new object[] { "чоловік", "жінка" });
            this.comboBox3.Items.AddRange(new object[] { "у розшуку", "під слідством", "відбуває покарання" });

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(check + " LIKE '" + textBox3.Text + "'");
            criminalsBindingSource.Filter = check + " LIKE '%" + textBox3.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            criminalsBindingSource.RemoveSort();
            criminalsBindingSource.RemoveFilter();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
                check = "surname";
            else
                if (comboBox4.SelectedIndex == 1)
                    check = "name";
                else
                    if (comboBox4.SelectedIndex == 2)
                        check = "middle_name";
                    else
                        if (comboBox4.SelectedIndex == 3)
                            check = "sex";
                        else
                            if (comboBox4.SelectedIndex == 4)
                                check = "adress";
                            else
                                if (comboBox4.SelectedIndex == 5)
                                    check = "condition";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListSortDirection direction = ListSortDirection.Ascending;
            DataGridViewColumn col = criminalsDataGridView.Columns[1];
            criminalsDataGridView.Sort(col, direction);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListSortDirection direction = ListSortDirection.Descending;
            DataGridViewColumn col = criminalsDataGridView.Columns[1];
            criminalsDataGridView.Sort(col, direction);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            criminalsBindingSource.Position = criminalsBindingSource.Find("name", textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                criminalsBindingSource.Filter = " code_type_of_crime =" + comboBox1.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
             
            }
            finally
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int a, b, c;
            a = rand.Next(10);
            b = rand.Next(10);
            c = rand.Next(10);
            criminalsTableAdapter.Insert(textBox2.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Value.ToString(), comboBox2.Text, textBox6.Text, comboBox3.Text, a, b, c);
            criminalsTableAdapter.Update(mVSDataSet);
            Form2_Load(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox2.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = connectionString;

            string commandString = "DELETE FROM criminals WHERE case_number " + "=" + listBox1.SelectedValue.ToString() + "";
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

            Form2_Load(sender, e);
            criminalsTableAdapter.Update(mVSDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = connectionString;

            string commandString = "UPDATE criminals SET surname = '" + textBox2.Text + "' WHERE case_number " + "=" + listBox1.SelectedValue.ToString() + "";
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

            Form2_Load(sender, e);
            criminalsTableAdapter.Update(mVSDataSet);
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int index = listBox1.FindString(this.textBox8.Text);

            if (index != -1)
            {
                listBox1.SetSelected(index, true);
            }
            else
            {
                MessageBox.Show("Злочинця не знайдено");
                textBox8.Clear();
            }
        }
    }
}
