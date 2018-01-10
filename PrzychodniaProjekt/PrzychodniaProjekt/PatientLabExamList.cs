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
        //public static int static_id_wiz;
        public static int static_id_pacjenta;

        public static Doctor_examination_laboratory doctor_examination_laboratory = new Doctor_examination_laboratory();

        public PatientLabExamList()
        {
            InitializeComponent();
        }

        public PatientLabExamList(int id_pacjenta)
        {
            InitializeComponent();
            //static_id_wiz = id_wiz;
            static_id_pacjenta = id_pacjenta;
        }

        public void refreshLab()
        {
            dataGridViewExams.DataSource = Bizz_Doctor.GetLaboratoryExaminationList(static_id_pacjenta, (id_pac, Nazwisko, data_wyk, data_zlec, Kod, Nazwa, Uwagi_lekarza, Wynik, Status)
                 => new { id_pac, Nazwisko, data_wyk, data_zlec, Kod, Nazwa, Uwagi_lekarza, Wynik, Status });
            ClearTextBoxes();
        }


        private void PatientLabExamList_Load(object sender, EventArgs e)
        {

           dataGridViewExams.DataSource = Bizz_Doctor.GetLaboratoryExaminationList(static_id_pacjenta, (id_pac, Nazwisko, data_wyk, data_zlec,Kod, Nazwa, Uwagi_lekarza, Wynik, Status)
                 => new { id_pac, Nazwisko, data_wyk, data_zlec, Kod, Nazwa, Uwagi_lekarza, Wynik, Status });
            ClearTextBoxes();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonNextExam_Click(object sender, EventArgs e)
        {
            doctor_examination_laboratory.ShowDialog();
        }

        public void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
