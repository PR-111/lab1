namespace lab14
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mVSDataSet = new lab14.MVSDataSet();
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTableAdapter = new lab14.MVSDataSetTableAdapters.titleTableAdapter();
            this.tableAdapterManager = new lab14.MVSDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.даніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.злочинціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.працівникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посадиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.званняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mVSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mVSDataSet
            // 
            this.mVSDataSet.DataSetName = "MVSDataSet";
            this.mVSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataMember = "title";
            this.titleBindingSource.DataSource = this.mVSDataSet;
            // 
            // titleTableAdapter
            // 
            this.titleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.criminalsTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.postTableAdapter = null;
            this.tableAdapterManager.titleTableAdapter = this.titleTableAdapter;
            this.tableAdapterManager.types_of_crimesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab14.MVSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.victimTableAdapter = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.даніToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // даніToolStripMenuItem
            // 
            this.даніToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.злочинціToolStripMenuItem,
            this.працівникиToolStripMenuItem,
            this.посадиToolStripMenuItem,
            this.званняToolStripMenuItem});
            this.даніToolStripMenuItem.Name = "даніToolStripMenuItem";
            this.даніToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.даніToolStripMenuItem.Text = "Дані";
            // 
            // злочинціToolStripMenuItem
            // 
            this.злочинціToolStripMenuItem.Name = "злочинціToolStripMenuItem";
            this.злочинціToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.злочинціToolStripMenuItem.Text = "Злочинці";
            this.злочинціToolStripMenuItem.Click += new System.EventHandler(this.злочинціToolStripMenuItem_Click);
            // 
            // працівникиToolStripMenuItem
            // 
            this.працівникиToolStripMenuItem.Name = "працівникиToolStripMenuItem";
            this.працівникиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.працівникиToolStripMenuItem.Text = "Працівники";
            this.працівникиToolStripMenuItem.Click += new System.EventHandler(this.працівникиToolStripMenuItem_Click);
            // 
            // посадиToolStripMenuItem
            // 
            this.посадиToolStripMenuItem.Name = "посадиToolStripMenuItem";
            this.посадиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.посадиToolStripMenuItem.Text = "Посади";
            this.посадиToolStripMenuItem.Click += new System.EventHandler(this.посадиToolStripMenuItem_Click);
            // 
            // званняToolStripMenuItem
            // 
            this.званняToolStripMenuItem.Name = "званняToolStripMenuItem";
            this.званняToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.званняToolStripMenuItem.Text = "Звання";
            this.званняToolStripMenuItem.Click += new System.EventHandler(this.званняToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 285);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mVSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MVSDataSet mVSDataSet;
        private System.Windows.Forms.BindingSource titleBindingSource;
        private MVSDataSetTableAdapters.titleTableAdapter titleTableAdapter;
        private MVSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem даніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem злочинціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem працівникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посадиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem званняToolStripMenuItem;

    }
}

