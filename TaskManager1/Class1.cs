using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseHelper1;

namespace TaskManager1
{
    public class Class1
    {
        DatabaseHelper1.Class1 dbHelper1 = new DatabaseHelper1.Class1(); // Data Layer Instance

        public bool AddTask(string taskName, string status)
        {
            string query = "INSERT INTO tasks (task_name, status) VALUES (@task_name, @status)";
            var parameters = new Dictionary<string, object>
            {
                { "@task_name", taskName },
                { "@status", status }
            };
            return dbHelper1.ExecuteQuery(query, parameters);  // ✅ Calls Data Layer
        }

        public DataTable GetTasks()
        {
            string query = "SELECT id, task_name, status FROM tasks";
            return dbHelper1.GetData(query);  // ✅ Calls Data Layer
        }
    }
}
