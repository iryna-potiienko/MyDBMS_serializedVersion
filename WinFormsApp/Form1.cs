using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.AdditionalForms;
using WinFormsApp.Models;
using WinFormsApp.Repositories;


namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        //private List<string> DatabasesList;
        private readonly DatabaseStateHolder _databaseStateHolder;
        
        //private Database _currentDatabase;
        //private Table _currentTable;
        private string _currentDatabaseName;
        private string _currentTableName;

        public Form1()
        {
            InitializeComponent();

            _databaseStateHolder = new DatabaseStateHolder();
            _databaseStateHolder.InitDatabases();
            BindComboBox();
        }


        private void BindComboBox()
        {
            //databaseCombobox.DataSource = null;
            //databaseCombobox.Items.Clear();
            databaseCombobox.DataSource = _databaseStateHolder.GetAllDatabasesNames();
            //databaseCombobox.DisplayMember = "Name";
        }

        private void databaseCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tableComboBox.DataSource = null;
            //_currentDatabase = (Database)databaseCombobox.SelectedItem;
            _currentDatabaseName = databaseCombobox.SelectedItem.ToString();
            tableComboBox.DataSource = _databaseStateHolder.GetAllDatabaseTablesNames(_currentDatabaseName);
            //tableComboBox.DataSource = _currentDatabase.Tables;
            //tableComboBox.DisplayMember = "Name";
        }

        

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
           // _currentTable = (Table) tableComboBox.SelectedItem;
           //if (_currentTable.Columns.Count == 0) return;
           _currentTableName = tableComboBox.SelectedItem.ToString();
            
            FillDataGridView();
        }


        public void FillDataGridView()
        {
            // var table = _databaseStateHolder.FindTableByName(_currentTableName, _currentTableName);
            var tableColumns = _databaseStateHolder.FindAllTableColumns(_currentDatabaseName, _currentTableName);
            if (tableColumns.Count == 0) return;
            
            foreach (var column in tableColumns)
            {
                dataGridView1.Columns.Add(column.Name, column.Name);
            }

            AddRows();

            for (int i = 0; i < tableColumns.Count; i++)
            {
                for (int j = 0; j < tableColumns[i].Values.Count; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = tableColumns[i].Values[j];
                }
            }
        }



        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            // var currentCellData = dataGridView1[e.ColumnIndex, e.RowIndex].Value;
            //
            // //var columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            // //var rowIndex = dataGridView1.CurrentCell.RowIndex;
            //
            // currentTable.Columns[e.ColumnIndex].Values[e.RowIndex] = currentCellData.ToString();

        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
            var currentCellData = e.Value.ToString();//dataGridView1[e.ColumnIndex, e.RowIndex].Value;

            //_validateRepository.Validate(currentCellData)

            if (!_databaseStateHolder.AddDataToColumn(_currentDatabaseName, _currentTableName, currentCellData,
                e.ColumnIndex, e.RowIndex))
            {
                //errorProvider1.SetError(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Incorrect Type";
                MessageBox.Show(@"Please input value of correct type!", @"Incorrect type!");
                //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                //e.Value = "";
            }
                
            // var table = _databaseStateHolder.FindTableByName(_currentDatabaseName, _currentTableName);
            // var colValues = table.Columns[e.ColumnIndex].Values;
            // if (e.RowIndex > colValues.Count-1)
            // {
            //     table.Columns[e.ColumnIndex].Values.Insert(e.RowIndex,currentCellData);
            // }
            // table.Columns[e.ColumnIndex].Values[e.RowIndex] = currentCellData;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void addColumnButton_Click(object sender, EventArgs e)
        {
            var addColumnForm = new AddNewColumnForm();
            addColumnForm.Show();
            addColumnForm.VisibleChanged += AddColumnFormVisibleChanged;
        }
        
        private void AddColumnFormVisibleChanged(object sender, EventArgs e)
        {
            var frm = (AddNewColumnForm)sender;
            if (frm.Visible) return;
            
            var colName = frm.InstanceName;
            dataGridView1.Columns.Add(colName, colName);
                
            //var column = new Column {Name = colName, Type = frm.Type};
            //table.Columns.Add(column);
            _databaseStateHolder.AddColumn(_currentDatabaseName, _currentTableName, colName, frm.ColumnType);
                
            frm.Dispose();
        }

        private void addDatabaseButton_Click(object sender, EventArgs e)
        {
            var addDatabaseForm = new AddNewForm();
            addDatabaseForm.Show();
            addDatabaseForm.VisibleChanged += AddDatabaseFormVisibleChanged;
        }

        private void AddDatabaseFormVisibleChanged(object sender, EventArgs e)
        {
            var frm = (AddNewForm)sender;
            if (frm.Visible) return;
            
            _databaseStateHolder.AddDatabase(frm.InstanceName);
            //databaseCombobox.ResetBindings();
            
            BindComboBox();

            //databaseCombobox.SelectedItem = database;
            frm.Dispose();
        }

        private void addTableButton_Click(object sender, EventArgs e)
        {
            var addDatabaseForm = new AddNewForm();
            addDatabaseForm.Show();
            addDatabaseForm.VisibleChanged += AddTableFormVisibleChanged;
        }

        private void AddTableFormVisibleChanged(object sender, EventArgs e)
        {
            var addNewForm = (AddNewForm)sender;
            if (addNewForm.Visible) return;
            
            // var table = new Table {Name = frm.InstanceName};
            // _currentDatabase.Tables.Add(table);
            _databaseStateHolder.AddTable(_currentDatabaseName,addNewForm.InstanceName);
            
            //databaseCombobox.ResetBindings();
            
            BindComboBox();

            //databaseCombobox.SelectedItem = table;
            addNewForm.Dispose();
        }

        private void removeDatabaseButton_Click(object sender, EventArgs e)
        {
            var databaseName = databaseCombobox.SelectedItem.ToString();
            // _databasesList.Remove(database);
            _databaseStateHolder.RemoveDatabase(databaseName);
            BindComboBox();
        }

        private void removeTableButton_Click(object sender, EventArgs e)
        {
            var tableName = tableComboBox.SelectedItem.ToString();
            //_currentDatabase.Tables.Remove(table);
            _databaseStateHolder.RemoveTable(_currentDatabaseName,tableName);
            BindComboBox();
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            // foreach (var column in table.Columns)
            // {
            //     column.Values.Add(string.Empty);
            // }
            _databaseStateHolder.AddRowToTable(_currentDatabaseName,_currentTableName);
            dataGridView1.Rows.Add();
            //AddRows(1);
        }

        private void removeColumnButton_Click(object sender, EventArgs e)
        {
            var removeColumnForm = new AddNewForm();
            removeColumnForm.Show();
            removeColumnForm.VisibleChanged += RemoveColumnFormVisibleChanged;
        }

        private void RemoveColumnFormVisibleChanged(object sender, EventArgs e)
        {
            var frm = (AddNewForm)sender;
            if (frm.Visible) return;
            
            var colName = frm.InstanceName;

            // var column = table.Columns.Find(t => t.Name == colName);
            // dataGridView1.Columns.Remove(colName);
            // table.Columns.Remove(column);
            
            _databaseStateHolder.RemoveColumn(_currentDatabaseName,_currentTableName,colName);
            dataGridView1.Columns.Remove(colName);
            
            frm.Dispose();
        }

        private void removeRowButton_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                // foreach (var column in table.Columns)
                // {
                //     column.Values.RemoveAt(row.Index);
                // }
                _databaseStateHolder.RemoveRowFromTable(_currentDatabaseName, _currentTableName, row.Index);
                dataGridView1.Rows.Remove(row);
            }
        }

        private void AddRows()
        {
            // int count = table.Columns.Select(column => column.Values.Count).Max();
            // foreach (var column in table.Columns)
            // {
            //     if (column.Values.Count < count)
            //     {
            //         for (int i = column.Values.Count; i < count; i++)
            //         {
            //             column.Values.Add(string.Empty);
            //         }
            //     }
            // }
            var count = _databaseStateHolder.FindRowsCount(_currentDatabaseName, _currentTableName);
            if (count > 0)
            {
                _databaseStateHolder.InitEmptyRows(_currentDatabaseName, _currentTableName, count);
                dataGridView1.Rows.Add(count);
            }

        }

        private void tablesDifferenceButton_Click(object sender, EventArgs e)
        {
            var removeColumnForm = new TablesDifferenceForm(_databaseStateHolder);
            removeColumnForm.Show();
            removeColumnForm.VisibleChanged += TablesDifferenceVisibleChanged;
        }

        private void TablesDifferenceVisibleChanged(object sender, EventArgs e)
        {
            var frm = (TablesDifferenceForm)sender;
            if (frm.Visible) return;
            
            //var table = new Table {Name = frm.InstanceName};
            //_currentDatabase.Tables.Add(table);
            //databaseCombobox.ResetBindings();
            
            BindComboBox();

            //databaseCombobox.SelectedItem = table;
            frm.Dispose();
        }

        
        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _databaseStateHolder.GetDatabase();
            BindComboBox();
            //databaseCombobox.SelectedItem=
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _databaseStateHolder.SaveDatabase(_currentDatabaseName);
        }
    }
}
