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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void postBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mVSDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mVSDataSet.post' table. You can move, or remove it, as needed.
            this.postTableAdapter.Fill(this.mVSDataSet.post);

        }
    }
}
