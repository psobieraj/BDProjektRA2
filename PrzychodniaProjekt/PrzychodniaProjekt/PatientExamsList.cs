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
    public partial class Form1 : Form
    {
        public static Doctor_examination_psychical doctor_examination_psychical = new Doctor_examination_psychical();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewExams.DataSource = Bizz_Doctor.GetPhisicalExaminationList(Doctor_visit.id_pacjenta,(id_pac, Nazwisko, data_zak, Kod, Nazwa, Wynik ) 
                => new { id_pac, Nazwisko, data_zak, Kod, Nazwa, Wynik });
        }

        private void buttonNextExam_Click(object sender, EventArgs e)
        {
            doctor_examination_psychical.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
