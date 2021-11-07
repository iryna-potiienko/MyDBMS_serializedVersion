using System;
using System.Windows.Forms;

namespace WinFormsApp.AdditionalForms
{
    public partial class AddNewColumnForm : Form
    {
        public string InstanceName { get; set; }
        public Models.Type ColumnType { get; set; }
        public AddNewColumnForm()
        {
            InitializeComponent();
            BindCombobox();
        }

        private void BindCombobox()
        {
            typeComboBox.DataSource = Enum.GetValues(typeof(Models.Type));
        }
        
        private void okButton_Click(object sender, EventArgs e)
        {
            InstanceName = nameTextBox.Text;
            //Type = typeTextBox.Text;
            this.Visible = false;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnType = (Models.Type)typeComboBox.SelectedItem;
        }
    }
}