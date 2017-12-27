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
    public partial class PatientLabExamList : Form
    {

        public static Doctor_examination_laboratory doctor_examination_laboratory = new Doctor_examination_laboratory();
        public PatientLabExamList()
        {
            InitializeComponent();
        }

        private void PatientLabExamList_Load(object sender, EventArgs e)
        {

           dataGridViewExams.DataSource = Bizz_Doctor.GetLaboratoryExaminationList(Doctor_visit.id_pacjenta, (id_pac, Nazwisko, data_wyk, Kod, Nazwa, Uwagi_lekarza, Wynik, Status)
                 => new { id_pac, Nazwisko, data_wyk, Kod, Nazwa, Uwagi_lekarza, Wynik, Status });
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonNextExam_Click(object sender, EventArgs e)
        {
            doctor_examination_laboratory.ShowDialog();
        }
    }
}
