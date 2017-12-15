using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;

namespace PrzychodniaProjekt
{
    public partial class Doctor_main : Form
    {
        public Doctor_main()
        {
            InitializeComponent();
        }

        private void Doctor_main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przychodniaDataSet.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.przychodniaDataSet.Patient);

            dataGridViewVisits.DataSource = Bizz_Doctor.GetVisits((id_pac, Imie, Nazwisko, status, data_rej, data_anul_zak, id_wiz) => new { id_pac, Imie, Nazwisko, status, data_rej, data_anul_zak, id_wiz });
        }

        private void labelMD_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool check = dateTimeRegistration.Checked;

            dataGridViewVisits.DataSource = Bizz_Doctor.FilterVisits(textName.Text, dateTimeRegistration.Value, comboBoxState.Text, check, (id_pac, Imie, Nazwisko, status, data_rej, data_anul_zak, id_wiz) => new { id_pac, Imie, Nazwisko, status, data_rej, data_anul_zak, id_wiz });
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
           
            Doctor_visit doctor_visit = new Doctor_visit();

            int rowindex = dataGridViewVisits.CurrentCell.RowIndex;
            string nazwisko = dataGridViewVisits.Rows[rowindex].Cells[2].Value.ToString();
            string imie = dataGridViewVisits.Rows[rowindex].Cells[1].Value.ToString();
            string id = dataGridViewVisits.Rows[rowindex].Cells[0].Value.ToString();
            string id_wiz= dataGridViewVisits.Rows[rowindex].Cells[6].Value.ToString();


            doctor_visit.fillForms(id, imie, nazwisko, id_wiz);
           
            doctor_visit.ShowDialog();
        }
    }
}
