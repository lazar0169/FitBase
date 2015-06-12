using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FitBase
{
    public partial class FitBaseForm : Form
    {
        OleDbConnection conn;
        IList<int> FitnessIDs;
        public FitBaseForm()
        {
             InitializeComponent();
             txtSearch.ForeColor = SystemColors.GrayText;
             txtSearch.Text = "Search by " + searchCombo.Text;
             this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
             this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
             FitnessIDs = new List<int>();
        }

        String IntStr;
        public String NoToYN (int a) {
            if (a == 1) IntStr = "yes";
            else if (a == 0) IntStr = "no";
            return IntStr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            conn = new OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BAZA.accdb; Persist Security Info=False;";
            try
            {
                conn.Open();
                // Insert code to process data.

                OleDbCommand read = new OleDbCommand("SELECT * FROM Users;", conn);
                OleDbDataReader dr = read.ExecuteReader();
                int b = 0;
                while (dr.Read())
                {
                    OleDbCommand trening = new OleDbCommand("select FitnessProgram,GroupName from FitnessProgram where FitnessID=" + dr.GetInt32(6) + ";", conn);
                    OleDbDataReader dr2 = trening.ExecuteReader();
                    dr2.Read();

                    
                    String imeTreninga = dr2.GetString(0)+", Group: "+dr2.GetString(1);
                    DataGrid.Rows.Add(dr.GetString(1), dr.GetDateTime(2), dr.GetInt32(3), NoToYN(dr.GetInt32(4)), dr.GetInt32(5), imeTreninga, dr.GetString(7));
                    DataGrid.Rows[DataGrid.RowCount-1].Tag=dr.GetInt32(0);
                    if (dr.GetDateTime(2) < DateTime.Today)
                        DataGrid.Rows[DataGrid.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                    dr2.Close();
                }
                dr.Close();
                OleDbCommand read2 = new OleDbCommand("select * from Trainer", conn);
                OleDbDataReader drTrainer = read2.ExecuteReader();

                while (drTrainer.Read()){
                    TrainerCombo.Items.Add(drTrainer.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
            foreach (DataGridViewRow row in DataGrid.Rows)
            {
                String a = row.Cells[0].Value.ToString().ToLower();
                String[] niz = a.Split(' ');
                foreach (String UName in niz)
                {
                    txtSearch.AutoCompleteCustomSource.Add(UName);
                }
                txtSearch.AutoCompleteCustomSource.Add(a);
            }
            searchCombo.SelectedIndex = searchCombo.Items.IndexOf("Name");
            txtSearch.Text = "Search by " + searchCombo.Text;

            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void TrainerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FitnessCombo.Items.Clear();
            FitnessIDs.Clear();
            String trainerName = TrainerCombo.Text;
            OleDbCommand read = new OleDbCommand("select FitnessProgram.FitnessID,FitnessProgram.FitnessProgram, FitnessProgram.GroupName from FitnessProgram,Trainer_Fitness where Trainer_Fitness.TrainerName='" + trainerName + "' and Trainer_Fitness.FitnessID=FitnessProgram.FitnessID;", conn);
            OleDbDataReader dr= read.ExecuteReader();
            while (dr.Read())
            {
                FitnessCombo.Items.Add(dr.GetString(1) + "; Grupa: " + dr.GetString(2));
                FitnessIDs.Add(dr.GetInt32(0));
            }
            DataGrid.Rows.Clear();

            read = new OleDbCommand("SELECT * FROM Users where TrainerName='" + trainerName + "';", conn);
            dr = read.ExecuteReader();
            int b = 0;
            while (dr.Read())
            {
                OleDbCommand trening = new OleDbCommand("select FitnessProgram,GroupName from FitnessProgram where FitnessID=" + dr.GetInt32(6) + ";", conn);
                OleDbDataReader dr2 = trening.ExecuteReader();
                dr2.Read();


                String imeTreninga = dr2.GetString(0) + ", Group: " + dr2.GetString(1);
                DataGrid.Rows.Add(dr.GetString(1), dr.GetDateTime(2), dr.GetInt32(3), NoToYN(dr.GetInt32(4)), dr.GetInt32(5), imeTreninga, dr.GetString(7));
                DataGrid.Rows[DataGrid.RowCount - 1].Tag = dr.GetInt32(0);
                if (dr.GetDateTime(2) < DateTime.Today)
                    DataGrid.Rows[DataGrid.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                dr2.Close();
            }
            dr.Close();

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by " + searchCombo.Text)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                txtSearch.Text = "Search by " + searchCombo.Text;
                txtSearch.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in DataGrid.Rows)
                {
                    if (searchCombo.SelectedIndex == 0)
                    {
                        
                        if (row.Cells[0].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower())) row.Visible = true;
                        else row.Visible = false;
                    }
                    else if (searchCombo.SelectedIndex == 1)
                    {
                        if (row.Cells[3].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower())) row.Visible = true;
                        else row.Visible = false;
                    }
                    else if (searchCombo.SelectedIndex == 2)
                    {
                        if (row.Cells[5].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower())) row.Visible = true;
                        else row.Visible = false;
                    }
                    else if (searchCombo.SelectedIndex == 3)
                    {
                        if (row.Cells[6].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower())) row.Visible = true;
                        else row.Visible = false;
                    }
                    else
                    {
                        if (row.Cells[0].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower())) row.Visible = true;
                        else row.Visible = false;
                    }
                }
            }
            catch (Exception exc)
            {
            }
        }

        private void searchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchCombo.SelectedIndex == 1) txtSearch.AutoCompleteMode = AutoCompleteMode.None;
            else if (searchCombo.SelectedIndex == 2) txtSearch.AutoCompleteMode = AutoCompleteMode.None;
            else if (searchCombo.SelectedIndex == 3) txtSearch.AutoCompleteMode = AutoCompleteMode.None;
            else txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;

            txtSearch.Text = "Search by " + searchCombo.Text;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure?",
                                     "Confirm Exit",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser(this, conn);
            nu.Show();
        }

        private void trainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainerForm tf = new TrainerForm(this, conn);
            tf.Show();
        }

        private void fitnessProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFitnessProgramForm nfp = new NewFitnessProgramForm(this, conn);
            nfp.Show();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            TrainerCombo.Items.Clear();
            FitnessCombo.Items.Clear();

            conn = new OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BAZA.accdb; Persist Security Info=False;";
            try
            {
                conn.Open();
                // Insert code to process data.

                OleDbCommand read = new OleDbCommand("SELECT * FROM Users;", conn);
                OleDbDataReader dr = read.ExecuteReader();
                while (dr.Read())
                {
                    OleDbCommand trening = new OleDbCommand("select FitnessProgram,GroupName from FitnessProgram where FitnessID=" + dr.GetInt32(6) + ";", conn);
                    OleDbDataReader dr2 = trening.ExecuteReader();
                    dr2.Read();


                    String imeTreninga = dr2.GetString(0) + ", Group: " + dr2.GetString(1);
                    DataGrid.Rows.Add(dr.GetString(1), dr.GetDateTime(2), dr.GetInt32(3), NoToYN(dr.GetInt32(4)), dr.GetInt32(5), imeTreninga, dr.GetString(7));
                    DataGrid.Rows[DataGrid.RowCount - 1].Tag = dr.GetInt32(0);
                    if (dr.GetDateTime(2) < DateTime.Today)
                        DataGrid.Rows[DataGrid.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                    dr2.Close();
                }
                dr.Close();
                OleDbCommand read2 = new OleDbCommand("select * from Trainer", conn);
                OleDbDataReader drTrainer = read2.ExecuteReader();

                while (drTrainer.Read())
                {
                    TrainerCombo.Items.Add(drTrainer.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
            foreach (DataGridViewRow row in DataGrid.Rows)
            {
                String a = row.Cells[0].Value.ToString().ToLower();
                String[] niz = a.Split(' ');
                foreach (String UName in niz)
                {
                    txtSearch.AutoCompleteCustomSource.Add(UName);
                }
                txtSearch.AutoCompleteCustomSource.Add(a);
            }
            searchCombo.SelectedIndex = searchCombo.Items.IndexOf("Name");
            txtSearch.Text = "Search by " + searchCombo.Text;
        }

        public void reload()
        {
            DataGrid.Rows.Clear();
            TrainerCombo.Items.Clear();
            FitnessCombo.Items.Clear();

            conn = new OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BAZA.accdb; Persist Security Info=False;";
            try
            {
                conn.Open();
                // Insert code to process data.

                OleDbCommand read = new OleDbCommand("SELECT * FROM Users;", conn);
                OleDbDataReader dr = read.ExecuteReader();
                while (dr.Read())
                {
                    OleDbCommand trening = new OleDbCommand("select FitnessProgram,GroupName from FitnessProgram where FitnessID=" + dr.GetInt32(6) + ";", conn);
                    OleDbDataReader dr2 = trening.ExecuteReader();
                    dr2.Read();


                    String imeTreninga = dr2.GetString(0) + ", Group: " + dr2.GetString(1);
                    DataGrid.Rows.Add(dr.GetString(1), dr.GetDateTime(2), dr.GetInt32(3), NoToYN(dr.GetInt32(4)), dr.GetInt32(5), imeTreninga, dr.GetString(7));
                    DataGrid.Rows[DataGrid.RowCount - 1].Tag = dr.GetInt32(0);
                    if (dr.GetDateTime(2) < DateTime.Today)
                        DataGrid.Rows[DataGrid.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                    dr2.Close();
                }
                dr.Close();
                OleDbCommand read2 = new OleDbCommand("select * from Trainer", conn);
                OleDbDataReader drTrainer = read2.ExecuteReader();

                while (drTrainer.Read())
                {
                    TrainerCombo.Items.Add(drTrainer.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
            foreach (DataGridViewRow row in DataGrid.Rows)
            {
                String a = row.Cells[0].Value.ToString().ToLower();
                String[] niz = a.Split(' ');
                foreach (String UName in niz)
                {
                    txtSearch.AutoCompleteCustomSource.Add(UName);
                }
                txtSearch.AutoCompleteCustomSource.Add(a);
            }
            searchCombo.SelectedIndex = searchCombo.Items.IndexOf("Name");
            txtSearch.Text = "Search by " + searchCombo.Text;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow r in DataGrid.SelectedRows)
            {
                int id = (int)r.Tag;
                NewUser nu = new NewUser(this, conn, id);
                nu.Show();
            }
            
        }

        private void editTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name = TrainerCombo.Text;
            TrainerForm tf = new TrainerForm(this,conn,name);
            tf.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in DataGrid.SelectedRows)
                {
                    int id = (int)r.Tag;
                    OleDbCommand delete = new OleDbCommand("delete  from Users where UserID=" + id + ";", conn);
                    delete.ExecuteNonQuery();
                }
            }
           
        }

        private void editFitnessProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = FitnessIDs[FitnessCombo.SelectedIndex];
                NewFitnessProgramForm fp = new NewFitnessProgramForm(this, conn, id);
                fp.Show();
            }
            catch
            {
                MessageBox.Show("Please select fitness program first.");
            }
            
        }

        private void clearAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure?",
                                        "Confirm Delete",
                                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    OleDbCommand deleteUsers = new OleDbCommand("delete  from Users;", conn);
                    deleteUsers.ExecuteNonQuery();
                    OleDbConnection.ReleaseObjectPool();
                    OleDbCommand deleteCorelation = new OleDbCommand("delete  from Trainer_Fitness;", conn);
                    deleteCorelation.ExecuteNonQuery();
                    OleDbConnection.ReleaseObjectPool();
                    OleDbCommand deleteTrainer = new OleDbCommand("delete  from Trainer;", conn);
                    deleteTrainer.ExecuteNonQuery();
                    OleDbConnection.ReleaseObjectPool();
                    OleDbCommand deleteProgram = new OleDbCommand("delete  from FitnessProgram;", conn);
                    deleteProgram.ExecuteNonQuery();
                    MessageBox.Show("Database has been cleared!");
                    reload();
                }
                catch { MessageBox.Show("Error"); }
                
            }
        }

        private void deleteTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String name = TrainerCombo.Text;
                var confirmResult = MessageBox.Show("Are you sure?",
                                        "Confirm Delete",
                                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var confirmResult2 = MessageBox.Show("Delete all corelated users?",
                                       "Confirm",
                                       MessageBoxButtons.YesNo);
                    if (confirmResult2 == DialogResult.Yes)
                    {
                        OleDbCommand deleteUsers = new OleDbCommand("delete  from Users where TrainerName='" + name + "';", conn);
                        deleteUsers.ExecuteNonQuery();
                        OleDbCommand deleteCorelation = new OleDbCommand("delete  from Trainer_Fitness where TrainerName='" + name + "';", conn);
                        deleteCorelation.ExecuteNonQuery();
                        OleDbCommand deleteTrainer = new OleDbCommand("delete  from Trainer where TrainerName='" + name + "';", conn);
                        deleteTrainer.ExecuteNonQuery();
                        MessageBox.Show("Trainer deleted");
                    }
                    else if (confirmResult2 == DialogResult.No)
                    {
                        Trainers t = new Trainers(this, conn, name);
                        var a = t.ShowDialog();
                        if (a == DialogResult.OK)
                        {
                            OleDbCommand editUsers = new OleDbCommand("update Users set TrainerName='" + currentTrainerName + "',FitnessID=" + currentFitnessProgramID + " where TrainerName='" + name + "';", conn);
                            editUsers.ExecuteNonQuery();
                            OleDbCommand deleteCorelation = new OleDbCommand("delete  from Trainer_Fitness where TrainerName='" + name + "';", conn);
                            deleteCorelation.ExecuteNonQuery();
                            OleDbCommand deleteTrainer = new OleDbCommand("delete  from Trainer where TrainerName='" + name + "';", conn);
                            deleteTrainer.ExecuteNonQuery();
                            MessageBox.Show("Trainer deleted");
                        }


                    }
                }
            

            }
            catch
            {
                MessageBox.Show("Error...");
            }
        }

        public String currentTrainerName{get;set;}
        public int currentFitnessProgramID{get;set;}

        private void deleteFitnessProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               int id = FitnessIDs[FitnessCombo.SelectedIndex];
                var confirmResult = MessageBox.Show("Are you sure?",
                                        "Confirm Delete",
                                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var confirmResult2 = MessageBox.Show("Delete all corelated users?",
                                       "Confirm",
                                       MessageBoxButtons.YesNo);
                    if (confirmResult2 == DialogResult.Yes)
                    {
                        OleDbCommand deleteUsers = new OleDbCommand("delete  from Users where FitnessID=" + id + ";", conn);
                        deleteUsers.ExecuteNonQuery();
                        OleDbCommand deleteCorelation = new OleDbCommand("delete  from Trainer_Fitness where FitnessID=" + id + ";", conn);
                        deleteCorelation.ExecuteNonQuery();
                        OleDbCommand deleteTrainer = new OleDbCommand("delete  from FitnessProgram where FitnessID=" + id + ";", conn);
                        deleteTrainer.ExecuteNonQuery();
                        MessageBox.Show("Fitness Program deleted");
                    }
                    else if (confirmResult2 == DialogResult.No)
                    {
                        Trainers t = new Trainers(this, conn, id);
                        var a = t.ShowDialog();
                        if (a == DialogResult.OK)
                        {
                            OleDbCommand editUsers = new OleDbCommand("update Users set TrainerName='" + currentTrainerName + "',FitnessID=" + currentFitnessProgramID + " where FitnessID=" + id + ";", conn);
                            editUsers.ExecuteNonQuery();
                            OleDbCommand deleteCorelation = new OleDbCommand("delete  from Trainer_Fitness where FitnessID=" + id + ";", conn);
                            deleteCorelation.ExecuteNonQuery();
                            OleDbCommand deleteTrainer = new OleDbCommand("delete  from FitnessProgram where FitnessID=" + id + ";", conn);
                            deleteTrainer.ExecuteNonQuery();
                            MessageBox.Show("Fitness Program deleted");
                        }
                    }
                }


            }
            catch
            {
                MessageBox.Show("Error...");
            }
        }

        private void FitnessCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String trainerName = TrainerCombo.Text;
            DataGrid.Rows.Clear();
            int FitnessID = FitnessIDs[FitnessCombo.SelectedIndex];
            OleDbCommand read = new OleDbCommand("SELECT * FROM Users where TrainerName='" + trainerName + "' and FitnessID=" + FitnessID + ";", conn);
            OleDbDataReader dr = read.ExecuteReader();
            int b = 0;
            while (dr.Read())
            {
                OleDbCommand trening = new OleDbCommand("select FitnessProgram,GroupName from FitnessProgram where FitnessID=" + dr.GetInt32(6) + ";", conn);
                OleDbDataReader dr2 = trening.ExecuteReader();
                dr2.Read();


                String imeTreninga = dr2.GetString(0) + ", Group: " + dr2.GetString(1);
                DataGrid.Rows.Add(dr.GetString(1), dr.GetDateTime(2), dr.GetInt32(3), NoToYN(dr.GetInt32(4)), dr.GetInt32(5), imeTreninga, dr.GetString(7));
                DataGrid.Rows[DataGrid.RowCount - 1].Tag = dr.GetInt32(0);
                if (dr.GetDateTime(2) < DateTime.Today)
                    DataGrid.Rows[DataGrid.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                dr2.Close();
            }
            dr.Close();
        }


    }
}
