using System.Collections.Generic;
using System.Linq;
using WinFormsApp.Models;

namespace WinFormsApp.Repositories
{
    public class DatabaseStateHolder
    {
        public List<Database> DatabasesList { get; set; }

        public DatabaseStateHolder()
        {
            DatabasesList = new List<Database>();
        }
        
        public void InitDatabases()
        {
            var valuesDict = new Dictionary<int, string>();
            var valuesDict2 = new Dictionary<int, string>();
            for (int i = 0; i < 5; i++)
            {
                valuesDict.Add(i, "Value" + i);
                if (i < 3)
                    valuesDict2.Add(i, "Value" + i);
            }
            
            var valuesList= new List<string>();
            var valuesList2 = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                valuesList.Add("Value" + i);
                if (i < 3)
                    valuesList2.Add("Value" + i);
            }
            
            var cols = new List<Column>
            {
                new Column {Name = "Column1", Type = "String",Values = valuesList},
                new Column {Name = "Column2", Type = "Integer",Values = valuesList2}
            };
            var tablesDatabase1 = new List<Table>
            {
                new() {Name = "TableTest1",Columns = cols},
                new() {Name = "TableTest2"}
            };
            var tablesDatabase2 = new List<Table>
            {
                new() {Name = "TableTest1Db2"}, //Columns = cols},
                new() {Name = "TableTest2Db2"}
            };
            
            DatabasesList = new List<Database>
            {
                new() {Name = "Database_Test2", Tables = tablesDatabase2},
                new() {Name = "Database_Test1", Tables = tablesDatabase1}
            };
            
        }

        public Database FindDatabaseByName(string name)
        {
            return DatabasesList.First(d => d.Name == name);
        }

        public List<string> GetAllDatabasesNames()
        {
            var databasesNames = DatabasesList.Select(database => database.Name).ToList();
            return databasesNames;
        }
        
        public void AddDatabase(string name)
        {
            var database = new Database {Name = name};
            DatabasesList.Add(database);
        }

        public void RemoveDatabase(string databaseName)
        {
            var database = FindDatabaseByName(databaseName);
            DatabasesList.Remove(database);
        }

        public void FindTablesDifference(Table table1, Table table2)
        {
            var similarCols = new List<Column>();
            foreach (var column1 in table1.Columns)
            {
                foreach (var column2 in table2.Columns)
                {
                    if (column1.Name != column2.Name) continue;
                    if (column1.Type == column2.Type)
                    {
                        similarCols.Add(column1);
                    }
                }
            }

            foreach (var column1 in table1.Columns)
            {
                if (similarCols.Contains(column1))
                {
                    for (int i = 0; i < column1.Values.Count; i++)
                    {
                        
                    }
                }
            }
        }
        
        
        /*Tables actions*/
        public Table FindTableByName(string databaseName,string tableName)
        {
            var database = FindDatabaseByName(databaseName);
            var table = database.Tables.Find(t => t.Name == tableName);
            return table;
        }

        public List<string> GetAllDatabaseTablesNames(string databaseName)
        {
            var database = FindDatabaseByName(databaseName);
            var tablesNames = database.Tables.Select(table => table.Name).ToList();
            return tablesNames;
        }
        public void AddTable(string databaseName, string tableName)
        {
            var database = FindDatabaseByName(databaseName);
            
            var table = new Table {Name = tableName};
            database.Tables.Add(table);
        }

        public void RemoveTable(string databaseName, string tableName)
        {
            var database = FindDatabaseByName(databaseName);
            var table = FindTableByName(databaseName, tableName);
            
            database.Tables.Remove(table);
        }
        
        /*Columns actions*/
        public Column FindColumnByName(string databaseName, string tableName, string columnName)
        {
            var table = FindTableByName(databaseName, tableName);
            var column = table.Columns.Find(c => c.Name == columnName);
            return column;
        }

        public List<Column> FindAllTableColumns(string databaseName, string tableName)
        {
            var table = FindTableByName(databaseName, tableName);
            return table.Columns;
        }
        
        public void AddColumn(string databaseName, string tableName, string columnName, string columnType)
        {
            var table = FindTableByName(databaseName, tableName);
            var column = new Column {Name = columnName, Type = columnType};
            table.Columns.Add(column);
        }

        public void RemoveColumn(string databaseName, string tableName, string columnName)
        {
            var table = FindTableByName(databaseName, tableName);
            var column = FindColumnByName(databaseName, tableName, columnName);
            table.Columns.Remove(column);
        }

        /*Column Data Actions*/
        public void AddDataToColumn(string databaseName, string tableName, string data, int columnIndex, int rowIndex)
        {
            var table = FindTableByName(databaseName, tableName);
            //var columnIndex = table.Columns.FindIndex(column => column.Name == columnName);
            
            //var colValues = table.Columns[columnIndex].Values;
            //var column = FindColumnByName(databaseName, tableName, columnName);

            var columnName = FindColumnNameByIndex(table, columnIndex);
            var columnData = FindAllDataFromColumn(databaseName, tableName, columnName);
            // if (rowIndex > column.Values.Count-1)
            // {
            //     column.Values.Insert(rowIndex,data);
            // }
            // column.Values[rowIndex] = data;
            
            if (rowIndex > columnData.Count-1)
            {
                columnData.Insert(rowIndex,data);
            }
            columnData[rowIndex] = data;
            
            //var colValues = table.Columns[e.ColumnIndex].Values;
            // if (e.RowIndex > colValues.Count-1)
            // {
            //     table.Columns[e.ColumnIndex].Values.Insert(e.RowIndex,currentCellData);
            // }
            // table.Columns[e.ColumnIndex].Values[e.RowIndex] = currentCellData;
        }

        public int FindColumnIndexByColumnName(string databaseName, string tableName, string columnName)
        {
            var table = FindTableByName(databaseName, tableName);
            var columnIndex = table.Columns.FindIndex(column => column.Name == columnName);
            return columnIndex;
        }

        private string FindColumnNameByIndex(Table table, int columnIndex)
        {
            return table.Columns[columnIndex].Name;
        }

        public List<string> FindAllDataFromColumn(string databaseName, string tableName, string columnName)
        {
            //var table = FindTableByName(databaseName, tableName);
            var column = FindColumnByName(databaseName, tableName, columnName);
            return column.Values;
        }
        
        /*Table Rows actions*/
        public void InitEmptyRows(string databaseName, string tableName, int count)
        {
            //int count = table.Columns.Select(column => column.Values.Count).Max();
            var table = FindTableByName(databaseName, tableName);
            foreach (var column in table.Columns.Where(column => column.Values.Count < count))
            {
                for (int i = column.Values.Count; i < count; i++)
                {
                    column.Values.Add(string.Empty);
                }
            }
        }

        public int FindRowsCount(string databaseName, string tableName)
        {
            var table = FindTableByName(databaseName, tableName);

            int count = 0;
            if (table.Columns.Count != 0)
            {
                count = table.Columns.Select(column => column.Values.Count).Max();
            }

            return count;
        }
            
        public void AddRowToTable(string databaseName, string tableName)
        {
            var tableColumns = FindAllTableColumns(databaseName, tableName);
            foreach (var column in tableColumns)
            {
                column.Values.Add(string.Empty);
            }
        }

        public void RemoveRowFromTable(string databaseName, string tableName, int rowIndex)
        {
            var tableColumns = FindAllTableColumns(databaseName, tableName);

            foreach (var column in tableColumns)
            {
                column.Values.RemoveAt(rowIndex);
            }
        }
        
    }
}