using System;
using System.Windows.Forms;

using WinFormsApp.Models;
using WinFormsApp.Repositories;

namespace WinFormsApp.AdditionalForms
{
    public partial class TablesDifferenceForm : Form
    {
        private readonly DatabaseStateHolder _databaseStateHolder;
                
        private Database _currentDatabase1;
        private Table _currentTable1;
        private Database _currentDatabase2;
        private Table _currentTable2;
                
        public TablesDifferenceForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void TablesDifferenceForm_Load(object sender, EventArgs e)
        {
            BindDatabase1ComboBox();
            BindDatabase2ComboBox();
        }

        private void database1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentDatabase1 = (Database) database1ComboBox.SelectedItem;
            table1ComboBox.DataSource = _currentDatabase1.Tables;
            table1ComboBox.DisplayMember = "Name";
        }
        private void database2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentDatabase2 = (Database) database2ComboBox.SelectedItem;
            table2ComboBox.DataSource = _currentDatabase2.Tables;
            table2ComboBox.DisplayMember = "Name";
        }

        public void BindDatabase1ComboBox()
        {
            database1ComboBox.DataSource = null;
            database1ComboBox.Items.Clear();

            database1ComboBox.DataSource = _databaseStateHolder.DatabasesList;
            database1ComboBox.DisplayMember = "Name";
        }

        private void table1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tableDiffDataGridView.Columns.Clear();
            _currentTable1 = (Table) table1ComboBox.SelectedItem;
            //if (_currentTable1.Columns.Count == 0) return;

            //FillDataGridView();
        }
        public void BindDatabase2ComboBox()
        {
            database2ComboBox.DataSource = null;
            database2ComboBox.Items.Clear();

            database2ComboBox.DataSource = _databaseStateHolder.DatabasesList;
            database2ComboBox.DisplayMember = "Name";
        }

        private void table2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tableDiffDataGridView.Columns.Clear();
            _currentTable2 = (Table) table2ComboBox.SelectedItem;
            //if (_currentTable2.Columns.Count == 0) return;

            //FillDataGridView();
        }

        // public void FillDataGridView()
        // {
        //
        //     foreach (var column in _currentTable1.Columns)
        //     {
        //         tableDiffDataGridView.Columns.Add(column.Name, column.Name);
        //     }
        //
        //     AddRows();
        //
        //     for (int i = 0; i < _currentTable1.Columns.Count; i++)
        //     {
        //         for (int j = 0; j < _currentTable1.Columns[i].Values.Count; j++)
        //         {
        //
        //             tableDiffDataGridView.Rows[j].Cells[i].Value = _currentTable1.Columns[i].Values[j];
        //
        //         }
        //     }
        // }
        // private void AddRows()
        // {
        //     int count = _currentTable.Columns.Select(column => column.Values.Count).Max();
        //     foreach (var column in _currentTable.Columns)
        //     {
        //         if (column.Values.Count < count)
        //         {
        //             for (int i = column.Values.Count; i < count; i++)
        //             {
        //                 column.Values.Add(string.Empty);
        //             }
        //         }
        //     }
        //
        //     dataGridView1.Rows.Add(count);
        //     
        // }
    }
}