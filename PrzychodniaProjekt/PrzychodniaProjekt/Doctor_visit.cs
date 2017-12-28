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
    public partial class Doctor_visit : Form
    {

        public static int id_wiz;
        public static int id_pacjenta;

        public Doctor_visit()
        {
            InitializeComponent();            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void fillForms(string id, string imie, string nazwisko, string id_wiz)
        {
            textBoxIDPatient.Text = id;
            textBoxName.Text = imie;
            textBoxUsername.Text = nazwisko;
            textIDvisit.Text = id_wiz;

            id_pacjenta = int.Parse(id);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Bizz_Doctor.UpdateVisitEnd(int.Parse(textIDvisit.Text),DateTime.Today,textDecription.Text,textDiagnosis.Text);
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Bizz_Doctor.UpdateVisitCancel(int.Parse(textIDvisit.Text), DateTime.Today, textDecription.Text, textDiagnosis.Text);
            this.Hide();
        }

        private void buttonPhExam_Click(object sender, EventArgs e)
        {
            Form1 patientExamsList = new Form1();
            id_wiz = Int32.Parse(textIDvisit.Text);
            
            Exam_dictionary.currentChosenExamType = "fiz";
            patientExamsList.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBadLab_Click(object sender, EventArgs e)
        {
            PatientLabExamList patientLabExamsList = new PatientLabExamList();
            id_wiz = Int32.Parse(textIDvisit.Text);
            
            Exam_dictionary.currentChosenExamType = "lab";
            patientLabExamsList.ShowDialog();
        }
    }
}
