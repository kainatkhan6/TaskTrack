namespace To_Do_List
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTasks
            // 
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(109, 356);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 62;
            this.dgvTasks.RowTemplate.Height = 28;
            this.dgvTasks.Size = new System.Drawing.Size(689, 150);
            this.dgvTasks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "To-Do List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTask
            // 
            this.lblTask.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTask.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(227, 109);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(163, 35);
            this.lblTask.TabIndex = 2;
            this.lblTask.Text = "Task Name";
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(227, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(163, 35);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(506, 109);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(163, 35);
            this.txtTask.TabIndex = 4;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending ",
            "In Progress",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(506, 182);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(163, 35);
            this.cmbStatus.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(353, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(195, 46);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 532);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTasks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;
    }
}

