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
    public partial class Supervisor_lab_manage : Form
    {
        public static int static_id_bad;

        public Supervisor_lab_manage(int id_bad)
        {
            InitializeComponent();
            static_id_bad = id_bad;
        }

        public void FillForms(string kod, string uwagi_lek)
        {
            textBoxExaminationCode.Text = kod;
            textBoxExaminationName.Text = Bizz_technician.GetExamName(kod);
            textBoxDoctorComments.Text = uwagi_lek;

            textBoxExaminationRes.Text = Bizz_technician.GetResult(static_id_bad);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void buttonConfirmExam_Click(object sender, EventArgs e)
        {
            Bizz_technician.ManageExam(static_id_bad, textBoxNotes.Text, "confirm");
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void buttonCancelExam_Click(object sender, EventArgs e)
        {
            Bizz_technician.ManageExam(static_id_bad, textBoxNotes.Text, "cancel");
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
