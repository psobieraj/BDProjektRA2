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
    public partial class Lab_technician_serve_examination : Form
    {
        public static int static_id_bad;

        public Lab_technician_serve_examination()
        {
            InitializeComponent();
        }
        public Lab_technician_serve_examination(int id_bad)
        {
            InitializeComponent();
            static_id_bad = id_bad;
        }

        public void FillForms(string kod, string uwagi_lek)
        {
            textBoxExaminationCode.Text = kod;
            textBoxExaminationName.Text = Bizz_technician.GetExamName(kod);
            //textBoxExaminationResult.Text = wynik;
            textBoxDoctorComments.Text = uwagi_lek;

            textBoxExaminationResult.Text = Bizz_technician.GetResult(static_id_bad);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void buttonServe_Click(object sender, EventArgs e)
        {
            Bizz_technician.PerformExam(static_id_bad, textBoxExaminationResult.Text);

            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Bizz_technician.CancelExam(static_id_bad, textBoxExaminationResult.Text);

            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }//public partial class Lab_technician_serve_examination : Form
}
