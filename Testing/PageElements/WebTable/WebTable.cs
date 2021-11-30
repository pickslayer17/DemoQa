using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace TestProject1.PageElements.WebTable
{
    public class WebTable
    {
        private DataTable _table;

        public WebTable()
        {
            _table = new DataTable("Persons");
            DataColumn fNameColumn = new DataColumn("First name", typeof(string));
            DataColumn lNameColumn = new DataColumn("Last name", typeof(string));
            DataColumn ageColumn = new DataColumn("Age", typeof(int));
            DataColumn emailColumn = new DataColumn("Email", typeof(string));
            DataColumn salaryColumn = new DataColumn("Salary", typeof(int));
            DataColumn departmentColumn = new DataColumn("Department", typeof(string));
            _table.Columns.Add(fNameColumn);
            _table.Columns.Add(lNameColumn);
            _table.Columns.Add(ageColumn);
            _table.Columns.Add(emailColumn);
            _table.Columns.Add(salaryColumn);
            _table.Columns.Add(departmentColumn);
        }

        public void PrintTableOut()
        {
            foreach (DataRow row in _table.Rows)
            {
                foreach (var cell in row.ItemArray)
                {
                    Console.Out.Write("\t{0}", cell);
                }
                Console.Out.WriteLine("");
            }
        }
        public void AddDefaultRow()
        {
            DataRow dataRow = _table.NewRow();
            dataRow.ItemArray = new object?[] {"Alexey", "Ivanchik", 24, "DanWolf@gmail.com", 1500, "QA"};
            _table.Rows.Add(dataRow);
        }

        public void AddConcreteRow(string fName, string lName, int age, string email, int salary, string department)
        {
            DataRow dataRow = _table.NewRow();
            dataRow.ItemArray = new object?[] {fName, lName, age, email, salary, department};
            _table.Rows.Add(dataRow);
        }

        public DataRow GetLastRow()
        {
            return _table.Rows[^1];
        }
        
        public DataRow GetRow(int index)
        {
            return _table.Rows[index];
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(obj.GetType() != typeof(WebTable)) return false;
            
            WebTable webTable = (WebTable) obj;
            DataTable current = webTable._table;
            DataTable expected = _table;
            try
            {
                for (int i = 0; i < expected.Rows.Count; i++)
                {
                    for (int j = 0; j < expected.Columns.Count; j++)
                    {
                        var a = expected.Rows[i].ItemArray[j].ToString();
                        var b = current.Rows[i].ItemArray[j].ToString();
                        if (a != b ) return false;
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.ToString());
                return false;
            }

            return true;
        }
    }
}