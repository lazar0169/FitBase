namespace FitBase
{
    partial class NewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDues = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.comboPaid = new System.Windows.Forms.ComboBox();
            this.comboTrainer = new System.Windows.Forms.ComboBox();
            this.comboFitness = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start date:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Silver;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(99, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtDept
            // 
            this.txtDept.BackColor = System.Drawing.Color.Silver;
            this.txtDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDept.Location = new System.Drawing.Point(99, 111);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dept:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Paid:";
            // 
            // txtDues
            // 
            this.txtDues.BackColor = System.Drawing.Color.Silver;
            this.txtDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDues.Location = new System.Drawing.Point(99, 59);
            this.txtDues.Name = "txtDues";
            this.txtDues.Size = new System.Drawing.Size(100, 20);
            this.txtDues.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dues:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fitness program:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trainer:";
            // 
            // startDate
            // 
            this.startDate.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.startDate.Location = new System.Drawing.Point(99, 33);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 2;
            // 
            // comboPaid
            // 
            this.comboPaid.AutoCompleteCustomSource.AddRange(new string[] {
            "yes",
            "no"});
            this.comboPaid.BackColor = System.Drawing.Color.DarkGray;
            this.comboPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaid.FormattingEnabled = true;
            this.comboPaid.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboPaid.Location = new System.Drawing.Point(99, 84);
            this.comboPaid.Name = "comboPaid";
            this.comboPaid.Size = new System.Drawing.Size(100, 21);
            this.comboPaid.TabIndex = 4;
            // 
            // comboTrainer
            // 
            this.comboTrainer.AutoCompleteCustomSource.AddRange(new string[] {
            "yes",
            "no"});
            this.comboTrainer.BackColor = System.Drawing.Color.DarkGray;
            this.comboTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrainer.FormattingEnabled = true;
            this.comboTrainer.Location = new System.Drawing.Point(99, 137);
            this.comboTrainer.Name = "comboTrainer";
            this.comboTrainer.Size = new System.Drawing.Size(200, 21);
            this.comboTrainer.TabIndex = 6;
            this.comboTrainer.SelectedIndexChanged += new System.EventHandler(this.comboTrainer_SelectedIndexChanged);
            // 
            // comboFitness
            // 
            this.comboFitness.AutoCompleteCustomSource.AddRange(new string[] {
            "yes",
            "no"});
            this.comboFitness.BackColor = System.Drawing.Color.DarkGray;
            this.comboFitness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFitness.FormattingEnabled = true;
            this.comboFitness.Location = new System.Drawing.Point(99, 168);
            this.comboFitness.Name = "comboFitness";
            this.comboFitness.Size = new System.Drawing.Size(200, 21);
            this.comboFitness.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Silver;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(224, 212);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Silver;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(12, 212);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(312, 247);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboFitness);
            this.Controls.Add(this.comboTrainer);
            this.Controls.Add(this.comboPaid);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDues);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDues;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.ComboBox comboPaid;
        private System.Windows.Forms.ComboBox comboTrainer;
        private System.Windows.Forms.ComboBox comboFitness;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}