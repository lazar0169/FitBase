namespace FitBase
{
    partial class FitBaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitBaseForm));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.FitnessCombo = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TrainerCombo = new System.Windows.Forms.ComboBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FitnessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitnessProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFitnessProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFitnessProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(442, 50);
            this.txtSearch.MaxLength = 300;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 23);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // FitnessCombo
            // 
            this.FitnessCombo.BackColor = System.Drawing.Color.LightGray;
            this.FitnessCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FitnessCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FitnessCombo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FitnessCombo.FormattingEnabled = true;
            this.FitnessCombo.Location = new System.Drawing.Point(238, 50);
            this.FitnessCombo.Name = "FitnessCombo";
            this.FitnessCombo.Size = new System.Drawing.Size(198, 23);
            this.FitnessCombo.TabIndex = 20;
            this.FitnessCombo.SelectedIndexChanged += new System.EventHandler(this.FitnessCombo_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label2.Location = new System.Drawing.Point(237, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(95, 15);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Fitness program:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label1.Location = new System.Drawing.Point(12, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 15);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Trainer:";
            // 
            // TrainerCombo
            // 
            this.TrainerCombo.BackColor = System.Drawing.Color.LightGray;
            this.TrainerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrainerCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainerCombo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TrainerCombo.FormattingEnabled = true;
            this.TrainerCombo.Location = new System.Drawing.Point(12, 50);
            this.TrainerCombo.Name = "TrainerCombo";
            this.TrainerCombo.Size = new System.Drawing.Size(220, 23);
            this.TrainerCombo.TabIndex = 17;
            this.TrainerCombo.SelectedIndexChanged += new System.EventHandler(this.TrainerCombo_SelectedIndexChanged);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.EndDate,
            this.Dues,
            this.isPaid,
            this.Debt,
            this.FitnessID,
            this.TrainerName});
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.Color.LightGray;
            this.DataGrid.Location = new System.Drawing.Point(12, 80);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(834, 464);
            this.DataGrid.TabIndex = 14;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Expiration Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Dues
            // 
            this.Dues.HeaderText = "Dues";
            this.Dues.Name = "Dues";
            this.Dues.ReadOnly = true;
            // 
            // isPaid
            // 
            this.isPaid.HeaderText = "Paid (yes/no)";
            this.isPaid.Name = "isPaid";
            this.isPaid.ReadOnly = true;
            // 
            // Debt
            // 
            this.Debt.HeaderText = "Debt";
            this.Debt.Name = "Debt";
            this.Debt.ReadOnly = true;
            // 
            // FitnessID
            // 
            this.FitnessID.HeaderText = "Fitness Program";
            this.FitnessID.Name = "FitnessID";
            this.FitnessID.ReadOnly = true;
            // 
            // TrainerName
            // 
            this.TrainerName.HeaderText = "Trainer";
            this.TrainerName.Name = "TrainerName";
            this.TrainerName.ReadOnly = true;
            // 
            // searchCombo
            // 
            this.searchCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCombo.BackColor = System.Drawing.Color.LightGray;
            this.searchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCombo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Items.AddRange(new object[] {
            "Name",
            "Dues Status",
            "Fitness Program",
            "Trainer Name"});
            this.searchCombo.Location = new System.Drawing.Point(705, 50);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(141, 23);
            this.searchCombo.TabIndex = 29;
            this.searchCombo.SelectedIndexChanged += new System.EventHandler(this.searchCombo_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.userToolStripMenuItem1,
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "Menu1";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.createNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.trainerToolStripMenuItem,
            this.fitnessProgramToolStripMenuItem});
            this.createNewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.createNewToolStripMenuItem.Text = "Create New";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // trainerToolStripMenuItem
            // 
            this.trainerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trainerToolStripMenuItem.Image")));
            this.trainerToolStripMenuItem.Name = "trainerToolStripMenuItem";
            this.trainerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.trainerToolStripMenuItem.Text = "Trainer";
            this.trainerToolStripMenuItem.Click += new System.EventHandler(this.trainerToolStripMenuItem_Click);
            // 
            // fitnessProgramToolStripMenuItem
            // 
            this.fitnessProgramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fitnessProgramToolStripMenuItem.Image")));
            this.fitnessProgramToolStripMenuItem.Name = "fitnessProgramToolStripMenuItem";
            this.fitnessProgramToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.fitnessProgramToolStripMenuItem.Text = "Fitness Program";
            this.fitnessProgramToolStripMenuItem.Click += new System.EventHandler(this.fitnessProgramToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editTrainerToolStripMenuItem,
            this.editFitnessProgramToolStripMenuItem,
            this.addPaymentToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.deleteTrainerToolStripMenuItem,
            this.deleteFitnessProgramToolStripMenuItem});
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.userToolStripMenuItem1.Text = "Selected";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteToolStripMenuItem.Text = "Edit User";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editTrainerToolStripMenuItem
            // 
            this.editTrainerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editTrainerToolStripMenuItem.Image")));
            this.editTrainerToolStripMenuItem.Name = "editTrainerToolStripMenuItem";
            this.editTrainerToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.editTrainerToolStripMenuItem.Text = "Edit Trainer";
            this.editTrainerToolStripMenuItem.Click += new System.EventHandler(this.editTrainerToolStripMenuItem_Click);
            // 
            // editFitnessProgramToolStripMenuItem
            // 
            this.editFitnessProgramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editFitnessProgramToolStripMenuItem.Image")));
            this.editFitnessProgramToolStripMenuItem.Name = "editFitnessProgramToolStripMenuItem";
            this.editFitnessProgramToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.editFitnessProgramToolStripMenuItem.Text = "Edit Fitness Program";
            this.editFitnessProgramToolStripMenuItem.Click += new System.EventHandler(this.editFitnessProgramToolStripMenuItem_Click);
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addPaymentToolStripMenuItem.Image")));
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addPaymentToolStripMenuItem.Text = "Add Payment";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem1.Image")));
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.deleteToolStripMenuItem1.Text = "Delete User";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // deleteTrainerToolStripMenuItem
            // 
            this.deleteTrainerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteTrainerToolStripMenuItem.Image")));
            this.deleteTrainerToolStripMenuItem.Name = "deleteTrainerToolStripMenuItem";
            this.deleteTrainerToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteTrainerToolStripMenuItem.Text = "Delete Trainer";
            this.deleteTrainerToolStripMenuItem.Click += new System.EventHandler(this.deleteTrainerToolStripMenuItem_Click);
            // 
            // deleteFitnessProgramToolStripMenuItem
            // 
            this.deleteFitnessProgramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteFitnessProgramToolStripMenuItem.Image")));
            this.deleteFitnessProgramToolStripMenuItem.Name = "deleteFitnessProgramToolStripMenuItem";
            this.deleteFitnessProgramToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteFitnessProgramToolStripMenuItem.Text = "Delete Fitness Program";
            this.deleteFitnessProgramToolStripMenuItem.Click += new System.EventHandler(this.deleteFitnessProgramToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.clearAllRecordsToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // clearAllRecordsToolStripMenuItem
            // 
            this.clearAllRecordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearAllRecordsToolStripMenuItem.Image")));
            this.clearAllRecordsToolStripMenuItem.Name = "clearAllRecordsToolStripMenuItem";
            this.clearAllRecordsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.clearAllRecordsToolStripMenuItem.Text = "Clear All Records";
            this.clearAllRecordsToolStripMenuItem.Click += new System.EventHandler(this.clearAllRecordsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // FitBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(858, 556);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.FitnessCombo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TrainerCombo);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(810, 382);
            this.Name = "FitBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitBase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.ComboBox FitnessCombo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox TrainerCombo;
        internal System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitnessProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTrainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFitnessProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTrainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFitnessProgramToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dues;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitnessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainerName;
    }
}

