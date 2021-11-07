using System.Windows.Forms;

namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseCombobox = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.addDatabaseButton = new System.Windows.Forms.Button();
            this.addTableButton = new System.Windows.Forms.Button();
            this.removeDatabaseButton = new System.Windows.Forms.Button();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.addColumnButton = new System.Windows.Forms.Button();
            this.removeRowButton = new System.Windows.Forms.Button();
            this.removeColumnButton = new System.Windows.Forms.Button();
            this.tablesDifferenceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(53, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(346, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.Location = new System.Drawing.Point(54, 43);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(128, 22);
            this.DatabaseLabel.TabIndex = 1;
            this.DatabaseLabel.Text = "Database";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.saveToolStripMenuItem, this.getToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.getToolStripMenuItem.Text = "Get";
            this.getToolStripMenuItem.Click += new System.EventHandler(this.getToolStripMenuItem_Click);
            // 
            // databaseCombobox
            // 
            this.databaseCombobox.ContextMenuStrip = this.contextMenuStrip1;
            this.databaseCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseCombobox.FormattingEnabled = true;
            this.databaseCombobox.Items.AddRange(new object[] {"Database1", "Database2", "Database3"});
            this.databaseCombobox.Location = new System.Drawing.Point(197, 42);
            this.databaseCombobox.Name = "databaseCombobox";
            this.databaseCombobox.Size = new System.Drawing.Size(106, 21);
            this.databaseCombobox.TabIndex = 4;
            this.databaseCombobox.SelectedIndexChanged += new System.EventHandler(this.databaseCombobox_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // tableComboBox
            // 
            this.tableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Items.AddRange(new object[] {"Table1", "Table2", "Table3"});
            this.tableComboBox.Location = new System.Drawing.Point(106, 101);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(201, 21);
            this.tableComboBox.TabIndex = 5;
            this.tableComboBox.SelectedIndexChanged += new System.EventHandler(this.tableComboBox_SelectedIndexChanged);
            // 
            // addDatabaseButton
            // 
            this.addDatabaseButton.Location = new System.Drawing.Point(389, 42);
            this.addDatabaseButton.Name = "addDatabaseButton";
            this.addDatabaseButton.Size = new System.Drawing.Size(93, 23);
            this.addDatabaseButton.TabIndex = 6;
            this.addDatabaseButton.Text = "Add";
            this.addDatabaseButton.UseVisualStyleBackColor = true;
            this.addDatabaseButton.Click += new System.EventHandler(this.addDatabaseButton_Click);
            // 
            // addTableButton
            // 
            this.addTableButton.Location = new System.Drawing.Point(387, 101);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(94, 21);
            this.addTableButton.TabIndex = 7;
            this.addTableButton.Text = "Add";
            this.addTableButton.UseVisualStyleBackColor = true;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // removeDatabaseButton
            // 
            this.removeDatabaseButton.Location = new System.Drawing.Point(546, 42);
            this.removeDatabaseButton.Name = "removeDatabaseButton";
            this.removeDatabaseButton.Size = new System.Drawing.Size(81, 22);
            this.removeDatabaseButton.TabIndex = 8;
            this.removeDatabaseButton.Text = "Remove";
            this.removeDatabaseButton.UseVisualStyleBackColor = true;
            this.removeDatabaseButton.Click += new System.EventHandler(this.removeDatabaseButton_Click);
            // 
            // removeTableButton
            // 
            this.removeTableButton.Location = new System.Drawing.Point(551, 100);
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.Size = new System.Drawing.Size(75, 21);
            this.removeTableButton.TabIndex = 9;
            this.removeTableButton.Text = "Remove";
            this.removeTableButton.UseVisualStyleBackColor = true;
            this.removeTableButton.Click += new System.EventHandler(this.removeTableButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(48, 146);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(82, 23);
            this.addRowButton.TabIndex = 10;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // addColumnButton
            // 
            this.addColumnButton.Location = new System.Drawing.Point(337, 146);
            this.addColumnButton.Name = "addColumnButton";
            this.addColumnButton.Size = new System.Drawing.Size(107, 23);
            this.addColumnButton.TabIndex = 11;
            this.addColumnButton.Text = "Add Column";
            this.addColumnButton.UseVisualStyleBackColor = true;
            this.addColumnButton.Click += new System.EventHandler(this.addColumnButton_Click);
            // 
            // removeRowButton
            // 
            this.removeRowButton.Location = new System.Drawing.Point(197, 146);
            this.removeRowButton.Name = "removeRowButton";
            this.removeRowButton.Size = new System.Drawing.Size(90, 23);
            this.removeRowButton.TabIndex = 12;
            this.removeRowButton.Text = "Remove Row";
            this.removeRowButton.UseVisualStyleBackColor = true;
            this.removeRowButton.Click += new System.EventHandler(this.removeRowButton_Click);
            // 
            // removeColumnButton
            // 
            this.removeColumnButton.Location = new System.Drawing.Point(506, 144);
            this.removeColumnButton.Name = "removeColumnButton";
            this.removeColumnButton.Size = new System.Drawing.Size(99, 25);
            this.removeColumnButton.TabIndex = 13;
            this.removeColumnButton.Text = "Remove Column";
            this.removeColumnButton.UseVisualStyleBackColor = true;
            this.removeColumnButton.Click += new System.EventHandler(this.removeColumnButton_Click);
            // 
            // tablesDifferenceButton
            // 
            this.tablesDifferenceButton.Location = new System.Drawing.Point(661, 146);
            this.tablesDifferenceButton.Name = "tablesDifferenceButton";
            this.tablesDifferenceButton.Size = new System.Drawing.Size(104, 22);
            this.tablesDifferenceButton.TabIndex = 14;
            this.tablesDifferenceButton.Text = "Tables Difference";
            this.tablesDifferenceButton.UseVisualStyleBackColor = true;
            this.tablesDifferenceButton.Click += new System.EventHandler(this.tablesDifferenceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablesDifferenceButton);
            this.Controls.Add(this.removeColumnButton);
            this.Controls.Add(this.removeRowButton);
            this.Controls.Add(this.addColumnButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.removeTableButton);
            this.Controls.Add(this.removeDatabaseButton);
            this.Controls.Add(this.addTableButton);
            this.Controls.Add(this.addDatabaseButton);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.databaseCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button removeColumnButton;

        private System.Windows.Forms.Button addColumnButton;

        private System.Windows.Forms.Button tablesDifferenceButton;

        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button removeRowButton;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;

        //private System.Windows.Forms.ContextMenu contextMenu1;

        private System.Windows.Forms.ComboBox tableComboBox;

        private System.Windows.Forms.ComboBox databaseCombobox;

        private System.Windows.Forms.Button removeDatabaseButton;
        private System.Windows.Forms.Button addDatabaseButton;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.Button removeTableButton;

        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Label DatabaseLabel;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}

