using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitBase;
using System.Data.OleDb;

namespace FitBase
{
    public partial class NewUser : Form
    {
        FitBaseForm form1;
        OleDbConnection conn;
        IList<int> fitnessIDs;
        int userID;
        bool isEdit;

        public NewUser()
        {
            InitializeComponent();
        }
        public NewUser(FitBaseForm f1,OleDbConnection c)
        {
            InitializeComponent();
            form1 = f1;
            fitnessIDs = new List<int>();
            conn = c;
            insertTrainers();
            isEdit = false;

        }
        String IntStr;
        public String NoToYN(int a)
        {
            if (a == 1) IntStr = "yes";
            else if (a == 0) IntStr = "no";
            return IntStr;
        }
        public NewUser(FitBaseForm f1, OleDbConnection c,int id)
        {
            InitializeComponent();
            form1 = f1;
            fitnessIDs = new List<int>();
            conn = c;
            userID = id;
            insertTrainers();
            isEdit = true;
            OleDbCommand read = new OleDbCommand("SELECT * FROM Users where userID="+userID+";", conn);
            OleDbDataReader dr = read.ExecuteReader();
            int b = 0;
            while (dr.Read())
            {
                OleDbCommand trening = new OleDbCommand("select FitnessProgram.FitnessID, FitnessProgram.FitnessProgram, FitnessProgram.GroupName from FitnessProgram where FitnessID=" + dr.GetInt32(6) + ";", conn);
                OleDbDataReader dr2 = trening.ExecuteReader();
                dr2.Read();


                String imeTreninga = dr2.GetString(1);
                String imeGrupe = dr2.GetString(2);

                txtName.Text = dr.GetString(1);
                startDate.Value = Convert.ToDateTime(dr.GetDateTime(2));
                txtDues.Text = dr.GetInt32(3).ToString();
                comboPaid.SelectedIndex = dr.GetInt32(4);
                txtDept.Text = dr.GetInt32(5).ToString();
                comboTrainer.Text = dr.GetString(7);
                comboFitness.Text = imeTreninga + "; Grupa: " + imeGrupe;
                dr2.Close();
            }
            dr.Close();
        }
        public void insertTrainers()
        {
            OleDbCommand read2 = new OleDbCommand("select * from Trainer", conn);
            OleDbDataReader drTrainer = read2.ExecuteReader();

            while (drTrainer.Read())
            {
                comboTrainer.Items.Add(drTrainer.GetString(0));
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(!isEdit)
                {
                    OleDbCommand fitnessID = new OleDbCommand("select fitnessID from FitnessProgram where FitnessProgram='" + comboFitness.Text + "';", conn);
                    OleDbCommand add = new OleDbCommand("insert into Users (Name, StartDate, Dues,isPaid,Debt,FitnessID,TrainerName) values ('" + txtName.Text + "',@date," + Convert.ToInt32(txtDues.Text) + "," + comboPaid.SelectedIndex + "," + Convert.ToInt32(txtDept.Text) + "," + fitnessIDs[comboFitness.SelectedIndex] + ",'" + comboTrainer.Text + "');", conn);
                    add.Parameters.AddWithValue("@date", startDate.Value.Date);
                    add.ExecuteNonQuery();
                    MessageBox.Show("New User added !");
                    //form1.Refresh();
                    this.Close();
                }
                else
                {
                    OleDbCommand edit = new OleDbCommand("update Users set Name='" + txtName.Text + "', StartDate=@date, Dues=" + Convert.ToInt32(txtDues.Text) + ",isPaid=" + comboPaid.SelectedIndex + ",Debt=" + Convert.ToInt32(txtDept.Text) + ",FitnessID=" + fitnessIDs[comboFitness.SelectedIndex] + ",TrainerName='" + comboTrainer.Text + "' where userID="+userID+";", conn);
                    edit.Parameters.AddWithValue("@date", startDate.Value.Date);
                    edit.ExecuteNonQuery();
                    MessageBox.Show("User saved");
                    this.Close();
                }
               
            }
            catch
            {
                MessageBox.Show("Error");
            }
            

        }

        private void comboTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFitness.Items.Clear();
            String trainerName = comboTrainer.Text;
            OleDbCommand read = new OleDbCommand("select FitnessProgram.FitnessID, FitnessProgram.FitnessProgram, FitnessProgram.GroupName from FitnessProgram,Trainer_Fitness where Trainer_Fitness.TrainerName='" + trainerName + "' and Trainer_Fitness.FitnessID=FitnessProgram.FitnessID;", conn);
            OleDbDataReader dr = read.ExecuteReader();
            while (dr.Read())
            {
                comboFitness.Items.Add(dr.GetString(1) + "; Grupa: " + dr.GetString(2));
                fitnessIDs.Add(dr.GetInt32(0));
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
