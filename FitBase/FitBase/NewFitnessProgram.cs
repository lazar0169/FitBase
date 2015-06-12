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
    public partial class NewFitnessProgramForm : Form
    {
        FitBaseForm form1;
        OleDbConnection conn;
        int FitnessID;
        bool isEdit;
        public NewFitnessProgramForm(FitBaseForm f1, OleDbConnection c)
        {
            InitializeComponent();
            form1 = f1;
            conn = c;
            isEdit = false;
        }
        public NewFitnessProgramForm(FitBaseForm f1, OleDbConnection c, int id)
        {
            InitializeComponent();
            form1 = f1;
            conn = c;
            FitnessID = id;

            OleDbCommand read = new OleDbCommand("SELECT * FROM FitnessProgram where FitnessID="+FitnessID+";", conn);
            OleDbDataReader dr = read.ExecuteReader();
            int b = 0;
            while (dr.Read())
            {
                txtName.Text = dr.GetString(1);
                txtGroup.Text = dr.GetString(2);
            }
            isEdit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isEdit)
                {
                    OleDbCommand add = new OleDbCommand("insert into FitnessProgram (FitnessProgram, GroupName) values ('" + txtName.Text + "','" + txtGroup.Text + "');", conn);
                    add.ExecuteNonQuery();
                    MessageBox.Show("New fitness program added !");
                    //form1.Refresh();
                    this.Close();
                }
                else 
                {
                    OleDbCommand edit = new OleDbCommand("update FitnessProgram set FitnessProgram='"+txtName.Text+"', GroupName='"+txtGroup.Text+"' where FitnessID="+FitnessID+";", conn);
                    edit.ExecuteNonQuery();
                    MessageBox.Show("Fitness program saved !");
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

    }
}
