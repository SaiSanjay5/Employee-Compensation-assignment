
namespace EmployeeCompensationApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.CheckBox checkBoxIncludeInactive;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.checkBoxIncludeInactive = new System.Windows.Forms.CheckBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // comboBoxRole
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(30, 20);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(180, 24);
            this.comboBoxRole.TabIndex = 0;

            // comboBoxLocation
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(230, 20);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(180, 24);
            this.comboBoxLocation.TabIndex = 1;

            // checkBoxIncludeInactive
            this.checkBoxIncludeInactive.AutoSize = true;
            this.checkBoxIncludeInactive.Location = new System.Drawing.Point(430, 22);
            this.checkBoxIncludeInactive.Name = "checkBoxIncludeInactive";
            this.checkBoxIncludeInactive.Size = new System.Drawing.Size(128, 20);
            this.checkBoxIncludeInactive.TabIndex = 2;
            this.checkBoxIncludeInactive.Text = "Include Inactive";

            // buttonFilter
            this.buttonFilter.Location = new System.Drawing.Point(580, 18);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(80, 28);
            this.buttonFilter.TabIndex = 3;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);

            // buttonExport
            this.buttonExport.Location = new System.Drawing.Point(680, 18);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(80, 28);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 320);
            this.dataGridView1.TabIndex = 5;

            // MainForm
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.checkBoxIncludeInactive);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.comboBoxRole);
            this.Name = "MainForm";
            this.Text = "Employee Compensation Forecasting";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
