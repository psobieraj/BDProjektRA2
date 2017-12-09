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
            this.patientTableAdapter.Fill(this.przychodniaDataSet.Patient);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //IQueryable<Patients_n_Adresses> patient = Bizz_registry.FilterPatient(textSurname.Text);
            //dgvPatients.DataSource = patient;
        }
    }
}
