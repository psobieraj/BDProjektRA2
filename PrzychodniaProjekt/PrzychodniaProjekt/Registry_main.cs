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
            dgvVisits.DataSource = Bizz_registry.GetVisits();
            dgvPatients.DataSource = Bizz_registry.GetPatients();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //IQueryable<Patients_n_Adresses> patient = Bizz_registry.FilterPatient(textSurname.Text);
            dgvPatients.DataSource = Bizz_registry.FilterPatient(textSurname.Text, textName.Text, textPesel.Text);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Registry_cancel registry_cancel = new Registry_cancel();

            int rowindex = dgvVisits.CurrentCell.RowIndex;
            string wizyta = dgvVisits.Rows[rowindex].Cells[0].Value.ToString();
            string pacjent = dgvVisits.Rows[rowindex].Cells[3].Value.ToString();
            string lekarz = dgvVisits.Rows[rowindex].Cells[2].Value.ToString();

            registry_cancel.fillForms(wizyta,pacjent,lekarz);

            registry_cancel.ShowDialog();
        }

        private void btnShowVisits_Click(object sender, EventArgs e)
        {
            dgvVisits.DataSource = Bizz_registry.GetVisits();
        }
    }
}
