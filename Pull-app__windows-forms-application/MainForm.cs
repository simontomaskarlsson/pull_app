using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pull_app__windows_forms_application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void vadarenpullup(object sender, EventArgs e)
        {
            MessageBox.Show("Jo, man drar sig från hängande till hakan över stång.\nAlla varianter räknas, +1 för varje genomförd!\n\nHur många klarar du i år?\nLycka till!", "Vad är en pull-up?");
        }

        private void helpAddedToday(int n)
        {
            int newNr = Convert.ToInt32(addedToday.Text) + n;
            addedToday.Text = newNr.ToString();
        }
           
        private void addOne(object sender, EventArgs e)
        {         
            int newNr = Convert.ToInt32(repsTextBox.Text) + 1;
            repsTextBox.Text = newNr.ToString();
            helpAddedToday(1);
        }

        private void drawOne(object sender, EventArgs e)
        {
            int newNr = Convert.ToInt32(repsTextBox.Text) - 1;
            if (newNr >= 0)
            {
                repsTextBox.Text = newNr.ToString();
                helpAddedToday(-1);
            }
        }

        private void addFreely_clicked(object sender, EventArgs e)
        {
            int newNr = Convert.ToInt32(repsTextBox.Text) + Decimal.ToInt32(addFreelyNr.Value);
            if (newNr >= 0)
            {
                repsTextBox.Text = newNr.ToString();
                helpAddedToday(Decimal.ToInt32(addFreelyNr.Value));
            }
        }

        int picCount = 0;
        private void timerTick(object sender, EventArgs e)
        {
            timer1.Stop();
            picCount += 1;
            if(picCount > 15)
            {
                picCount = 0;
                pic2.Visible = false;
               
            }
            else if(picCount == 10)
            {
                pic2.Visible = true;
            }

            if (pic1.Image.Width == Pull_app__windows_forms_application.Properties.Resources.nere.Width)
            {
                pic1.Image = Pull_app__windows_forms_application.Properties.Resources.uppe;
            }
            else
            {
                pic1.Image = Pull_app__windows_forms_application.Properties.Resources.nere;
            }
            timer1.Enabled = true;
        }
        //Event handler for saving pull-up reps
        private void repsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._bndPullappList.EndEdit();
            this._taPullappAdapterManager.UpdateAll(this._pullappDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Fill the local dataset, which caches the database data locally
            //in memory with data from the database 
            _taPullapp.Fill(_pullappDataSet.RepsTable);

        }

        private void saveReps(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this._bndPullappList.EndEdit();
                this._taPullappAdapterManager.UpdateAll(this._pullappDataSet);

                //@ - gör "\" till tecknet och inte något kommando som exempelvis \n
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Simon\Desktop\Pull-app_project\Pull-app__form-application\Pull-app__windows-forms-application\Pull-app__windows-forms-application\Pull-app_DB.mdf;Integrated Security=True");
                con.Open();
                //WHERE (ID = 1) skulle kunna hämtas från textruta för nyckeln istället
                SqlCommand cmd = new SqlCommand(@"UPDATE RepsTable SET Reps = '" + repsTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmd_jan = new SqlCommand(@"UPDATE RepsTable SET januari = '" + januariTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_jan.ExecuteNonQuery();
                SqlCommand cmd_feb = new SqlCommand(@"UPDATE RepsTable SET februari = '" + februariTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_feb.ExecuteNonQuery();
                SqlCommand cmd_mar = new SqlCommand(@"UPDATE RepsTable SET mars = '" + marsTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_mar.ExecuteNonQuery();
                SqlCommand cmd_apr = new SqlCommand(@"UPDATE RepsTable SET april = '" + aprilTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_apr.ExecuteNonQuery();
                SqlCommand cmd_maj = new SqlCommand(@"UPDATE RepsTable SET maj = '" + majTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_maj.ExecuteNonQuery();
                SqlCommand cmd_jun = new SqlCommand(@"UPDATE RepsTable SET juni = '" + juniTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_jun.ExecuteNonQuery();
                SqlCommand cmd_jul = new SqlCommand(@"UPDATE RepsTable SET juli = '" + juliTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_jul.ExecuteNonQuery();
                SqlCommand cmd_aug = new SqlCommand(@"UPDATE RepsTable SET augusti = '" + augustiTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_aug.ExecuteNonQuery();
                SqlCommand cmd_sep = new SqlCommand(@"UPDATE RepsTable SET september = '" + septemberTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_sep.ExecuteNonQuery();
                SqlCommand cmd_okt = new SqlCommand(@"UPDATE RepsTable SET oktober = '" + oktoberTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_okt.ExecuteNonQuery();
                SqlCommand cmd_nov = new SqlCommand(@"UPDATE RepsTable SET november = '" + novemberTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_nov.ExecuteNonQuery();
                SqlCommand cmd_dec = new SqlCommand(@"UPDATE RepsTable SET december = '" + decemberTextBox.Text + "' WHERE (PullupId = 1)", con);
                cmd_dec.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void KeySave(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl-S Save
            {
                saveReps(sender, e);
                e.SuppressKeyPress = true;// Stops bing! Also sets handled which stop event bubbling
            }
            else if (e.KeyCode == Keys.Left)
            {
                drawOne(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                addOne(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.W)
            {
                e.SuppressKeyPress = true;
                Application.Exit();
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
