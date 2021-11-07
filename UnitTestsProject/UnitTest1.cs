using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WinFormsApp.Models;
using WinFormsApp.Repositories;
using Xunit;
using Type = WinFormsApp.Models.Type;

namespace UnitTestsProject
{
    public class UnitTest1
    {
        private DatabaseStateHolder _databaseStateHolder;
        [Fact]
        public void AddDatabaseTest()
        {
            _databaseStateHolder = new DatabaseStateHolder();

            var name = "TestDatabase";
            
            var testDatabase = _databaseStateHolder.AddDatabase(name);
            
            Assert.True(testDatabase);
        }
        
        [Fact]
        public void GetAllDatabasesNamesTest()
        {
            _databaseStateHolder = new DatabaseStateHolder();

            var names = new List<string>
            {
                "Database1", "Database2"
            };
            
            _databaseStateHolder.DatabasesList = new List<Database>
            {
                new Database {Name = names[0]},
                new Database {Name = names[1]}
            };

            
            var testDatabasesNames = _databaseStateHolder.GetAllDatabasesNames();
            
            Assert.Equal(names,testDatabasesNames);
        }

        [Fact]
        public void FindRowsCountTest()
        {
            _databaseStateHolder = new DatabaseStateHolder();

            var table = new Table
            {
                Columns = new List<Column>
                {
                    new Column {Values = new List<string> {"Value1", "Value2"} },
                    new Column {Values = new List<string> {"Value1", "Value2","Value3"} }
                }
            };
            var count = _databaseStateHolder.FindRowsCount(table);
            
            Assert.Equal(3,count);
        }

        [Fact]
        public void ValidationTest()
        {
            var validationRepo = new ValidateRepository();
            var res = validationRepo.Validate(Type.CharInvl, "(k;z)");
            
            Assert.True(res);
        }

        [Fact]
        public void TableDiffTest()
        {
            _databaseStateHolder = new DatabaseStateHolder();
            var tableDiffRepo = new TablesDifferenceRepository(_databaseStateHolder);

            var expected = new List<List<string>>
            {
                new List<string> {"2","value2" },
                new List<string> { "3",""}
            };
            
            var filePath = @"D:\4 курс\Інформаційні технології\Saved Databases\DatabaseTableDiffTest.json";
                
            string jsonString = File.ReadAllText(filePath);
            var database = JsonSerializer.Deserialize<Database>(jsonString);

            var actual = tableDiffRepo.FindTablesDifference(database.Tables[0], database.Tables[1]);
            
            Assert.Equal(expected,actual);
        }
    }
}