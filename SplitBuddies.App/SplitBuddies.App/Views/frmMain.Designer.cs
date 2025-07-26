namespace SplitBuddies.App.Views
{
    partial class frmMain
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
            this.dgvBalances = new System.Windows.Forms.DataGridView();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageGroups = new System.Windows.Forms.Button();
            this.btnManageExpenses = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBalances
            // 
            this.dgvBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalances.Location = new System.Drawing.Point(218, 12);
            this.dgvBalances.Name = "dgvBalances";
            this.dgvBalances.Size = new System.Drawing.Size(570, 352);
            this.dgvBalances.TabIndex = 0;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(23, 15);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(120, 23);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Gestionar Usuarios";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click_1);
            // 
            // btnManageGroups
            // 
            this.btnManageGroups.Location = new System.Drawing.Point(23, 69);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.Size = new System.Drawing.Size(120, 23);
            this.btnManageGroups.TabIndex = 2;
            this.btnManageGroups.Text = "Gestionar Grupos";
            this.btnManageGroups.UseVisualStyleBackColor = true;
            this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click_1);
            // 
            // btnManageExpenses
            // 
            this.btnManageExpenses.Location = new System.Drawing.Point(23, 120);
            this.btnManageExpenses.Name = "btnManageExpenses";
            this.btnManageExpenses.Size = new System.Drawing.Size(120, 23);
            this.btnManageExpenses.TabIndex = 3;
            this.btnManageExpenses.Text = "Gestionar Gastos";
            this.btnManageExpenses.UseVisualStyleBackColor = true;
            this.btnManageExpenses.Click += new System.EventHandler(this.btnManageExpenses_Click_1);
            // 
            // btnViewReports
            // 
            this.btnViewReports.Location = new System.Drawing.Point(23, 177);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(126, 23);
            this.btnViewReports.TabIndex = 4;
            this.btnViewReports.Text = "Ver Reportes";
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(23, 306);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnManageUsers);
            this.panel1.Controls.Add(this.btnViewReports);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnManageGroups);
            this.panel1.Controls.Add(this.btnManageExpenses);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 352);
            this.panel1.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBalances);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBalances;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageGroups;
        private System.Windows.Forms.Button btnManageExpenses;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
    }
}