using System;
using System.Windows.Forms;

namespace WinFormsApp.AdditionalForms
{
    public partial class AddNewForm : Form
    {
        public string InstanceName { get; set; }
        public AddNewForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            InstanceName = textBox1.Text;
            Visible = false;
        }
    }
}