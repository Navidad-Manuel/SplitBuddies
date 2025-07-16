namespace SplitBuddies.App
{
    partial class frmDashboard
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
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.Grupos = new System.Windows.Forms.TabPage();
            this.Gastos = new System.Windows.Forms.TabPage();
            this.Saldosdgv = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabcontrol.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Saldosdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.Dashboard);
            this.tabcontrol.Controls.Add(this.Usuarios);
            this.tabcontrol.Controls.Add(this.Grupos);
            this.tabcontrol.Controls.Add(this.Gastos);
            this.tabcontrol.Location = new System.Drawing.Point(3, 2);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(803, 451);
            this.tabcontrol.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.btnAddUser);
            this.Dashboard.Controls.Add(this.txtEmail);
            this.Dashboard.Controls.Add(this.label2);
            this.Dashboard.Controls.Add(this.txtName);
            this.Dashboard.Controls.Add(this.label1);
            this.Dashboard.Controls.Add(this.btnRefresh);
            this.Dashboard.Controls.Add(this.Saldosdgv);
            this.Dashboard.Location = new System.Drawing.Point(4, 22);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(795, 425);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            this.Usuarios.Controls.Add(this.dataGridView1);
            this.Usuarios.Controls.Add(this.button1);
            this.Usuarios.Controls.Add(this.textBox2);
            this.Usuarios.Controls.Add(this.label4);
            this.Usuarios.Controls.Add(this.textBox1);
            this.Usuarios.Controls.Add(this.label3);
            this.Usuarios.Location = new System.Drawing.Point(4, 22);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.Usuarios.Size = new System.Drawing.Size(795, 425);
            this.Usuarios.TabIndex = 1;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // Grupos
            // 
            this.Grupos.Location = new System.Drawing.Point(4, 22);
            this.Grupos.Name = "Grupos";
            this.Grupos.Padding = new System.Windows.Forms.Padding(3);
            this.Grupos.Size = new System.Drawing.Size(795, 425);
            this.Grupos.TabIndex = 2;
            this.Grupos.Text = "Grupos";
            this.Grupos.UseVisualStyleBackColor = true;
            // 
            // Gastos
            // 
            this.Gastos.Location = new System.Drawing.Point(4, 22);
            this.Gastos.Name = "Gastos";
            this.Gastos.Padding = new System.Windows.Forms.Padding(3);
            this.Gastos.Size = new System.Drawing.Size(795, 425);
            this.Gastos.TabIndex = 3;
            this.Gastos.Text = "Gastos";
            this.Gastos.UseVisualStyleBackColor = true;
            // 
            // Saldosdgv
            // 
            this.Saldosdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Saldosdgv.Location = new System.Drawing.Point(0, 0);
            this.Saldosdgv.Name = "Saldosdgv";
            this.Saldosdgv.Size = new System.Drawing.Size(792, 422);
            this.Saldosdgv.TabIndex = 0;
            this.Saldosdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBalances_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(28, 363);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Actualizar Balances";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(66, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(28, 316);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(120, 23);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrol);
            this.Name = "frmDashboard";
            this.Text = "Form1";
            this.tabcontrol.ResumeLayout(false);
            this.Dashboard.ResumeLayout(false);
            this.Dashboard.PerformLayout();
            this.Usuarios.ResumeLayout(false);
            this.Usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Saldosdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage Dashboard;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.TabPage Grupos;
        private System.Windows.Forms.TabPage Gastos;
        private System.Windows.Forms.DataGridView Saldosdgv;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

