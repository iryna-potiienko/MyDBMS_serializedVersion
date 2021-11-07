using System;
using System.Windows.Forms;

using WinFormsApp.Models;
using WinFormsApp.Repositories;

namespace WinFormsApp.AdditionalForms
{
    public partial class TablesDifferenceForm : Form
    {
        private readonly DatabaseStateHolder _databaseStateHolder;
        private readonly TablesDifferenceRepository _tablesDifferenceRepository;

        private string _currentDatabase1Name;
        private string _currentTable1Name;
        private string _currentDatabase2Name;
        private string _currentTable2Name;

        public TablesDifferenceForm(DatabaseStateHolder databaseStateHolder)
        {
            InitializeComponent();
            _databaseStateHolder = databaseStateHolder;
            _tablesDifferenceRepository = new TablesDifferenceRepository(databaseStateHolder);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void TablesDifferenceForm_Load(object sender, EventArgs e)
        {
            BindDatabasesComboBoxes();
        }

        private void database1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentDatabase1Name = database1ComboBox.SelectedItem.ToString();
            table1ComboBox.DataSource = _databaseStateHolder.GetAllDatabaseTablesNames(_currentDatabase1Name);
        }

        private void database2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentDatabase2Name = database2ComboBox.SelectedItem.ToString();
            table2ComboBox.DataSource = _databaseStateHolder.GetAllDatabaseTablesNames(_currentDatabase2Name);
        }

        private void BindDatabasesComboBoxes()
        {
            database1ComboBox.DataSource = _databaseStateHolder.GetAllDatabasesNames();
            database2ComboBox.DataSource = _databaseStateHolder.GetAllDatabasesNames();
        }

        private void table1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tableDiffDataGridView.Columns.Clear();
            _currentTable1Name = table1ComboBox.SelectedItem.ToString();
            //if (_currentTable1.Columns.Count == 0) return;

            //FillDataGridView();
        }

        private void table2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tableDiffDataGridView.Columns.Clear();
            _currentTable2Name = table2ComboBox.SelectedItem.ToString();
            //if (_currentTable2.Columns.Count == 0) return;

            //FillDataGridView();
        }

        private void FillDataGridView()
        {
            var table1 = _databaseStateHolder.FindTableByName(_currentDatabase1Name, _currentTable1Name);
            var table2 = _databaseStateHolder.FindTableByName(_currentDatabase2Name, _currentTable2Name);
            
            var similarColNames = _tablesDifferenceRepository.FindSimilarColumnNames(table1, table2);
            var table = _tablesDifferenceRepository.FindTablesDifference(table1, table2);


            foreach (var colName in similarColNames)
            {
                tableDiffDataGridView.Columns.Add(colName, colName);
            }

            for (int rowIndex = 0; rowIndex < table.Count; rowIndex++)
            {
                tableDiffDataGridView.Rows.Add();
                for (int columnIndex = 0; columnIndex < table[rowIndex].Count; columnIndex++)
                {
                    tableDiffDataGridView.Rows[rowIndex].Cells[columnIndex].Value = table[rowIndex][columnIndex];
                }
            }

        }
    }
}