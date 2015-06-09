namespace FitBase
{
    partial class Trainers
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
            this.FitnessCombo = new System.Windows.Forms.ComboBox();
            this.TrainerCombo = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FitnessCombo
            // 
            this.FitnessCombo.BackColor = System.Drawing.Color.LightGray;
            this.FitnessCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FitnessCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FitnessCombo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FitnessCombo.FormattingEnabled = true;
            this.FitnessCombo.Location = new System.Drawing.Point(238, 40);
            this.FitnessCombo.Name = "FitnessCombo";
            this.FitnessCombo.Size = new System.Drawing.Size(198, 23);
            this.FitnessCombo.TabIndex = 22;
            // 
            // TrainerCombo
            // 
            this.TrainerCombo.BackColor = System.Drawing.Color.LightGray;
            this.TrainerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrainerCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainerCombo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TrainerCombo.FormattingEnabled = true;
            this.TrainerCombo.Location = new System.Drawing.Point(12, 40);
            this.TrainerCombo.Name = "TrainerCombo";
            this.TrainerCombo.Size = new System.Drawing.Size(220, 23);
            this.TrainerCombo.TabIndex = 21;
            this.TrainerCombo.SelectedIndexChanged += new System.EventHandler(this.TrainerCombo_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label2.Location = new System.Drawing.Point(237, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(95, 15);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Fitness program:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label1.Location = new System.Drawing.Point(12, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 15);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Trainer:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Silver;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(15, 93);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Silver;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(357, 93);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 128);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.FitnessCombo);
            this.Controls.Add(this.TrainerCombo);
            this.Name = "Trainers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainers";
            this.Load += new System.EventHandler(this.Trainers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox FitnessCombo;
        internal System.Windows.Forms.ComboBox TrainerCombo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}