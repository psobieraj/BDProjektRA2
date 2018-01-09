using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer;

namespace PrzychodniaProjekt
{
    public partial class Registry_main : Form
    {
        public Registry_main()
        {
            InitializeComponent();
        }

        private void Registry_main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przychodniaDataSet.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.przychodniaDataSet.Patient);
            //dgvVisits.Columns[5].DefaultCellStyle.Format = "yyyy'/'MM'/'dd";
            
            dgvVisits.DataSource = Bizz_registry.GetVisits((id_pac, Imie, Nazwisko, PESEL, Status, data_rej, data_anul_zak, id_wiz) => new { id_pac, Imie, Nazwisko, PESEL, Status, data_rej, data_anul_zak, id_wiz });

            
            dgvPatients.DataSource = Bizz_registry.GetPatients((id_pac, Imie, Nazwisko, PESEL, id_adresu, Miejscowosc, Ulica, Nr_domu, Nr_lokalu) => new { id_pac, Imie, Nazwisko, PESEL, id_adresu, Miejscowosc, Ulica, Nr_domu, Nr_lokalu});
            //((DataGridViewTextBoxColumn)dgvPatients.Columns[5]).MaxInputLength = 6;
            //dgvVisits.Columns[5].DefaultCellStyle.Format = "yyyy'/'MM'/'dd";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //IQueryable<Patients_n_Adresses> patient = Bizz_registry.FilterPatient(textSurname.Text);

            dgvPatients.DataSource = Bizz_registry.FilterPatient(textSurname.Text, textName.Text, textPesel.Text,
                (id_pac, Imie, Nazwisko, PESEL, id_adresu, Miejscowosc, Ulica, Nr_domu, Nr_lokalu) => 
                new { id_pac, Imie, Nazwisko, PESEL, id_adresu, Miejscowosc, Ulica, Nr_domu, Nr_lokalu });

            dgvVisits.DataSource = Bizz_registry.FilterVisit(textSurname.Text, textName.Text, textPesel.Text,
                (id_pac, Imie, Nazwisko, PESEL, Status, data_rej, data_anul_zak, id_wiz) => new { id_pac, Imie, Nazwisko, PESEL, Status, data_rej, data_anul_zak, id_wiz });

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Registry_cancel registry_cancel = new Registry_cancel();

            int rowindex = dgvVisits.CurrentCell.RowIndex;
            string wizyta = dgvVisits.Rows[rowindex].Cells[7].Value.ToString();
            string pacjent = dgvVisits.Rows[rowindex].Cells[0].Value.ToString();
            string pac_nazw = dgvVisits.Rows[rowindex].Cells[2].Value.ToString();
            string pesel = dgvVisits.Rows[rowindex].Cells[3].Value.ToString();

            registry_cancel.fillForms(wizyta,pacjent,pac_nazw,pesel);

            registry_cancel.ShowDialog();
        }

        private void btnShowVisits_Click(object sender, EventArgs e)
        {
            dgvVisits.DataSource = Bizz_registry.GetVisits((id_pac, Imie, Nazwisko, PESEL, Status, data_rej, data_anul_zak, id_wiz) => new { id_pac, Imie, Nazwisko, PESEL, Status, data_rej, data_anul_zak, id_wiz});
            dgvPatients.DataSource=Bizz_registry.GetPatients((id_pac, Imie, Nazwisko, PESEL, id_adresu, Miejscowosc, Ulica, Nr_domu, Nr_lokalu) => new { id_pac, Imie, Nazwisko, PESEL, id_adresu, Miejscowosc, Ulica, Nr_domu, Nr_lokalu });
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Registry_register registry_register = new Registry_register();

            int rowindex = dgvPatients.CurrentCell.RowIndex;
            string nazwisko = dgvPatients.Rows[rowindex].Cells[2].Value.ToString();
            string imie = dgvPatients.Rows[rowindex].Cells[1].Value.ToString();
            string pesel = dgvPatients.Rows[rowindex].Cells[3].Value.ToString();
            string id = dgvPatients.Rows[rowindex].Cells[0].Value.ToString();

            registry_register.fillForms(nazwisko,imie,pesel,id);

            registry_register.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Registry_AddEdit registry_add = new Registry_AddEdit("add");

            registry_add.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Registry_AddEdit registry_edit = new Registry_AddEdit("mod");

            int rowindex = dgvPatients.CurrentCell.RowIndex;
            string id_pac = dgvPatients.Rows[rowindex].Cells[0].Value.ToString();
            string imie = dgvPatients.Rows[rowindex].Cells[1].Value.ToString();
            string nazwisko = dgvPatients.Rows[rowindex].Cells[2].Value.ToString();
            string pesel = dgvPatients.Rows[rowindex].Cells[3].Value.ToString();
            string id_adresu = dgvPatients.Rows[rowindex].Cells[4].Value.ToString();
            string miejscowosc = dgvPatients.Rows[rowindex].Cells[5].Value.ToString();
            string ulica = dgvPatients.Rows[rowindex].Cells[6].Value.ToString();
            string nr_domu = dgvPatients.Rows[rowindex].Cells[7].Value.ToString();
            string nr_lokalu = dgvPatients.Rows[rowindex].Cells[8].Value.ToString();

            registry_edit.fillForms(id_pac, imie, nazwisko, pesel, id_adresu,miejscowosc, ulica, nr_domu, nr_lokalu);

            registry_edit.ShowDialog();
        }

        private void textPesel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Only_Number_Press(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Only_Char_Press(object sender, KeyPressEventArgs e)
        {
        
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
