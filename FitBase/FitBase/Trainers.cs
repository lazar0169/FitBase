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
    public partial class Trainers : Form
    {
        FitBaseForm form1;
        OleDbConnection conn;
        String TrainerName;
        int FitnessID;
        IList<int> FitnessIDs;
        bool forTrainer;
        public Trainers()
        {
            InitializeComponent();
        }
        public Trainers(FitBaseForm f, OleDbConnection c, String name)
        {
            InitializeComponent();
            form1 = f;
            conn = c;
            TrainerName = name;
            forTrainer = true;
            FitnessIDs = new List<int>();
            buttonSave.DialogResult = DialogResult.OK;
        }
        public Trainers(FitBaseForm f, OleDbConnection c, int id)
        {
            InitializeComponent();
            form1 = f;
            conn = c;
            FitnessID = id;
            forTrainer = false;
            FitnessIDs = new List<int>();
            buttonSave.DialogResult = DialogResult.OK;
        }
        private void Trainers_Load(object sender, EventArgs e)
        {
            if (forTrainer)
            {
                OleDbCommand read2 = new OleDbCommand("select * from Trainer where TrainerName<>'" + TrainerName + "';", conn);
                OleDbDataReader drTrainer = read2.ExecuteReader();

                while (drTrainer.Read())
                {
                    TrainerCombo.Items.Add(drTrainer.GetString(0));
                }
            }
            else
            {
                OleDbCommand read2 = new OleDbCommand("select * from Trainer;", conn);
                OleDbDataReader drTrainer = read2.ExecuteReader();

                while (drTrainer.Read())
                {
                    TrainerCombo.Items.Add(drTrainer.GetString(0));
                }
            }
            
        }

        private void TrainerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forTrainer)
            {
                FitnessCombo.Items.Clear();
                FitnessIDs.Clear();
                String trainerName = TrainerCombo.Text;
                OleDbCommand read = new OleDbCommand("select FitnessProgram.FitnessID,FitnessProgram.FitnessProgram, FitnessProgram.GroupName from FitnessProgram,Trainer_Fitness where Trainer_Fitness.TrainerName='" + trainerName + "' and Trainer_Fitness.FitnessID=FitnessProgram.FitnessID;", conn);
                OleDbDataReader dr = read.ExecuteReader();
                while (dr.Read())
                {
                    FitnessCombo.Items.Add(dr.GetString(1) + "; Grupa: " + dr.GetString(2));
                    FitnessIDs.Add(dr.GetInt32(0));
                }
            }
            else
            {
                FitnessCombo.Items.Clear();
                FitnessIDs.Clear();
                String trainerName = TrainerCombo.Text;
                OleDbCommand read = new OleDbCommand("select FitnessProgram.FitnessID,FitnessProgram.FitnessProgram, FitnessProgram.GroupName from FitnessProgram,Trainer_Fitness where Trainer_Fitness.TrainerName='" + trainerName + "'and Trainer_Fitness.FitnessID<>" + FitnessID + " and Trainer_Fitness.FitnessID=FitnessProgram.FitnessID;", conn);
                OleDbDataReader dr = read.ExecuteReader();
                while (dr.Read())
                {
                    FitnessCombo.Items.Add(dr.GetString(1) + "; Grupa: " + dr.GetString(2));
                    FitnessIDs.Add(dr.GetInt32(0));
                }
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            form1.currentTrainerName = TrainerCombo.Text;
            form1.currentFitnessProgramID = FitnessIDs[FitnessCombo.SelectedIndex];
            this.Close();
        }
    }
}
