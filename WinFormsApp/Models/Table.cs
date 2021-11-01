using System.Collections.Generic;

namespace WinFormsApp.Models
{
    public class Table
    {
        public Table()
        {
            Columns = new List<Column>();
        }
        public string Name { get; set; }
        public List<Column> Columns { get; set; }
        
    }
}