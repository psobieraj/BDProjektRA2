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
    public partial class Registry_cancel : Form
    {
        public Registry_cancel()
        {
            InitializeComponent();
        }

        public void fillForms(string wizyta, string pacjent, string pat_nazw, string pesel)
        {
            textIdVisit.Text = wizyta;
            textIdPatient.Text = pacjent;
            textPatName.Text = pat_nazw;
            textPESEL.Text = pesel;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
                this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Bizz_registry.UpdateVisit(int.Parse(textIdVisit.Text), dtpCancel.Value);
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
