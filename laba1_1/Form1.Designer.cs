namespace laba1_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.злочинціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.працівникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посадиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.званняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данніToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данніToolStripMenuItem
            // 
            this.данніToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.злочинціToolStripMenuItem,
            this.працівникиToolStripMenuItem,
            this.посадиToolStripMenuItem,
            this.званняToolStripMenuItem});
            this.данніToolStripMenuItem.Name = "данніToolStripMenuItem";
            this.данніToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.данніToolStripMenuItem.Text = "Дані";
            // 
            // злочинціToolStripMenuItem
            // 
            this.злочинціToolStripMenuItem.Name = "злочинціToolStripMenuItem";
            this.злочинціToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.злочинціToolStripMenuItem.Text = "Злочинці";
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
            // 
            // званняToolStripMenuItem
            // 
            this.званняToolStripMenuItem.Name = "званняToolStripMenuItem";
            this.званняToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.званняToolStripMenuItem.Text = "Звання";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 437);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "База МВС";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem злочинціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem працівникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посадиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem званняToolStripMenuItem;

    }
}

