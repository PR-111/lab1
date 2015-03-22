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
        

namespace laba1_1
{


    public partial class Form2 : Form
    {
        string check = "";
        public Form2()
        {
            InitializeComponent();
        }
        string connectionString = "Data source=localhost;UserId=root;Password=;database=mvs;Charset=cp1251";

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();

        private void criminalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.criminalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter.Fill(this.dataSet1.criminals);
            
     
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
    }
}
