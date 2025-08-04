namespace SplitBuddies.App.Views
{
    partial class frmExpenses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.txtExpenseLink = new System.Windows.Forms.TextBox();
            this.clbExpenseParticipants = new System.Windows.Forms.CheckedListBox();
            this.cmbExpensePayer = new System.Windows.Forms.ComboBox();
            this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.numExpenseAmount = new System.Windows.Forms.NumericUpDown();
            this.txtExpenseDescription = new System.Windows.Forms.TextBox();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.cmbExpenseGroup = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpenseAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddExpense);
            this.groupBox1.Controls.Add(this.txtExpenseLink);
            this.groupBox1.Controls.Add(this.clbExpenseParticipants);
            this.groupBox1.Controls.Add(this.cmbExpensePayer);
            this.groupBox1.Controls.Add(this.dtpExpenseDate);
            this.groupBox1.Controls.Add(this.numExpenseAmount);
            this.groupBox1.Controls.Add(this.txtExpenseDescription);
            this.groupBox1.Controls.Add(this.txtExpenseName);
            this.groupBox1.Controls.Add(this.cmbExpenseGroup);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Nuevo Gasto";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(629, 158);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(141, 23);
            this.btnAddExpense.TabIndex = 16;
            this.btnAddExpense.Text = "Agregar Gasto";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click_1);
            // 
            // txtExpenseLink
            // 
            this.txtExpenseLink.Location = new System.Drawing.Point(384, 160);
            this.txtExpenseLink.Name = "txtExpenseLink";
            this.txtExpenseLink.Size = new System.Drawing.Size(121, 20);
            this.txtExpenseLink.TabIndex = 15;
            // 
            // clbExpenseParticipants
            // 
            this.clbExpenseParticipants.FormattingEnabled = true;
            this.clbExpenseParticipants.Location = new System.Drawing.Point(629, 18);
            this.clbExpenseParticipants.Name = "clbExpenseParticipants";
            this.clbExpenseParticipants.Size = new System.Drawing.Size(141, 139);
            this.clbExpenseParticipants.TabIndex = 14;
            // 
            // cmbExpensePayer
            // 
            this.cmbExpensePayer.FormattingEnabled = true;
            this.cmbExpensePayer.Location = new System.Drawing.Point(351, 88);
            this.cmbExpensePayer.Name = "cmbExpensePayer";
            this.cmbExpensePayer.Size = new System.Drawing.Size(121, 21);
            this.cmbExpensePayer.TabIndex = 13;
            // 
            // dtpExpenseDate
            // 
            this.dtpExpenseDate.Location = new System.Drawing.Point(351, 57);
            this.dtpExpenseDate.Name = "dtpExpenseDate";
            this.dtpExpenseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpExpenseDate.TabIndex = 12;
            // 
            // numExpenseAmount
            // 
            this.numExpenseAmount.DecimalPlaces = 3;
            this.numExpenseAmount.Location = new System.Drawing.Point(352, 24);
            this.numExpenseAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numExpenseAmount.Name = "numExpenseAmount";
            this.numExpenseAmount.Size = new System.Drawing.Size(120, 20);
            this.numExpenseAmount.TabIndex = 11;
            this.numExpenseAmount.ThousandsSeparator = true;
            // 
            // txtExpenseDescription
            // 
            this.txtExpenseDescription.Location = new System.Drawing.Point(91, 149);
            this.txtExpenseDescription.Name = "txtExpenseDescription";
            this.txtExpenseDescription.Size = new System.Drawing.Size(124, 20);
            this.txtExpenseDescription.TabIndex = 10;
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(114, 100);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseName.TabIndex = 9;
            // 
            // cmbExpenseGroup
            // 
            this.cmbExpenseGroup.FormattingEnabled = true;
            this.cmbExpenseGroup.Location = new System.Drawing.Point(90, 26);
            this.cmbExpenseGroup.Name = "cmbExpenseGroup";
            this.cmbExpenseGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbExpenseGroup.TabIndex = 8;
            this.cmbExpenseGroup.SelectedIndexChanged += new System.EventHandler(this.cmbExpenseGroup_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Participantes ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Enlace (opcional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pagado por";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Gasto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvExpenses);
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gastos Registrados";
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenses.Location = new System.Drawing.Point(3, 16);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.Size = new System.Drawing.Size(743, 219);
            this.dgvExpenses.TabIndex = 0;
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExpenses";
            this.Text = "frmExpenses";
            this.Load += new System.EventHandler(this.frmExpenses_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpenseAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbExpenseGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpenseDescription;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.DateTimePicker dtpExpenseDate;
        private System.Windows.Forms.NumericUpDown numExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseLink;
        private System.Windows.Forms.CheckedListBox clbExpenseParticipants;
        private System.Windows.Forms.ComboBox cmbExpensePayer;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvExpenses;
    }
}