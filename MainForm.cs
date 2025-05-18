
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EmployeeCompensationApp
{
    public partial class MainForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            string role = comboBoxRole.SelectedItem?.ToString();
            string location = comboBoxLocation.SelectedItem?.ToString();
            bool includeInactive = checkBoxIncludeInactive.Checked;

            DataTable dt = db.FilterEmployees(role, location, includeInactive);
            dataGridView1.DataSource = dt;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    FileName = "Filtered_Employees.csv"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(dt, sfd.FileName);
                    MessageBox.Show("Data exported successfully.");
                }
            }
        }

        private void ExportToCSV(DataTable dt, string path)
        {
            StringBuilder sb = new StringBuilder();

            string[] columnNames = new string[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                columnNames[i] = dt.Columns[i].ColumnName;

            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(f => f.ToString().Replace(",", " ")).ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(path, sb.ToString());
        }
    }
}
