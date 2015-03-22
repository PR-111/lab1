using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form2 f2;
        public Form3 f3;
        public Form4 f4;
        public Form5 f5;

       

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mVSDataSet.title' table. You can move, or remove it, as needed.
            this.titleTableAdapter.Fill(this.mVSDataSet.title);
          

        }

        private void titleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.titleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mVSDataSet);

        }

        private void злочинціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }

        private void працівникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();
        }

        private void посадиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4 = new Form4();
            f4.Show();
        }

        private void званняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5 = new Form5();
            f5.Show();
        }
    }
}
