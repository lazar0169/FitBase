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
    public partial class TrainerForm : Form
    {
        FitBaseForm form1;
        OleDbConnection conn;
        IList<int> fitnessIDs;
        String TrainerName;
        bool isEdit;

        public TrainerForm()
        {
            InitializeComponent();

        }
        public TrainerForm(FitBaseForm f1, OleDbConnection c)
        {
            InitializeComponent();
            fitnessIDs = new List<int>();
            form1 = f1;
            conn = c;
            
            isEdit = false;
        }
        public TrainerForm(FitBaseForm f1, OleDbConnection c,String name)
        {
            InitializeComponent();
            fitnessIDs = new List<int>();
            form1 = f1;
            conn = c;
            TrainerName = name;
            txtName.Text = TrainerName;
            txtName.Enabled = false;
            isEdit = true;
            
            //readFitnessPrograms();
        }
        public void readFitnessPrograms()
        {
            dataGridView1.Rows.Clear();
            OleDbCommand read = new OleDbCommand("select FitnessProgram.FitnessID, FitnessProgram.FitnessProgram, FitnessProgram.GroupName from FitnessProgram;", conn);
            OleDbDataReader dr = read.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetString(1), dr.GetString(2));
                fitnessIDs.Add(dr.GetInt32(0));
            }
        }

        public void readMyPrograms()
        {
            dataGridView1.Rows.Clear();
            OleDbCommand read = new OleDbCommand("select FitnessProgram.FitnessID, FitnessProgram.FitnessProgram, FitnessProgram.GroupName from FitnessProgram,Trainer_Fitness where Trainer_Fitness.TrainerName='" + TrainerName + "' and FitnessProgram.FitnessID=Trainer_Fitness.FitnessID;", conn);
            OleDbDataReader dr = read.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetString(1), dr.GetString(2));
                dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
                //foreach (DataGridViewRow r in dataGridView1.Rows)
                //{
                //    r.Selected = true;
                //}
                
                fitnessIDs.Add(dr.GetInt32(0));
            }
        }
        public void readNotMyPrograms()
        {
            OleDbCommand read = new OleDbCommand("select FitnessProgram.FitnessID, FitnessProgram.FitnessProgram, FitnessProgram.GroupName from FitnessProgram;", conn);
            OleDbDataReader dr = read.ExecuteReader();
            while (dr.Read())
            {
                if (!fitnessIDs.Contains(dr.GetInt32(0)))
                {
                    dataGridView1.Rows.Add(dr.GetString(1), dr.GetString(2));
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = false;
                    fitnessIDs.Add(dr.GetInt32(0));
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isEdit)
                {
                    OleDbCommand add = new OleDbCommand("insert into Trainer (TrainerName) values ('" + txtName.Text + "');", conn);
                    add.ExecuteNonQuery();
                    foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                    {
                        OleDbCommand connect = new OleDbCommand("insert into Trainer_Fitness (TrainerName, FitnessID) values  ('" + txtName.Text + "'," + fitnessIDs[r.Index] + ");", conn);
                        connect.ExecuteNonQuery();
                    }
                    MessageBox.Show("New Trainer added !");
                    //form1.Refresh();
                    this.Close();
                }
                else
                {
                    OleDbCommand delete = new OleDbCommand("delete  from Trainer_Fitness where TrainerName='" + txtName.Text + "';", conn);
                    delete.ExecuteNonQuery();
                    foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                    {
                        OleDbCommand connect = new OleDbCommand("insert into Trainer_Fitness (TrainerName, FitnessID) values  ('" + txtName.Text + "'," + fitnessIDs[r.Index] + ");", conn);
                        connect.ExecuteNonQuery();
                    }
                    MessageBox.Show("Trainer saved !");
                    //form1.Refresh();
                    this.Close();
                }
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            form1.reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrainerForm_Shown(object sender, EventArgs e)
        {
            try 
            {
                if(!isEdit)
                    readFitnessPrograms();
                else
                {
                    readMyPrograms();
                    readNotMyPrograms();
                }
                
            }
            catch { }
        }
    }
}
