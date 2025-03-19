using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager1;

namespace To_Do_List
{
    public partial class Form1: Form
    {
        Class1 taskManager = new Class1(); // Logic Layer Instance
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks(); // Load tasks into DataGridView when the form loads
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = txtTask.Text.Trim();
            string status = cmbStatus.SelectedItem?.ToString() ?? "Pending";

            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Please enter a task name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = taskManager.AddTask(taskName, status);
            if (success)
            {
                MessageBox.Show("Task added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTask.Clear();
                cmbStatus.SelectedIndex = -1;
                LoadTasks(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Error adding task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTasks()
        {
            dgvTasks.DataSource = taskManager.GetTasks(); // Load data from DB
        }
    }
}
