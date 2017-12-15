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
    public partial class Registry_register : Form
    {
        public Registry_register()
        {
            InitializeComponent();
        }

        private void Registry_register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przychodniaDataSet1.Doctor' table. You can move, or remove it, as needed.
            //this.doctorTableAdapter.Fill(this.przychodniaDataSet1.Doctor);
            dgvDoctors.DataSource = Bizz_registry.GetDoctors();
        }

        public void fillForms(string nazwisko, string imie, string pesel, string id)
        {
            textSurname.Text = nazwisko;
            textName.Text = imie;
            textPesel.Text = pesel;
            textIDpatient.Text = id;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            int rowindex = dgvDoctors.CurrentCell.RowIndex;

            string ID = dgvDoctors.Rows[rowindex].Cells[0].Value.ToString();
            string Nazwisko = dgvDoctors.Rows[rowindex].Cells[2].Value.ToString();

            textIDdoctor.Text = ID;
            textDoctor.Text = Nazwisko;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int id_rej = 0;

            id_rej = Bizz_registry.checkRegistryLadyID(Login.login_rejestratorki);

            
            Bizz_registry.AddVisit(int.Parse(textIDpatient.Text), id_rej, int.Parse(textIDdoctor.Text), dtpDate.Value);
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textPesel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
