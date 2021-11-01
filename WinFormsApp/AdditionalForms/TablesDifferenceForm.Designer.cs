using System.ComponentModel;

namespace WinFormsApp.AdditionalForms
{
    partial class TablesDifferenceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tableDiffDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.database1ComboBox = new System.Windows.Forms.ComboBox();
            this.table1ComboBox = new System.Windows.Forms.ComboBox();
            this.database2ComboBox = new System.Windows.Forms.ComboBox();
            this.table2ComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.tableDiffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDiffDataGridView
            // 
            this.tableDiffDataGridView.AllowUserToDeleteRows = false;
            this.tableDiffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDiffDataGridView.Location = new System.Drawing.Point(62, 209);
            this.tableDiffDataGridView.Name = "tableDiffDataGridView";
            this.tableDiffDataGridView.ReadOnly = true;
            this.tableDiffDataGridView.Size = new System.Drawing.Size(471, 192);
            this.tableDiffDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database 1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(67, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table 1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(309, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database 2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(309, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Table 2";
            // 
            // database1ComboBox
            // 
            this.database1ComboBox.FormattingEnabled = true;
            this.database1ComboBox.Location = new System.Drawing.Point(147, 44);
            this.database1ComboBox.Name = "database1ComboBox";
            this.database1ComboBox.Size = new System.Drawing.Size(110, 21);
            this.database1ComboBox.TabIndex = 5;
            this.database1ComboBox.SelectedIndexChanged += new System.EventHandler(this.database1ComboBox_SelectedIndexChanged);
            // 
            // table1ComboBox
            // 
            this.table1ComboBox.FormattingEnabled = true;
            this.table1ComboBox.Location = new System.Drawing.Point(147, 108);
            this.table1ComboBox.Name = "table1ComboBox";
            this.table1ComboBox.Size = new System.Drawing.Size(110, 21);
            this.table1ComboBox.TabIndex = 6;
            this.table1ComboBox.SelectedIndexChanged += new System.EventHandler(this.table1ComboBox_SelectedIndexChanged);
            // 
            // database2ComboBox
            // 
            this.database2ComboBox.FormattingEnabled = true;
            this.database2ComboBox.Location = new System.Drawing.Point(435, 43);
            this.database2ComboBox.Name = "database2ComboBox";
            this.database2ComboBox.Size = new System.Drawing.Size(128, 21);
            this.database2ComboBox.TabIndex = 7;
            this.database2ComboBox.SelectedIndexChanged += new System.EventHandler(this.database2ComboBox_SelectedIndexChanged);
            // 
            // table2ComboBox
            // 
            this.table2ComboBox.FormattingEnabled = true;
            this.table2ComboBox.Location = new System.Drawing.Point(435, 108);
            this.table2ComboBox.Name = "table2ComboBox";
            this.table2ComboBox.Size = new System.Drawing.Size(132, 21);
            this.table2ComboBox.TabIndex = 8;
            this.table2ComboBox.SelectedIndexChanged += new System.EventHandler(this.table2ComboBox_SelectedIndexChanged);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(293, 161);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(108, 24);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // TablesDifferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.table2ComboBox);
            this.Controls.Add(this.database2ComboBox);
            this.Controls.Add(this.table1ComboBox);
            this.Controls.Add(this.database1ComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableDiffDataGridView);
            this.Name = "TablesDifferenceForm";
            this.Text = "TablesDifferenceForm";
            this.Load += new System.EventHandler(this.TablesDifferenceForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.tableDiffDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        
        private System.Windows.Forms.DataGridView tableDiffDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox database1ComboBox;
        private System.Windows.Forms.ComboBox database2ComboBox;
        private System.Windows.Forms.ComboBox table1ComboBox;
        private System.Windows.Forms.ComboBox table2ComboBox;
        private System.Windows.Forms.Button showButton;

        #endregion
    }
}