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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void titleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.titleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mVSDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mVSDataSet.title' table. You can move, or remove it, as needed.
            this.titleTableAdapter.Fill(this.mVSDataSet.title);

        }
    }
}
