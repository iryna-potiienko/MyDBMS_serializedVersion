using System;
using System.Windows.Forms;

namespace WinFormsApp.AdditionalForms
{
    public partial class AddNewColumnForm : Form
    {
        public string InstanceName { get; set; }
        public string Type { get; set; }
        public AddNewColumnForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            InstanceName = nameTextBox.Text;
            Type = typeTextBox.Text;
            this.Visible = false;
        }
    }
}